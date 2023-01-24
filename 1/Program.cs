//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Давайте выясним, сегодня у Вас сегодня выходной или нет? Какой сегодня день недели? (напишите номер дня): ");
int day = int.Parse(Console.ReadLine());
switch (day) 
{
    case 1: Console.WriteLine ("Понедельник"); 
    break;
    case 2: Console.WriteLine ("Вторник"); 
    break;
    case 3: Console.WriteLine ("Среда"); 
    break;
    case 4: Console.WriteLine ("Четверг"); 
    break;
    case 5: Console.WriteLine ("Пятница"); 
    break;
    case 6: Console.WriteLine ("Суббота");
    break;
    case 7: Console.WriteLine ("Воскресенье"); 
    break;
}
    if (day == 6 || day == 7) 
    {
        Console.WriteLine("Сегодня у Вас выходной, отдыхайте.");
        }
    else {
        Console.WriteLine("Сегодня у Вас рабочий день, идите на работу.");
        }