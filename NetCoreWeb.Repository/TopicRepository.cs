using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreWeb.IRepository;
using NetCoreWeb.Model.Models;
using NetCoreWeb.Repository.Base;

namespace NetCoreWeb.Repository
{
    public class TopicRepository: BaseRepository<Topic>, ITopicRepository
    {
    }
}
