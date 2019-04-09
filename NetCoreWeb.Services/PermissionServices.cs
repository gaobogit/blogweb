using NetCoreWeb.Services.BASE;
using NetCoreWeb.Model.Models;
using NetCoreWeb.IRepository;
using NetCoreWeb.IServices;

namespace NetCoreWeb.Services
{	
	/// <summary>
	/// PermissionServices
	/// </summary>	
	public class PermissionServices : BaseServices<Permission>, IPermissionServices
    {
	
        IPermissionRepository _dal;
        public PermissionServices(IPermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
