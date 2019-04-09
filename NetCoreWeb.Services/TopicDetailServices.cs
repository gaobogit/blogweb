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
    public class TopicDetailServices : BaseServices<TopicDetail>, ITopicDetailServices
    {
        ITopicDetailRepository _dal;
        public TopicDetailServices(ITopicDetailRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        /// <summary>
        /// 获取开Bug数据（缓存）
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration = 10)]
        public async Task<List<TopicDetail>> GetTopicDetails()
        {
            return await base.Query(a => !a.tdIsDelete && a.tdSectendDetail == "tbug");
        }
    }
}
