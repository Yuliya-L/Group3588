int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");

int result = number2%number1;

if (result ==0)
{
    Console.WriteLine ("второе число делится на первое без остатка");

}
else
{
    Console.WriteLine ("второе число не кратно первому. остаток от деление" + result);

}

