string? input;
bool validEntry = false;

Console.WriteLine("Enter the role name (Administrator, Manager, User) > ");

do
{
   input = Console.ReadLine(); 
   input = input.Trim().ToLower();

   if (input == "administrator" || input == "manager" || input == "user")
   {
       validEntry = true;
   }
   else
   {
       Console.WriteLine("Invalid name, try again > ");
   }

} while (validEntry == false);

Console.WriteLine("Valid input value");

