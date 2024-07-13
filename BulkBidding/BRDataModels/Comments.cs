using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRDataModels
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string PostBy { get; set; }
        public string CommentBy { get; set; }
        public string CommentOn { get; set; }
        public string ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedById { get; set; }
        public string DeletedOn { get; set; }
        public string PostComment { get; set; }
        public string PostDescription { get; set; }
    }
}
