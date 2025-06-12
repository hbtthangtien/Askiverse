//const userId = document.getElementById("examForm")?.dataset?.userid;
//const examId = document.querySelector('input[name="ExamId"]').value;

let localData = JSON.parse(localStorage.getItem("examStates") || "{}");

function saveLocalState() {
	localStorage.setItem("examStates", JSON.stringify(localData));
}

window.addEventListener("DOMContentLoaded", () => {
	if (!userId || !examId) {
		console.error("Missing userId or examId.");
		return;
	}

	// ⏪ Khôi phục đáp án
	const savedAnswers = localData[userId]?.[examId]?.selectedAnswers || {};
	for (const name in savedAnswers) {
		const value = savedAnswers[name];
		const radio = document.querySelector(`input[name="${name}"][value="${value}"]`);
		if (radio) {
			radio.checked = true;
			const match = name.match(/Answers\[(\d+)\]/);
			if (match) {
				const index = parseInt(match[1]);
				const btn = document.querySelector(`.question-nav-btn[data-question-index="${index}"]`);
				if (btn) btn.classList.add("answered");
			}
		}
	}

	// ⏱️ Đếm ngược
	const formEl = document.getElementById("examForm");
	const countdownEl = document.getElementById("time");
	const submitBtn = document.getElementById("submitBtn");

	const totalTimeAttr = parseInt(formEl.dataset.totalSeconds || "0");
	let totalTime = totalTimeAttr;

	const savedTime = localData[userId]?.[examId]?.timeRemaining;
	const lastUpdated = localData[userId]?.[examId]?.lastUpdated;

	if (savedTime !== undefined && lastUpdated !== undefined) {
		const now = Date.now();
		const secondsElapsed = Math.floor((now - lastUpdated) / 1000);
		totalTime = savedTime - secondsElapsed;
	}

	function autoSubmitExam() {
		document.getElementById("timeoutModal").style.display = "flex";

		// Xóa dữ liệu để tránh khôi phục sau khi refresh
		if (localData[userId] && localData[userId][examId]) {
			delete localData[userId][examId];
			saveLocalState();
			console.log("🧹 Đã xoá localStorage khi hết giờ");
		}
	}

	window.confirmAutoSubmit = function () {
		document.getElementById("timeoutModal").style.display = "none";
		actuallySubmitExam();
	};

	window.actuallySubmitExam = function () {
		const form = document.getElementById("examForm");
		const formData = new FormData(form);
		const token = document.querySelector('input[name="__RequestVerificationToken"]').value;

		fetch(form.action, {
			method: 'POST',
			headers: {
				'X-Requested-With': 'XMLHttpRequest'
			},
			body: new URLSearchParams(formData)
		})
			.then(response => response.json())
			.then(data => {
				if (localData[userId]) {
					delete localData[userId];
					saveLocalState();
				}
				if (data.success) {
					const postForm = document.createElement("form");
					postForm.method = "POST";
					postForm.action = "/Exam/SubmitExamResult";

					const inputs = [
						["__RequestVerificationToken", token],
						["examScoredId", data.examScoredId],
						["examId", data.examId]
					];

					inputs.forEach(([name, value]) => {
						const input = document.createElement("input");
						input.type = "hidden";
						input.name = name;
						input.value = value;
						postForm.appendChild(input);
					});

					document.body.appendChild(postForm);
					postForm.submit();
				} else {
					const errorParam = encodeURIComponent(data.error);
					window.location.href = `/Exam/SubmitExamResult?error=${errorParam}`;
				}
			})
			.catch(err => {
				console.error("Submit error:", err);
				alert("Gửi bài không thành công. Vui lòng kiểm tra kết nối.");
			});
	};

	function updateCountdown() {
		if (totalTime < 0) {
			clearInterval(timerInterval);
			countdownEl.innerText = "0:00";
			submitBtn.disabled = true;
			autoSubmitExam();
			return;
		}

		const minutes = Math.floor(totalTime / 60);
		const seconds = totalTime % 60;
		countdownEl.innerText = `${minutes}:${seconds.toString().padStart(2, '0')}`;

		const now = Date.now();
		if (!localData[userId]) localData[userId] = {};
		if (!localData[userId][examId]) localData[userId][examId] = {};
		localData[userId][examId]["timeRemaining"] = totalTime;
		localData[userId][examId]["lastUpdated"] = now;
		saveLocalState();

		totalTime--;
	}

	if (totalTime <= 0) {
		autoSubmitExam();
		return;
	}

	updateCountdown();
	const timerInterval = setInterval(updateCountdown, 1000);

	if (totalTime <= 600) {
		const countdownBox = document.getElementById("countdown");
		countdownBox.style.backgroundColor = "#FFF1F0";
		countdownBox.style.borderColor = "#ff4d4f";
		countdownBox.style.color = "#c41d7f";
		countdownBox.style.boxShadow = "0 0 12px rgba(255, 77, 79, 0.3)";
	}

	// ⏭️ Hiển thị câu hỏi & lưu thời gian từng câu
	let currentQuestionIndex = 0;
	window.showQuestion = function (index) {
		const now = Date.now();
		if (!localData[userId]) localData[userId] = {};
		if (!localData[userId][examId]) localData[userId][examId] = {};
		if (!localData[userId][examId]["timePerQuestion"]) localData[userId][examId]["timePerQuestion"] = {};

		const lastSwitch = localData[userId][examId]["lastSwitch"] || now;
		const elapsed = Math.floor((now - lastSwitch) / 1000);
		const currentKey = `q${currentQuestionIndex}`;
		localData[userId][examId]["timePerQuestion"][currentKey] =
			(localData[userId][examId]["timePerQuestion"][currentKey] || 0) + elapsed;

		localData[userId][examId]["lastSwitch"] = now;
		currentQuestionIndex = index;
		saveLocalState();

		document.querySelectorAll('.question-box').forEach(box => {
			box.style.display = 'none';
			box.style.opacity = 0;
		});
		const next = document.getElementById(`question-${index}`);
		if (!next) return;
		next.style.display = 'block';
		setTimeout(() => {
			next.style.opacity = 1;
		}, 100);
	};

	// 🔁 Gán sự kiện chuyển câu hỏi
	document.querySelectorAll('.question-nav-btn').forEach(btn => {
		btn.addEventListener('click', () => {
			const index = parseInt(btn.dataset.questionIndex);
			window.showQuestion(index);
		});
	});

	// 🟢 Ghi nhận đáp án khi chọn
	document.querySelectorAll('input[type="radio"]').forEach(radio => {
		radio.addEventListener('change', function () {
			const name = this.name;
			const match = name.match(/Answers\[(\d+)\]/);
			if (match) {
				const index = parseInt(match[1]);
				const btn = document.querySelector(`.question-nav-btn[data-question-index="${index}"]`);
				if (btn) btn.classList.add("answered");
			}

			if (!localData[userId]) localData[userId] = {};
			if (!localData[userId][examId]) localData[userId][examId] = {};
			if (!localData[userId][examId]["selectedAnswers"]) localData[userId][examId]["selectedAnswers"] = {};
			localData[userId][examId]["selectedAnswers"][name] = this.value;
			saveLocalState();
		});
	});

	// 📝 Cảnh báo khi còn câu chưa làm
	document.getElementById("examForm").addEventListener("submit", function (e) {
		const unanswered = [];
		document.querySelectorAll('.question-box').forEach((box, index) => {
			const hasChecked = box.querySelector('input[type="radio"]:checked');
			if (!hasChecked) unanswered.push(index + 1);
		});

		if (unanswered.length > 0) {
			const confirmText = `⚠️ Bạn chưa trả lời các câu: ${unanswered.join(', ')}.\nBạn vẫn muốn nộp bài?`;
			if (!confirm(confirmText)) {
				e.preventDefault();
				return;
			}
		}

		if (localData[userId]) {
			clearInterval(timerInterval);
			delete localData[userId];
			saveLocalState();
		}
	});
});
