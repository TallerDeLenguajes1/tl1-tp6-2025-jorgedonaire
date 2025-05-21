//CalculadoraV1
Console.WriteLine("***** Calculadora V1 ******");
string repetirCalculo = "n";
do
{
    string operacionIngresada;

    Console.WriteLine("¿Que operacion desea realizar?");
    Console.WriteLine("1. SUMA");
    Console.WriteLine("2. RESTA");
    Console.WriteLine("3. MULTIPLICACIÓN");
    Console.WriteLine("4. DIVISIÓN");

    operacionIngresada = Console.ReadLine();
    //verificacion de ingreso
    if (int.TryParse(operacionIngresada, out int opcionConvertida))
    {
        switch (opcionConvertida)
        {
            case 1: //suma
                Console.WriteLine("Ingrese el primer numero a sumar: ");
                string num1Ingresado = Console.ReadLine();
                if (int.TryParse(num1Ingresado, out int num1Convertido))
                {
                    Console.WriteLine("Ingrese el segundo numero a sumar: ");
                    string num2Ingresado = Console.ReadLine();
                    if (int.TryParse(num2Ingresado, out int num2Convertido))
                    {
                        Console.WriteLine($"El resultado de {num1Convertido} + {num2Convertido} = {num1Convertido + num2Convertido}");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero");
                }
                break;
            case 2: //resta
                Console.WriteLine("Ingrese el primer numero: ");
                num1Ingresado = Console.ReadLine();
                if (int.TryParse(num1Ingresado, out num1Convertido))
                {
                    Console.WriteLine("Ingrese el segundo numero que restara: ");
                    string num2Ingresado = Console.ReadLine();
                    if (int.TryParse(num2Ingresado, out int num2Convertido))
                    {
                        Console.WriteLine($"El resultado de {num1Convertido} - {num2Convertido} = {num1Convertido - num2Convertido}");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero");
                }
                break;
            case 3: //multiplicacion
                Console.WriteLine("Ingrese el primer numero a multiplicar: ");
                num1Ingresado = Console.ReadLine();
                if (int.TryParse(num1Ingresado, out num1Convertido))
                {
                    Console.WriteLine("Ingrese el segundo numero a multiplicar: ");
                    string num2Ingresado = Console.ReadLine();
                    if (int.TryParse(num2Ingresado, out int num2Convertido))
                    {
                        Console.WriteLine($"El resultado de {num1Convertido} x {num2Convertido} = {num1Convertido * num2Convertido}");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero");
                }
                break;
            case 4: //division
                Console.WriteLine("Ingrese el primer numero (dividendo): ");
                num1Ingresado = Console.ReadLine();
                if (int.TryParse(num1Ingresado, out num1Convertido))
                {
                    Console.WriteLine("Ingrese el segundo numero (divisor): ");
                    string num2Ingresado = Console.ReadLine();
                    if (int.TryParse(num2Ingresado, out int num2Convertido))
                    {
                        Console.WriteLine($"El resultado de {num1Convertido} / {num2Convertido} = {num1Convertido / num2Convertido}");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero");
                }
                break;
            default:
                Console.WriteLine("Ingrese una operacion correcta");
                break;
        }
    }
    else
    {
        Console.WriteLine("Error. Debe ingresar un numero");
    }
    Console.WriteLine(" ");
    Console.WriteLine("¿Desea realizar otro calculo?");
    Console.WriteLine("Presione la letra que desee (s/n)");
    Console.WriteLine("s - Realizar otro calculo");
    Console.WriteLine("n - Cerrar programa");
    repetirCalculo = Console.ReadLine();
} while (repetirCalculo == "s");
Console.WriteLine();
Console.WriteLine("****** Calculadora Finalizada ******");