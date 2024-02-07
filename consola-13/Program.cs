﻿// Conditional operator

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");


// Using the conditional operator inline

Console.WriteLine("==========");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
