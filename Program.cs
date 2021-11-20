using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pauchenochek
{
    class Program
    {
        static void Main(string[] args)
        {
            KurinayaNozhka Chicken = new KurinayaNozhka("fried");
            KurinayaNozhka Pigeon = new KurinayaNozhka("unfried", 1);
            KurinayaNozhka DuckDuckGo = new KurinayaNozhka("unfried", 1, "sad");
            Chicken.Being_eaten();
            DuckDuckGo.Is_going_to_be_eaten();
            Pigeon.Being_broken();
            //Console.ReadKey(); 
        }

        public class KurinayaNozhka
        {

            public KurinayaNozhka(string y)
            {
                this.type = y;
            }


            public KurinayaNozhka(string y, int x)
            {
                this.type = y;
                this.age = x;
            }


            public KurinayaNozhka(string y, int x, string a)
            {
                this.type = y;
                this.age = x;
                this.mood = a;
            }


            string type;
            int age;
            string mood;

            public void Being_eaten()
            {
                Console.WriteLine(type + " хрум-хрум");
            }
            public void Being_broken()
            {
                Console.WriteLine(type + " жмяк");
            }
            public void Is_going_to_be_eaten()
            {
                Console.WriteLine(type + " скоро будет");
            }




           
        }
    }
}