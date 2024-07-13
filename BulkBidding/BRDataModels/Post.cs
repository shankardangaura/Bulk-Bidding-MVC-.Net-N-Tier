using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRDataModels
{
    public class Post
    {
        public int Id { get; set; }
        public int PostById { get; set; }
        public string PostBy { get; set; }
        public string PostOn { get; set; }
        public string ModifiedOn { get; set; }
        public bool IsAccepted { get; set; }
        public int AcceptedById { get; set; }
        public string AcceptedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedById { get; set; }
        public string DeletedOn { get; set; }
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
