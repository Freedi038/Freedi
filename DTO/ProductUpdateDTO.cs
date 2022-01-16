using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.DTO
{
    public class ProductUpdateDTO
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
    }
}
