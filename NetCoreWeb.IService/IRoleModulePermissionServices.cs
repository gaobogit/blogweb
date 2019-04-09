using NetCoreWeb.IServices.BASE;
using NetCoreWeb.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreWeb.IServices
{	
	/// <summary>
	/// RoleModulePermissionServices
	/// </summary>	
    public interface IRoleModulePermissionServices :IBaseServices<RoleModulePermission>
	{

        Task<List<RoleModulePermission>> GetRoleModule();
        Task<List<RoleModulePermission>> TestModelWithChildren();
    }
}
