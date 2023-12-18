using System;

class Program 
{
  static void Main()
  {

    Random random = new Random();
    int daysUntilExpiration = random.Next(12);
    int discountPercentage = 0;

    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine(discountPercentage);
  }
}

