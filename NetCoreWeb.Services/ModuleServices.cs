using NetCoreWeb.Services.BASE;
using NetCoreWeb.Model.Models;
using NetCoreWeb.IRepository;
using NetCoreWeb.IServices;

namespace NetCoreWeb.Services
{	
	/// <summary>
	/// ModuleServices
	/// </summary>	
	public class ModuleServices : BaseServices<Module>, IModuleServices
    {
	
        IModuleRepository _dal;
        public ModuleServices(IModuleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
