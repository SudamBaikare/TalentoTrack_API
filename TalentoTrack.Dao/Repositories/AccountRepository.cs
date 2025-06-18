using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Dao.DB;
using TalentoTrack.Common.Entities;
using TalentoTrack.Common.Repositories;

namespace TalentoTrack.Dao.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        public TalentoTrack_DbContext _dbContext;

        public AccountRepository(TalentoTrack_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<LoginDetails> GetLoginDetails(string userName , string password)
        {
            var dbRecord =await _dbContext.tbl_login_details.Where(p => (p.UserName!=null && p.UserName.Equals(userName))
                        && (p.Password!=null && p.Password.Equals(password))).FirstOrDefaultAsync();



            return dbRecord!;
        }
    }
}
