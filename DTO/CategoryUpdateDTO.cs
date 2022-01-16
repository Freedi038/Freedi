using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.DTO
{
    public class CategoryUpdateDTO
    {
        public string Name { get; set; }
        public virtual ICollection<ProductUpdateDTO> Products { get; set; }
    }
}
