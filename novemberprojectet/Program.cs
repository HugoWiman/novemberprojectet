﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novemberprojectet
{
    class Program
    {
        static void Main(string[] args)
        {
            card1 korttest = new card1 ();
            Console.WriteLine(korttest.whatsuit());
            Console.WriteLine(korttest.cardvalue);
         
          
            Console.ReadKey();
        }
        




    }   
    
}
