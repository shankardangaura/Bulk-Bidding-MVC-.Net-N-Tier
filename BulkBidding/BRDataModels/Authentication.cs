using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRDataModels
{
    public class Authentication
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
        public bool isCompany { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public int telePhone { get; set; }
        public string webSite { get; set; }
        public int panNo { get; set; }

        public int postId { get; set; }
        public DateTime postOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public int modifiedBy { get; set; }
        public bool isAccepted { get; set; }
        public int isAcceptedBy { get; set; }
        public bool isDeleted { get; set; }
        public string deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public int commentId { get; set; }
        public string comment { get; set; }
        public int commentedBy { get; set; }
    }
}
