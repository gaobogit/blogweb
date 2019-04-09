using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreWeb.Common;
using NetCoreWeb.IRepository;
using NetCoreWeb.IServices;
using NetCoreWeb.Model.Models;
using NetCoreWeb.Services.BASE;

namespace NetCoreWeb.Services
{
    public class TopicServices: BaseServices<Topic>, ITopicServices
    {

        ITopicRepository _dal;
        public TopicServices(ITopicRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        /// <summary>
        /// 获取开Bug专题分类（缓存）
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration = 60)]
        public async Task<List<Topic>> GetTopics()
        {
            return await base.Query(a => !a.tIsDelete && a.tSectendDetail == "tbug");
        }

    }
}
