using System; 
 
class Program 
{ 
    enum DayOfWeek 
    { 
        Monday, 
        Tuesday, 
        Wednesday, 
        Thursday, 
        Friday, 
        Saturday, 
        Sunday 
    } 
 
    enum TimeOfDay 
    { 
        Утро, 
        День, 
        Вечер, 
        Ночь 
    } 
    static void Main() 
    { 
        Console.WriteLine("Введите день недели (0 - Понедельник,6 - Воскресенье):"); 
        if (! int.TryParse(Console.ReadLine(), out int dayInput)  dayInput < 0  dayInput >6 ) 
        { 
            Console.WriteLine("Неправильный введённый день"); 
            return; 
        }  
        Console.WriteLine("Ввекдите время (0-23)"); 
        if (!int.TryParse(Console.ReadLine(), out int time)  time <0  time>23 ){ 
            Console.WriteLine("Неправильнное введённое время. Попробуйте попытку заново"); 
            return; 
 
        } 
        DayOfWeek currentDay = (DayOfWeek)dayInput; 
        TimeOfDay currentTOD; 
 
        if (time >= 7 && time <= 12) 
        { 
            currentTOD = TimeOfDay.Утро; 
        } 
        else if (time >= 13 && time <= 16) 
        { 
            currentTOD = TimeOfDay.День; 
        } 
        else if (time >= 17 && time<=19) 
        { 
            currentTOD = TimeOfDay.Вечер; 
        } 
        else  
        { 
           currentTOD = TimeOfDay.Ночь; 
        } 
        Console.WriteLine("Неправильно введённое время"); 
        Console.WriteLine("Сейчас {0}, {1}", currentDay, currentTOD); 
 
 
    } 
}
