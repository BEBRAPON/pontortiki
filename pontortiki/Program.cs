using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontortiki
{
    internal class Program
    {
        static void Main()
        {
             while (true)
            {
                strelochMen();
                Console.WriteLine("Если вы хотите сделать еще один заказ, нажмите Tab.\r\nДля выхода нажмите Escape.");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                glavMen();
                if (key.Key != ConsoleKey.Tab)
                    break;
                if (key.Key == ConsoleKey.Escape)
                    Environment.Exit(0);
            }
            Console.Clear();
        }
        static void glavMen()
        {
            Console.WriteLine("Заказ тортов ПОНОС ОБЕСПЕЧЕН.)");
             Console.WriteLine("Выберите параметры для торта: \r\n---------------------------------\r\n  Форма\r\n  Размер\r\n  Вкус коржей\r\n" +
                "  Количество коржей\r\n  Глазурь\r\n  Декор\r\n  Конец заказа");
            Console.WriteLine("");
            Console.WriteLine("Цена: ");
            Console.WriteLine("Торт: ");
        }
        static void strelochMen()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int poss = 3;
            int cena = 0;
            List<string> names = new List<string>();
            while (true)
            {
                Console.Clear();
                glavMen();
                poss = Pos(key, poss);
                if (poss < 3) 
                {
                    poss = 3;
                }
                if (poss > 9) 
                {
                    poss = 9;
                }
                Console.SetCursorPosition(0, poss);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter && poss == 9)
                {
                    Console.Clear();
                    break; 
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    var legenda = StrelochMen2(key, poss);
                    Console.Clear();
                    glavMen();
                    cena = cena + legenda.Item1;
                    names.Add(legenda.Item2);
                }
                Console.SetCursorPosition(7, 11);
                Console.WriteLine(cena);
                Console.SetCursorPosition(11, 12);
                foreach (string i in names)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
                ConsoleKeyInfo KeyKey = Console.ReadKey();
                key = KeyKey;
                Console.Clear();
            }
            Console.Clear();
            Class1.full(cena, names);
        }
        static int Pos(ConsoleKeyInfo key2, int pos2)
        {
            if (key2.Key == ConsoleKey.DownArrow)
            {
                pos2++;
            }
            if (key2.Key == ConsoleKey.UpArrow) 
            {
                pos2--;
            }
            return pos2;
        }
        static Tuple<int, string> StrelochMen2(ConsoleKeyInfo key1, int pos1)
        {
            string elements = "";
            int summ = 0;
            int posA = 0;
            string a = "";
            int b = 0;
            int pos3;
            while (true)
            {
                pos3 = pos1 - 3;
                Class1 menupart = Class1.Menu(pos3);
                for (int i = 0; i < 5; i++)
                {
                    a = menupart.nazvan[i];
                    b = menupart.stoim[i];
                    Console.Write("  ");
                    Console.Write(a);
                    Console.Write(" - ");
                    Console.WriteLine(b);
                }

                posA = Pos(key1, posA);
                if (posA < 0) 
                {
                    posA = 4;
                }
                if (posA > 4)
                {
                    posA = 0;
                }
                Console.SetCursorPosition(0, posA);
                Console.WriteLine("->");
                ConsoleKeyInfo keyA = Console.ReadKey();
                key1 = keyA;
                Console.Clear();
                if (keyA.Key == ConsoleKey.Enter)
                {
                    summ = menupart.stoim[posA];
                    elements = menupart.nazvan[posA];
                    break;
                }
            }
            return Tuple.Create(summ, elements);
        }
          
            
        

    }
}
