
string[] arr = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string elm in arr)
{
  if (elm.StartsWith("B"))
  {
    Console.WriteLine(elm);
  }
}
