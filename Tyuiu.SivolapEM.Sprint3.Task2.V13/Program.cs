using Tyuiu.SivolapEM.Sprint3.Task2.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Сиволап Е. М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
        Console.WriteLine("* ряда по формуле, при t=0,7                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double t = 0.7;
        int start = 1;
        int stop = 10;
        Console.WriteLine("* Переменная T = " + t);
        Console.WriteLine("* Старт шага = " + start);
        Console.WriteLine("* Конец шага = " + stop);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.GetSumSeries(t, start, stop);
        Console.WriteLine(res);
    }
}