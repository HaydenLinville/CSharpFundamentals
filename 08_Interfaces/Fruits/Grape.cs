using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruits
{
    public class Grape : IFruit
    {
        public Grape() { }
        public Grape(bool isPeeled)
        {
            IsPeeled = isPeeled;

        }

        public string Name
        {
            get
            {
                return "Grape";
            }
        }


        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Who peels a grape?";
        }

    }
}
