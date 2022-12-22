//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y). 

//ВВодим данные




int quter = ReadData("ВВедите номер четверти");
PrintAnswer(quter);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод определяет четверть по координатам
void PrintAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("X > 0, Y > 0");
        if (num == 2) Console.WriteLine("X > 0, Y < 0");
        if (num == 3) Console.WriteLine("X  < 0, Y > 0");
        if (num == 4) Console.WriteLine("X < 0, Y > 0");
    }
    else Console.WriteLine("вы ввели не номер четверти");

}


