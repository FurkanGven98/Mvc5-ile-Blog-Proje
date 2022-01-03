using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [StringLength(50)]
        public String AuthorName { get; set; }
        [StringLength(100)]
        public String AuthorImage { get; set; }
        [StringLength(250)]
        public String AuthorAbout { get; set; }
        public ICollection<Blog> Blogs { get; set; }



    }
}
