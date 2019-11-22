using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novemberprojectet
{
    class card1
    {
        public int cardvalue;
        private string cardname;
        public static string[] cardsuits = { "Two", "Three", "four", "five", "six", "seven", "eight", "nine", "ten", "ace" };
        //lista som skappar namne för alla korten.

        private Random generator = new Random();
        //random generator som gör ett slumpmäsight nummer
        public card1()
        {

            // den här tar ett random nummer mellan 1 och 9 och para ihop med en av namnen i arreyen.
            cardvalue = generator.Next(cardsuits.Length);
            cardname = cardsuits[cardvalue];
            cardvalue++;
            cardvalue++;
        }//ökar cardvalue med två så att det stämmer med värdet.

        public string whatsuit()
        {
            return cardname;
            //här returnas namnet på kortet.

        }
    }
}
