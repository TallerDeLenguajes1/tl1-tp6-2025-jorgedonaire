//CalculadoraV2
Console.WriteLine("***** Calculadora V2 ******");
Console.WriteLine();
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
}
else
{
    Console.WriteLine("Error. Ingrese un numero");
}

Console.WriteLine();
Console.WriteLine("****** Calculadora Finalizada ******");