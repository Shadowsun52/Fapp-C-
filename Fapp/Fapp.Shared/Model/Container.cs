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
        //envoyées et parce qu'il y a peu de type (frigo et congel)
        public int type { get; set; }

        public override string ToString()
        {
            return this.name;
        }

        public Container(int id, String name, DateTime lastSync, int type)
        {
            this.id = id;
            this.name = name;
            this.lastSync = lastSync;
            this.type = type;
        }



    }
}
