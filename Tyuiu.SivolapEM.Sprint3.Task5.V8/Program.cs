using Tyuiu.SivolapEM.Sprint3.Task5.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Сиволап Е. М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда по формуле        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int i_start = 1;
        int i_stop = 3;
        int k_start = 1;
        int k_stop = 12;
        Console.WriteLine("* Старт суммы первого ряда = " + i_start);
        Console.WriteLine("* Старт суммы второго ряда = " + k_start);
        Console.WriteLine("* Конец суммы первого ряда = " + i_stop);
        Console.WriteLine("* Конец суммы второго ряда = " + k_stop);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.GetSumSumSeries(i_start, k_start, i_stop, k_stop);
        Console.WriteLine("* Сумма сумм ряда = " + res);
    }
}