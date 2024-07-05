using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderSample.Models
{
    public class Order
    {
        public int Number { get; init; }
        public DateOnly CreatedOn { get; init; }
        public Address? ShippingAddress { get; init; }
    }
}
