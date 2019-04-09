using NetCoreWeb.IServices.BASE;
using NetCoreWeb.Model.Models;
using System.Threading.Tasks;

namespace NetCoreWeb.IServices
{	
	/// <summary>
	/// RoleServices
	/// </summary>	
    public interface IRoleServices :IBaseServices<Role>
	{
        Task<Role> SaveRole(string roleName);
        Task<string> GetRoleNameByRid(int rid);

    }
}
