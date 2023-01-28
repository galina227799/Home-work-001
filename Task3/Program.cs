Console.Clear();
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int Ostatok = number1%2;
if (Ostatok >0){
    Console.WriteLine("Число не четное");   
}
else{
  Console.WriteLine("Число четное");  
}