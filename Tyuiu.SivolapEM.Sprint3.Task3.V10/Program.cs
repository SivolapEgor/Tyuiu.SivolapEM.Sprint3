using Tyuiu.SivolapEM.Sprint3.Task3.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach удалить из строки все буквы p в                  *");
        Console.WriteLine("* строке: gdfppf vfppt p                                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string str = "gdfppf vfppt p";
        char ch = 'p';
        Console.WriteLine("* Исходная строка = " + str);
        Console.WriteLine("* Удаляемый символ = " + ch);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.DeleteCharInString(str, ch);
        Console.WriteLine(res);
    }
}