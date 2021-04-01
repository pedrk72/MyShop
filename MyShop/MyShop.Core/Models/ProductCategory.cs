using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        // Como o Base Entity (abstract model) já tem um Id, podemos tirar daqui
        //public string  Id { get; set; }
        public string Category { get; set; }

        /*
        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }*/
    }
}
