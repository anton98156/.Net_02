/* Работа на семинаре:

int number = new Random().Next (100,1000);

Console.WriteLine(number);
int num1 = number/100;
int num2 = number%10;

Console.WriteLine($"{num1}{num2}");*/

/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.*/

/*Console.WriteLine("Введите первое число");
int num1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse (Console.ReadLine()!);

if(num1%num2==0){
    Console.WriteLine("Второе число является кратным первому");
}

else{
    Console.WriteLine(num1%num2);
}*/

/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14  ->  нет
46  ->  нет
161 ->  да*/

/*
Console.WriteLine("Введите число");
int num1 = int.Parse (Console.ReadLine()!);

if((num1%7==0)&&(num1%23==0)){
    Console.WriteLine("Числое кратное одновременно 7 и 23");
}
else{
    Console.WriteLine("Условие невыполнено");
}*/

/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.*/

/*
Console.WriteLine("Введите первое число");
int num1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse (Console.ReadLine()!);

if(num1*num1==num2){
    Console.WriteLine("Второе число является квадратом первого");
}
else if(num2*num2==num1){
    Console.WriteLine("Первое число является квадратом второго");
}
else{
     Console.WriteLine("Одно число не является квадратом другого");
} */




// Home work
/*
Console.WriteLine("Введите трехзначное число");
int number = int.Parse (Console.ReadLine()!);

if(number >= 100 && number <= 999){
    int num1 = number/10;
    int num2 = num1%10;
    Console.WriteLine(num2);
}
else{
    Console.WriteLine("Число не является трехзначным");
} */

/*
Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine()!);

if(number >= 100 && number <= 999){
    int num1 = number%10;
    Console.WriteLine(num1);
}

else if(number >= 1000 && number <= 9999){
    int num1 = number%100;
    int num2 = num1/10;
    Console.WriteLine(num2);
}

else if(number >= 10000 && number <= 99999){
    int num1 = number%1000;
    int num2 = num1/100;
    Console.WriteLine(num2);
}

else if(number >= 1 && number <= 99){
    Console.Write("Третьей цифры нет");
} */

Console.WriteLine("Введите день недели");
int number = int.Parse (Console.ReadLine()!);

if(number <= 5){
    Console.WriteLine("Нет");
}

else if(number > 5 && number <= 7){
    Console.WriteLine("Да");
}

else if(number >= 8){
    Console.WriteLine("Не является днем недели");
}
