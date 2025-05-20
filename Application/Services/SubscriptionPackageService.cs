using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SubscriptionPackageService : Service, ISubscriptionPackagesService
    {
        public SubscriptionPackageService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
