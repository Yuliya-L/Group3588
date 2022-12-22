// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// // Пример: 456 -> 3 78 -> 2 89126 -> 5

// Console.Write ("Введите число: ");

// string? NumberStr = Console.ReadLine();
// int Number = int.Parse(NumberStr??"0");

// Console.WriteLine((int)(1+Math.Log10(Number)));

int ReadData (string msg)
{
    
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");

}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int Variantlog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int number = ReadData("введите число А:");
int lengh = Variantlog(number);
PrintData("количество цифр в числе равно " + lengh);