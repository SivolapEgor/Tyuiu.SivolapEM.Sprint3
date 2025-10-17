using Tyuiu.SivolapEM.Sprint3.Task7.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции.           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("* Начало отрезка = " + startValue);
        Console.WriteLine("* Конец отрезка = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double[] functionValues = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    x     |   F(x)   |");
        Console.WriteLine("+----------+----------+");

        int currentIndex = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            double y = functionValues[currentIndex];
            Console.WriteLine("| {0, 8:d} | {1, 8:f2} |", x, y);
            currentIndex++;
        }
        Console.WriteLine("+----------+----------+");
    }
}