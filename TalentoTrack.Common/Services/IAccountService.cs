using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;

namespace TalentoTrack.Common.Services
{
    public interface IAccountService
    {
        Task<LoginResponse> VerifyLoginDetails(LoginRequests requests);

    }
}
