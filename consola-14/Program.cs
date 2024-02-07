// Creating a variable inside a code block
bool flag = true;
if (flag)
{
  //int value = 10;
  //Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine("==============");
// Attempt to access a variable outside the code block in which it's declared

//Console.WriteLine($"Outside the code block: {value}");

Console.WriteLine("==============");
// Move the variable declaration above the code block
int value = 0;
if (flag)
{
  Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");


