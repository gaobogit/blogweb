using NetCoreWeb.Services.BASE;
using NetCoreWeb.Model.Models;
using NetCoreWeb.IRepository;
using NetCoreWeb.IServices;

namespace NetCoreWeb.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {
	
        IModulePermissionRepository _dal;
        public ModulePermissionServices(IModulePermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
