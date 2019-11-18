using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novemberprojectet
{
    class cardvaulu
    {
        private int cardvalue;
       
        private Random generator = new Random();

        public cardvaulu()
        {
            cardvalue = generator.Next(1 , 11);

        }
        
    }
}
