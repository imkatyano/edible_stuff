using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pauchenochek
{
    class Program               // создала класс Program, в котором есть метод и класс (подкласс) - ✔
    {
        static void Main(string[] args)     // метод Main класса Program - ✔
        {
            KurinayaNozhka Chicken = new KurinayaNozhka("fried");   // объект Chicken = объект класса KurinayaNozhka - ✔
            KurinayaNozhka Pigeon = new KurinayaNozhka("unfried", 1);
            KurinayaNozhka DuckDuckGo = new KurinayaNozhka("unfried", 1, "sad");
            Chicken.Being_eaten();          // вызов метода Being_eaten() для объекта Chicken - ✔
            DuckDuckGo.Is_going_to_be_eaten();
            Pigeon.Being_broken();
            //Console.ReadKey();                  // в интернете написано, что метод используется, чтобы консольное окно сразу не исчезло после запуска программы - ✔
        }

        public class KurinayaNozhka          // класс KurinayaNozhka внутри класса Program - ✔
        {
            string type;              // объявление переменных всех объектов этого класса - ✔
            int age;                  //Пропиши модификаторы доступа!!!
            string mood;

            public KurinayaNozhka(string y)    //  конструктор класса KurinayaNozhka (который может и не использоваться)
                                               //  + указание, что он идентифицируется только тем, что в нём переменная y 
            {
                this.type = y;                 //  ???  если в объявлении объекта класса есть инфа про то, что он идентифицируется только
                                               //  по налицию в нём единственной переменной - y - то во такое создано, а что это хз!!!!!!!
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

            public void Being_eaten() // объявление функции Being_eaten, которая выводит на консоль переменную type, указанную в объявлении объекта класса, и значение в " " -  ✔
            {
                Console.WriteLine(type + ", хрум-хрум");
            }
            public void Being_broken()
            //кек - ✔
            {
                Console.WriteLine(type + ", " + age + ", жмяк");
            }
            public void Is_going_to_be_eaten() 
            {
                Console.WriteLine(type + ", " + age + ", " + mood + ", скоро будет");
            }




           
        }
    }
}

// добавила в две последние функции вывод не только string переменной - ✔