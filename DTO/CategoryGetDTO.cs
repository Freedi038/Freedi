using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.DTO
{
    public class CategoryGetDTO
    {
        public string Name { get; set; }
        public virtual ICollection<ProductGetDTO> Products { get; set; }
    }
}
