Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int A1 = 2;
while(A1 <= number){
    Console.Write($"{A1}, ");  
    A1=A1+2; 
}
