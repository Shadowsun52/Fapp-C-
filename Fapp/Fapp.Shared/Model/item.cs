using System;
using System.Collections.Generic;
using System.Text;

namespace Fapp.Model
{
    public class item
    {
        public int id { get; set; }
        public string label { get; set; }
        public DateTime expirationDate { get; set; }
        public int quantity { get; set; }
        public int nbShelf { get; set; }

        public override string ToString()
        {
            return this.label;
        }
    }
}
