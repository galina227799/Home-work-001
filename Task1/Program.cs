Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
int maximum = number1;
if (number1<number2){
    maximum = number2;
}
Console.WriteLine($"Максимальное из двух чисел - {maximum} ");