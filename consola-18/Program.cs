Random random = new Random();
int current = random.Next(1, 11);


// Use the continue statement to step directly to the Boolean experssion
do
{
    current = random.Next(1, 11);

    if (current >= 8 ) continue; 
    
    Console.WriteLine(current);
} while (current != 7);


// While statement that iterates only while a random number is greater
// than some value

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");
*/
