using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product : BaseEntity
    {
        // Como o Base Entity (abstract model) já tem um Id, podemos tirar daqui
        //public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        
        [Range(0,1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        //Contrutores
        /*
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }*/
    }
}
