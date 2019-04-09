using NetCoreWeb.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreWeb.IRepository
{	
	/// <summary>
	/// IRoleModulePermissionRepository
	/// </summary>	
	public interface IRoleModulePermissionRepository : IBaseRepository<RoleModulePermission>//类名
    {
        Task<List<RoleModulePermission>> WithChildrenModel();
    }
}
