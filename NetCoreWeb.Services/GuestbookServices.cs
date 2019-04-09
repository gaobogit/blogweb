using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreWeb.IRepository;
using NetCoreWeb.IServices;
using NetCoreWeb.Model.Models;
using NetCoreWeb.Services.BASE;

namespace NetCoreWeb.Services
{
    public class GuestbookServices : BaseServices<Guestbook>, IGuestbookServices
    {
        IGuestbookRepository _dal;
        public GuestbookServices(IGuestbookRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}
