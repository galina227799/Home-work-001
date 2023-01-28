Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());
int maximum = number1;
if (number2>maximum){
    maximum = number2;
}
if(number3>maximum){
    maximum = number3; 
}
Console.WriteLine($"Максимальное из трех чисел - {maximum} ");
