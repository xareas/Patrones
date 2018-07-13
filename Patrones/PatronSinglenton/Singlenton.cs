using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WebPatrones.PatronSinglenton
{
    public class Singlenton
    {
        
        private static  readonly  Singlenton instance = new Singlenton();

        private Singlenton()
        {
        }

       
        public static Singlenton GetSinglenton()
        {
           
            
            return instance;
            
          
            
        }
    }
}