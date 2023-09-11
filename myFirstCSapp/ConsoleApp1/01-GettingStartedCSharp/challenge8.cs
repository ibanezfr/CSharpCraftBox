/* Adding two numeric values */
// int numeroUno = 23;
// int numeroDos = 50;
// Console.WriteLine(numeroDos + numeroUno);


/* Mixing data types to force implicit type conversions */
// string pais = "Argentina";
// int provincias = 24;
// Console.WriteLine("La " + pais + " tiene " + provincias + " provincias.");


/* Writing code to perform addition, subtraction, multiplication, and division
with integers */
// int suma = 7 + 5;
// int diferencia = 7 - 5;
// int producto = 7 * 5;
// int cociente = 7 / 5;

// Console.WriteLine("Suma: "  + suma);
// Console.WriteLine("Diferencia: "  + diferencia);
// Console.WriteLine("Producto: "  + producto);
// Console.WriteLine("Cociente: "  + cociente);

/* Performing division using literal decimal data */
// decimal cocienteDecimal = 7.0m / 5;
// Console.WriteLine($"Cociente decimal: {cocienteDecimal}");

/* these also work */
// decimal cocienteDecimal1 = 7 / 5.0m;
// decimal cocienteDecimal2 = 7.0m / 5.0m;

/* but these doesn't or give innacurate results*/
// int cocienteDecimal3 = 7 / 5.0m;
// int cocienteDecimal4 = 7.0m / 5;
// int cocienteDecimal5 = 7.0m / 5.0m;
// decimal cocienteDecimal6 = 7 / 5;

/* Performing division using literal decimal data

What if you are not working with literal values? In other words, what if you
need to divide two variables of type int but do not want the result truncated?
In that case, you must perform a data type cast from int to decimal. Casting is
one type of data conversion that instructs the compiler to temporarily treat a
value as if it were a different data type. */

// int primero = 7;
// int segundo = 5;
// decimal cociente = (decimal)primero / (decimal)segundo;
// Console.WriteLine(cociente);


/* Determining the remainder after integer division */
// Console.WriteLine($"El módulo de 200 / 5 : {200 % 5}");
// Console.WriteLine($"El módulo de 7 / 5 : {7 % 5}");

/* Order of operations

 In math, PEMDAS is an acronym that helps students remember the order of
operations. The order is:

    1- Parentheses (whatever is inside the parenthesis is performed first)
    2- Exponents
    3- Multiplication and Division (from left to right)
    4- Addition and Subtraction (from left to right)

C# follows the same order as PEMDAS except for exponents. While there's no
exponent operator in C#, you can use the System.Math.Pow method. */

// int valor1 = 3 + 4 * 5; // 23
// int valor2 = (3 + 4) * 5; // 35
// Console.WriteLine(valor1);
// Console.WriteLine(valor2);

/* Recap

Here's what you've learned so far about mathematical operations in C#:

- Use operators like +, -, *, and / to perform basic mathematical operations.
- The division of two int values will result in the truncation of any values
     after the decimal point. To retain values after the decimal point, you need
     to cast the divisor or dividend (or both) from int into a floating point
     number like decimal first, then the quotient must be of the same floating
     point type as well in order to avoid truncation.
- Perform a cast operation to temporarily treat a value as if it were a
     different data type.
- Use the % operator to capture the remainder after division. -The order of
     operations will follow the rules of the acronym PEMDAS.
 */