using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Repositories;
using TalentoTrack.Common.Services;

namespace TalentoTrack.Service
{
    public class AccountService : IAccountService
    {

        public readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {

            _accountRepository = accountRepository;
        }
       public async Task<LoginResponse> VerifyLoginDetails(LoginRequests requests)
        {
            LoginResponse response = new LoginResponse();
            try
            {
                var dbUser =await _accountRepository.GetLoginDetails(requests.Username!, requests.Password!);
                if (dbUser == null) { 
                response.Succes=false;
                response.ErrorMessage = "Invalid Credentials";
                }
                else
                {
                    response.Succes=true;
                }
                return response;
            }
            catch(Exception e) {
                throw;
            }

        }
    }
}
