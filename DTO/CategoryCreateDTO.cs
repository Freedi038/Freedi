using FrediTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.DTO
{
    public class CategoryCreateDTO
    {
        public string Name { get; set; }
        public virtual ICollection<ProductCreateDTO> Products { get; set; }
    }
}
