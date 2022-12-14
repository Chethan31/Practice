using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1.Entities
{
   // [Table("tbl_contacts")]//for table name
    public class Contact
    {
        //[Key]   //for primary key
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]  //to make non increment
        public int ContactID { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName="VARCHAR")]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
       // [NotMapped]   
    }
}
