// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве. Например: 
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 

int X1 = ReadData ("Ведите координату X1: ");
int Y1 = ReadData ("Ведите координату Y1: ");
int X2 = ReadData ("Ведите координату X2: ");
int Y2 = ReadData ("Ведите координату Y2: ");
//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double CalculateLength(int X1,int Y1,int X2,int Y2)
{
    double res = 0;
    res = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2));
    return res;
}
//Метод выводит данные пользователя
void PrintData(string message, double res)

{
    Console.WriteLine(message+res);
}

PrintData ("Расстояние между точками: ", CalculateLength(X1,Y1,X2, Y2));


