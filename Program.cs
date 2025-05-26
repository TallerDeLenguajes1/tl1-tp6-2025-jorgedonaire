//CalculadoraV2
Console.WriteLine("***** Calculadora V2 ******");
Console.WriteLine();
bool ingresoValido = true;
do
{
    Console.WriteLine("Ingrese un numero: ");
    string numeroIngresado;
    numeroIngresado = Console.ReadLine();
    if (double.TryParse(numeroIngresado, out double numeroConvertido))
    {
        double valorAbsoluto = Math.Abs(numeroConvertido);
        Console.WriteLine($"El valor absoluto de {numeroConvertido} es {valorAbsoluto}");
        double numeroAlCuadrado = numeroConvertido * numeroConvertido;
        Console.WriteLine($"El cuadrado de {numeroConvertido} es {numeroAlCuadrado}");
        double raizCuadrada = Math.Sqrt(numeroConvertido);
        Console.WriteLine($"La raiz cuadrada de {numeroConvertido} es {raizCuadrada}");
        double seno = Math.Sin(numeroConvertido);
        Console.WriteLine($"El seno de {numeroConvertido} es {seno}");
        double coseno = Math.Cos(numeroConvertido);
        Console.WriteLine($"El coseno de {numeroConvertido} es {coseno}");
        double parteEntera = Math.Truncate(numeroConvertido);
        Console.WriteLine($"La parte entera de {numeroConvertido} es {parteEntera}");
        ingresoValido = true;
    }
    else
    {
        Console.WriteLine("Error. Ingrese un numero correcto");
        ingresoValido = false;
    } 
} while (!ingresoValido);

string num1Ingresado, num2Ingresado;
Console.WriteLine("Determinar maximo y minimo de 2 numeros:");
Console.WriteLine("Ingrese el 1er numero");
num1Ingresado = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("****** Calculadora Finalizada ******");