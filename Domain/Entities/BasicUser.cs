﻿using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BasicUser : IdentityUser
    {
        public DateTime CreatedAt { get; set; }

        public AccountStatus AccountStatus { get; set; }

        public virtual Profile? Profile { get; set; }

        public virtual PremiumUser? PremiumUser { get; set; }

        public virtual ICollection<Notification> SentNotifications { get; set; } = new List<Notification>();

        public virtual ICollection<Notification> ReceiveNotifications { get; set; } = new List<Notification>();

        public virtual ICollection<HistoryPurchase> HistoryPurchase { get; set; } = new List<HistoryPurchase>();

        public virtual ICollection<ExamScored> ExamScored { get; set; } = new List<ExamScored>();

        public virtual ICollection<ForumPost> ForumPosts { get; set; } = new List<ForumPost>();

        public virtual ICollection<ForumComment> ForumComments { get; set; } = new List<ForumComment>();

        public virtual ICollection<ForumVoted> ForumVoteds { get; set; } = new List<ForumVoted>();

        public virtual ICollection<ExamAccess> ExamAccesses { get; set; } = new List<ExamAccess>();

        public virtual ICollection<PackageOfUser> PackageOfUsers { get; set; } = new List<PackageOfUser>()!;

        public virtual ICollection<Favourite> Favourites { get; set; } = new List<Favourite>();
    }
}
