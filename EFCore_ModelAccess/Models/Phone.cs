using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ModelAccess.Models
{
    [Table("Tbl_Phone")]
    public class Phone
    {
        [Column("PhoneId")]
        public int Id { get; set; }
        [Column("PhoneName")]
        public string? PhoneModel { get; set; }
        public string? CompanyFullName { get; set; }
        public decimal Price { get; set; }
    }
}
