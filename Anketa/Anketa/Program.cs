using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас величать?");
            var name = Console.ReadLine();
            Console.WriteLine("Сколько вам годиков?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Когда вы соизволили появиться на свет?");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Какой сегодня по счету день недели?");
            DayOfWeek today = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Здравия желаю, {0}! \n Сегодня {1}, погода хорошая, а вам всего {2} лет, ведь вы родились {3} \n Вся жизнь впереди, и это прекрасно!", name, today, age, birthdate);
        }
    }
}