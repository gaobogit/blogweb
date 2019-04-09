using NetCoreWeb.IServices.BASE;
using NetCoreWeb.Model.Models;
using System.Threading.Tasks;

namespace NetCoreWeb.IServices
{	
	/// <summary>
	/// UserRoleServices
	/// </summary>	
    public interface IUserRoleServices :IBaseServices<UserRole>
	{

        Task<UserRole> SaveUserRole(int uid, int rid);
        Task<int> GetRoleIdByUid(int uid);
    }
}

