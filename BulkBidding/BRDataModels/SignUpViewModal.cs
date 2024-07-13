using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRDataModels
{
    public class SignUpViewModal
    {
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public bool isActive { get; set; }
        public bool isCompany { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public int telePhone { get; set; }
        public string webSite { get; set; }
        public int panNo { get; set; }
    }
}
