int input;
bool validEntry = false;

Console.WriteLine("Enter an integer between 5 and 10 > ");

do
{
   input = Console.ReadLine(); 
   if (input >= 5 && <= 10)
   {
       validEntry = true;
   }
   else
   {
       Console.WriteLine("Invalid input, try again.");
   }


} while ( valid == false);

Console.WriteLine("Your input value is correct.");

