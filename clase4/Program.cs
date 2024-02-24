// ENUNCIADO 1
//for (int x = 2; x <= 10; x += 2)
//{
//    Console.WriteLine(x);
//}


//int suma = 0;

//for (int i = 1; i <= 10; i++)
//{
//    suma += i;
//}

//Console.WriteLine("La suma de los primeros 10 numeros naturales es: " + suma);


//ENUNCIADO 2
//int n1, suma = 0;

//do
//{
//    Console.WriteLine("Ingrese un número: (Si quiere acabar el programa ingrese un número negativo.)");
//    n1 = int.Parse(Console.ReadLine());
//    if (n1 > 0)
//    {
//        suma += n1;
//    }
//}

//while (n1 > 0);

//Console.WriteLine("La suma de los números ingresados es: " +suma);


//for (int i = 1; ; i++) 
//{
//    if (i % 7 == 0 && i % 11 == 0)
//    {
//        Console.WriteLine("El número divisible entre 7 y 11 es: " + i);
//        break;
//    }
//}


//ENUNCIADO 3
string contraseña = "jutiapa";
string ingresUser;
try
{
    do
    {
        Console.WriteLine("Ingrese la contraseña:");
        ingresUser = Console.ReadLine();

    }
    while (ingresUser != contraseña);

    Console.WriteLine("La contraseña es correcta.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error Inesperado: {ex.Message}");
}
