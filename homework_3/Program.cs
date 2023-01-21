// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число N: ");
double number = Convert.ToInt32(Console.ReadLine());
double result = 0;

if(number >0){
    for(int i = 1; i<=number; i++){
        result = Math.Pow(i, 3);
        System.Console.WriteLine(result);
    }
}
else{
    System.Console.WriteLine("Вы ввели не корректное число!");
}