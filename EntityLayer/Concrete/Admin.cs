using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public String UserName { get; set; }
        [StringLength(1)]
        public String AdminRole { get; set; }
        [StringLength(20)]
        public String Password { get; set; }
    }
}
