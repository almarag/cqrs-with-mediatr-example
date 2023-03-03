using StudentsMicroService.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMicroService.Infrastructure.Repositories
{
    public class SqliteRepository
    {
        protected ApplicationDbContext _context;

        public SqliteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
