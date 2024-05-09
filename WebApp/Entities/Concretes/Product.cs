using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
