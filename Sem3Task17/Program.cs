// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
// Например: 
// x=34; y=-30 -> 4 x=2; y=4-> 1 x=-34; y=-30 -> 3 


//ВВодим данные

// Console.WriteLine("ВВедите кординату X");
// int coordX = int.Parse (Console.ReadLine()??"0");

// Console.WriteLine("ВВедите кординату Y");
// int coordY = int.Parse (Console.ReadLine()??"0");


int coordX = ReadData("ВВедите кординату X");
int coordY = ReadData("ВВедите кординату Y");

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод определяет четверть по координатам
void PrintQuterTest()
{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}



PrintQuterTest();