using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_example_1.Models
{

    [Table("Product")]
    public class ProductModel
    {
        [Column("Id")]
        [Display(Name ="Id")]
        public int id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string name { get; set; }
    }
}
