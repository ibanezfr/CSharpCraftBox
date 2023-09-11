/* String concatetenation */

// string nombre = "Franco";
// string mensaje = "Hola " + nombre;
// Console.WriteLine(mensaje);

// string saludo = "Hola";

// string mensaje = saludo + " " + nombre + "!";

// Console.WriteLine(saludo + " " + nombre + "!");

/* String interpolation */
// string nombre = "Napoleón";
// string saludo = "Hola";

// Console.WriteLine($"{saludo} {nombre}!");

// int version = 12;
// string textoActuali = "Actualiza a Debian";
// Console.WriteLine($"{textoActuali} {version}!");


/* In this example, the $ symbol allows you to reference the projectName
variable inside the brackets, while the @ symbol allows you to use the unescaped
\ character. */

// string nombreProyecto = "Primer-proyecto";
// Console.WriteLine($@"c:\Output\{nombreProyecto}\Data");

/* string nombreDelProy = "ACME";

string mensajeEnRuso = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435" +
                       "\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438" + 
                       "\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\Exercise\{nombreDelProy}\data.txt");
Console.WriteLine($@"{mensajeEnRuso}:
    c:\Exercise\{nombreDelProy}\ru-RU\data.txt"); */