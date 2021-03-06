using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]
        public String UserName { get; set; }
        [StringLength(50)]
        public String Mail { get; set; }
        [StringLength(300)]
        public String CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blogs { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogRating { get; set; }

    }

}
