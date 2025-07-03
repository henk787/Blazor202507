using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets.Domain
{
    public class Supplier: EntityBase
    {

        [MaxLength(5)]
        public string Name { get; set; }

        public string Address { get; set; }

    }
}
