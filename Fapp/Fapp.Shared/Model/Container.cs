using System;
using System.Collections.Generic;
using System.Text;

namespace Fapp.Model
{
    public class Container
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime lastSync { get; set; }
        //le type est en int pour diminuer la taille des données
        //envoyées et parce qu'il y a peut de type (frigo et congel)
        public int type { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
