using Tyuiu.SivolapEM.Sprint3.Task0.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Сиволап Е.М | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Сиволап Егор Сиволап | ИИПб-25-1                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
        Console.WriteLine("* ряда по формуле, при a=0,5                                             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int Start = 1;
        int End = 15;
        double a = 0.5;
        Console.WriteLine("* Переменная А = " + a);
        Console.WriteLine("* Старт шага = " + Start);
        Console.WriteLine("* Конец шага = " + End);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.GetSumSeries(a, Start, End);
        Console.WriteLine(res);
    }
}