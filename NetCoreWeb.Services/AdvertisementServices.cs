using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetCoreWeb.IRepository;
using NetCoreWeb.IServices;
using NetCoreWeb.Model.Models;
using NetCoreWeb.Services.BASE;

namespace NetCoreWeb.Services
{
    public class AdvertisementServices : BaseServices<Advertisement>, IAdvertisementServices
    {
        IAdvertisementRepository _dal;
        public AdvertisementServices(IAdvertisementRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        public void ReturnExp()
        {

            int a = 1;
            int b = 0;

            int c = a / b;
        }
    }
}
