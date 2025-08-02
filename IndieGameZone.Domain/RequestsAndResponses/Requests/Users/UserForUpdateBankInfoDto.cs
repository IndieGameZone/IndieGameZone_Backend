using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public class UserForUpdateBankInfoDto
    {
        [Required]
        public string BankName { get; set; }
        [Required]
        public string BankAccountNumber { get; set; }
        [Required]
        public string BankAccountName { get; set; }
        [Required]
        public string BankCode { get; set; }
        [Required]
        public string BankBin { get; set; }
        [Required]
        public string BankShortName { get; set; }
    }
}
