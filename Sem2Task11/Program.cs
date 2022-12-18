// System.Random numberSintezator = new System.Random(); //создаем экземпляр рандомайзера

// int num = numberSintezator.Next(100, 1000);  //получаем случайное число. у оператора Next  -1 всегда поэтому здесь 1000, а не 999
// Console.WriteLine(num);

// int firstNum = num / 100; //получаем старший разряд числа
// int secondNum = num % 10; //получаем младший разряд числа

// int result = firstNum * 10 + secondNum;
// Console.WriteLine(result);

//вариант 2


System.Random numberSintezator = new System.Random(); //создаем экземпляр рандомайзера

int num = numberSintezator.Next(100, 1000);  //получаем случайное число. у оператора Next  -1 всегда поэтому здесь 1000, а не 999
Console.WriteLine(num);


int result = (num/100) * 10 + num%10;
Console.WriteLine(result);
