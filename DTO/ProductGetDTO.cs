using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.DTO
{
    public class ProductGetDTO
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public CategoryGetDTO Category { get; set; }
    }
}
