/*
int SredneeChislo()      //задача 10
{
    int Rand1 = new Random().Next(100,999);
    Console.WriteLine("Ввыведенное число " + Rand1);
    int DesEd = Rand1 % 100;
    int Des = DesEd / 10;
    Console.WriteLine("Середина числа " + Des);
    return Des;
}

SredneeChislo();
*/

/*
void ThirdNumber()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());                 //Задача 13
    string num1 = Convert.ToString(num);    
        if (num1.Length >= 3) 
            { 
                Console.WriteLine("Третья цифра: " + num1[2]);
            }
        else Console.WriteLine("Нет третьей цифры");
}
ThirdNumber();
*/


/*
void weekend()
{
    Console.WriteLine("Введите цифру соответствующую дню недели");       //Задача 15
    int num = Convert.ToInt32(Console.ReadLine());
    if (num <= 7) 
    {
        if (num == 6) Console.WriteLine("Сегодня выходной, отдыхаем");
            else
                {
                    if (num == 7) Console.WriteLine("Сегодня выходной, отдыхаем");
                        else  
                            Console.WriteLine("Сегодня не выходной, иди работай");
                }
    }
    else Console.WriteLine("Нет такого дня недели");
}
weekend();
*/

