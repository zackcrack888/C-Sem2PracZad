﻿

Console.Clear();
Console.Write("Vvedite cifru dna nedeli: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<1||n>7)
{
    Console.Write("Oshibka \nVvedite zanovo: ");
    n= Convert.ToInt32(Console.ReadLine());
}
if (n==6||n==7)
Console.WriteLine("Den' vihodnoi");
else
Console.WriteLine("Budnii dni");