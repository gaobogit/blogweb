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
    public partial class PasswordLibRepository : BaseRepository<PasswordLib>, IPasswordLibRepository
    {

    }
}
