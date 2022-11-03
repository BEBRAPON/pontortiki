using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontortiki
{
    internal class Class1
    {
        public string[] nazvan = new string[5];
        public int[] stoim = new int[5];
        public static void full(int summma, List<string> cake)
        {
            DateTime date = DateTime.Now;
            String date1 = date.ToShortDateString();
            string tort = string.Join(", ", cake);
            string path = "C:\\Users\\zxcpencil\\Documents\\история заказов.txt";
            File.AppendAllText(path, "Заказ от: " + date1 + "\n");
            File.AppendAllText(path, "Ваш торт: " + tort + "\n");
            File.AppendAllText(path, "Сумма заказа: " + summma + "\n" + "\n");
        }

        public static Class1 Menu(int posin)
        {
            Class1 form = new Class1();
            form.nazvan[0] = "Круг";
            form.nazvan[1] = "Квадрат";
            form.nazvan[2] = "Треугольник";
            form.nazvan[3] = "Овал";
            form.nazvan[4] = "Паралелограмм";
            form.stoim[0] = 100;
            form.stoim[1] = 100;
            form.stoim[2] = 100;
            form.stoim[3] = 101;
            form.stoim[4] = 102;
            Class1 razmer = new Class1();
            razmer.nazvan[0] = "Маленький";
            razmer.nazvan[1] = "Cредний";
            razmer.nazvan[2] = "Большой";
            razmer.nazvan[3] = "XXL";
            razmer.nazvan[4] = "S";
            razmer.stoim[0] = 100;
            razmer.stoim[1] = 120;
            razmer.stoim[2] = 130;
            razmer.stoim[3] = 140;
            razmer.stoim[4] = 150;

            Class1 vkusKorzh = new Class1();
            vkusKorzh.nazvan[0] = "Чёрный ._. ";
            vkusKorzh.nazvan[1] = "Шоколадный";
            vkusKorzh.nazvan[2] = "Карамельный";
            vkusKorzh.nazvan[3] = "Клубничный";
            vkusKorzh.nazvan[4] = "Вкусный жи есть";
            vkusKorzh.stoim[0] = 100;
            vkusKorzh.stoim[1] = 100;
            vkusKorzh.stoim[2] = 150;
            vkusKorzh.stoim[3] = 200;
            vkusKorzh.stoim[4] = 250;

            Class1 kolvoKorzhei = new Class1();
            kolvoKorzhei.nazvan[0] = "1 корж";
            kolvoKorzhei.nazvan[1] = "2 коржа";
            kolvoKorzhei.nazvan[2] = "3 коржа";
            kolvoKorzhei.nazvan[3] = "4 коржа";
            kolvoKorzhei.nazvan[4] = "5 коржей";
            kolvoKorzhei.stoim[0] = 100;
            kolvoKorzhei.stoim[1] = 200;
            kolvoKorzhei.stoim[2] = 300;
            kolvoKorzhei.stoim[3] = 400;
            kolvoKorzhei.stoim[4] = 500;

            Class1 glazur = new Class1();
            glazur.nazvan[0] = "Шоколад";
            glazur.nazvan[1] = "Ультра шоколад";
            glazur.nazvan[2] = "Белый шоколад";
            glazur.nazvan[3] = "Чёрный ._. шоколад";
            glazur.nazvan[4] = "Клуюника";
            glazur.stoim[0] = 100;
            glazur.stoim[1] = 100;
            glazur.stoim[2] = 100;
            glazur.stoim[3] = 100;
            glazur.stoim[4] = 100;

            Class1 decor = new Class1();
            decor.nazvan[0] = "РТХ 3080";
            decor.nazvan[1] = "Я";
            decor.nazvan[2] = "Гирлянда";
            decor.nazvan[3] = "Журавль";
            decor.nazvan[4] = "Магнитофон";
            decor.stoim[0] = 10;
            decor.stoim[1] = 10;
            decor.stoim[2] = 10;
            decor.stoim[3] = 10;
            decor.stoim[4] = 10;

            Class1[] zakaz = new Class1[] { form, razmer, vkusKorzh, kolvoKorzhei, glazur, decor };
            Class1 menupart = zakaz[posin];
            return menupart;
        }
    }

}
