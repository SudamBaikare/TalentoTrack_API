using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentoTrack.Common.DTOs.Account
{
    public class LoginResponse
    {
        public bool Succes { get; set; }
        public string? ErrorMessage { get; set; }

    }
}
