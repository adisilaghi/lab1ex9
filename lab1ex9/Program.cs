/*Scrieti un program care interschimba valoarea a doua variabile intregi.*/

Console.WriteLine("Introduceti Value1");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti Value2");
int y = Convert.ToInt32(Console.ReadLine());
int Valx = x;

x = y;
y = Valx;
Console.WriteLine(x + " " + y);
