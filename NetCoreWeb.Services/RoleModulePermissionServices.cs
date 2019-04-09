using NetCoreWeb.Services.BASE;
using NetCoreWeb.Model.Models;
using NetCoreWeb.IServices;
using NetCoreWeb.IRepository;
using System.Threading.Tasks;
using System.Collections.Generic;
using NetCoreWeb.Common;

namespace NetCoreWeb.Services
{
    /// <summary>
    /// RoleModulePermissionServices 应用服务
    /// </summary>	
    public class RoleModulePermissionServices : BaseServices<RoleModulePermission>, IRoleModulePermissionServices
    {
        readonly IRoleModulePermissionRepository _dal;
        readonly IModuleRepository _moduleRepository;
        readonly IRoleRepository _roleRepository;

        // 将多个仓储接口注入
        public RoleModulePermissionServices(IRoleModulePermissionRepository dal, IModuleRepository moduleRepository, IRoleRepository roleRepository)
        {
            this._dal = dal;
            this._moduleRepository = moduleRepository;
            this._roleRepository = roleRepository;
            base.BaseDal = dal;
        }

        /// <summary>
        /// 获取全部 角色接口(按钮)关系数据
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration = 10)]
        public async Task<List<RoleModulePermission>> GetRoleModule()
        {
            var roleModulePermissions = await base.Query(a => a.IsDeleted == false);
            if (roleModulePermissions.Count > 0)
            {
                foreach (var item in roleModulePermissions)
                {
                    item.Role = await _roleRepository.QueryByID(item.RoleId);
                    item.Module = await _moduleRepository.QueryByID(item.ModuleId);
                }

            }
            return roleModulePermissions;
        }

        public async Task<List<RoleModulePermission>> TestModelWithChildren()
        {
            return await _dal.WithChildrenModel();
        }
    }
}
