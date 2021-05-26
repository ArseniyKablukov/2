using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nВыберите номер задания (1-3)");
                int g = Convert.ToInt32(Console.ReadLine());

                switch (g)
                {
                    case 1:
                        Console.WriteLine("Дана строка. Найдите в этой строке второе вхождение буквы f, и выведите индекс этого вхождения. Если буква f в данной строке встречается только один раз, выведите число -1, а если не встречается ни разу, выведите число -2.\n");
                        string str = Convert.ToString(Console.ReadLine());
                        int a = 2;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i] == 'f')
                            {
                                if (a == 1)
                                {
                                    a = i;
                                    break;
                                }
                                a = 1;
                            }
                        }
                        Console.WriteLine(a);
                        break;


                    case 2:
                        Console.WriteLine("Реализовать функцию заменающую русские буквы на латинские транслитом.\nПример: ваза->vaza ; яма->yama\n");
                        string str1 = Convert.ToString(Console.ReadLine());
                        string trans = "";
                        string[] ru = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", };
                        string[] en = { "a", "b", "v", "g", "d", "ie", "io", "j", "z", "e", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "c", "ch", "sh", "shch", null, "ye", null, "ae", "u", "yui", };
                        for (int i = 0; i < str1.Length; i++)
                        {
                            for (int j = 0; j < ru.Length; j++)
                            {
                                if (str1[i].Equals(Convert.ToChar(ru[j])))
                                {
                                    trans += en[j];
                                }
                            }
                        }
                        Console.WriteLine(trans);
                        break;


                    case 3:
                        Console.WriteLine("Дана строка. Замение в этой строке все появления буквы h на букву H, кроме первого и последнего вхождения\n");
                        string str2 = Convert.ToString(Console.ReadLine());
                        string str3 = "";
                        for (int i = 0; i < str2.Length; i++)
                        {
                            if ((str2[i].Equals('h')) && (i != str2.IndexOf('h')) && (i != str2.LastIndexOf('h')))
                            {
                                str3 += "H";
                            }
                            else
                            {
                                str3 += str2[i];
                            }
                        }
                        Console.WriteLine(str3);
                        break;
                }
            }
        }
    }
}
