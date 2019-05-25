using System;
using System.Collections.Generic;
using System.Text;

namespace MTest.Model
{
    public class City
    {
        public City()
        {
            this.Customers = new HashSet<Customer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
