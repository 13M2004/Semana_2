Console.WriteLine("          TAREA SEMANA 2    ");
// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("");
Console.WriteLine(" --   CONVERSIONES DE TIPOS   --");
Console.WriteLine("");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #1");
// Pedir al usuario que ingrese un número entero
Console.WriteLine("Ingrese un número entero:");
int numeroEntero = Convert.ToInt32(Console.ReadLine());

// Convertir el número entero a decimal
decimal numeroDecimal = Convert.ToDecimal(numeroEntero);

// Mostrar el resultado
Console.WriteLine("El número decimal es: " + numeroDecimal.ToString("F2"));

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);


Console.WriteLine("EJERCICIO #2");

Console.WriteLine("Ingrese un número decimal:");
decimal numeroDecimal2 = decimal.Parse(Console.ReadLine());

// Convertir el número decimal a flotante
float numeroFlotante = (float)numeroDecimal2;

// Imprimir el resultado
Console.WriteLine("El número flotante es: " + numeroFlotante);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);


Console.WriteLine("EJERCICIO #3");

Console.WriteLine("Ingrese un número: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Imprimir el resultado
Console.WriteLine("El número entero es: " + numero);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);


Console.WriteLine("EJERCICIO #4");

char miCaracter;
Console.WriteLine("Escriba un caracter");
miCaracter = char.Parse(Console.ReadLine());

int númeroEntero = miCaracter;

Console.WriteLine("El número entero es: " + numeroEntero);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #5");

Console.WriteLine("Ingrese un número entero");
numero = int.Parse(Console.ReadLine());

char caracter = Convert.ToChar(numero);
Console.WriteLine("El carácter es: " + caracter);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("");
Console.WriteLine("--OPERACIONES CON TIPOS DE DATOS--");
Console.WriteLine("");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #1");

Console.WriteLine("Escriba un número Entero");
int primerNumero = int.Parse(Console.ReadLine());

Console.WriteLine("Escriba un Número Entero");
int segundoNumero = int.Parse(Console.ReadLine());

int suma = primerNumero + segundoNumero;

Console.WriteLine("La suma de los números es " + suma);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #2");

Console.WriteLine("Escriba un número decimal:");
double primerDecimal = double.Parse(Console.ReadLine());

Console.WriteLine("Escriba otro número decimal:");
double segundoDecimal = double.Parse(Console.ReadLine());

double resta = primerDecimal - segundoDecimal;

string resultado = resta.ToString("F2");

Console.WriteLine($"La resta de los números {primerDecimal} y {segundoDecimal} es: {resultado}");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #3");

Console.WriteLine("Ingrese un Número Flotante");
float nuevoNumero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un Número Flotante");
float nuevoNumero2 = float.Parse(Console.ReadLine());

float multiplicacion = nuevoNumero1 * nuevoNumero2;
string Multipli = multiplicacion.ToString("F2");

Console.WriteLine($"La Multiplicación de los números {nuevoNumero1} y {nuevoNumero2} es: {Multipli}");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #4");

Console.WriteLine("Ingrese un número entero:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número entero:");
int numero2 = int.Parse(Console.ReadLine());

if (numero2 == 0)
{
    Console.WriteLine("No se puede dividir entre cero.");
}

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("Ingrese un número entero:");
int dividendo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número entero:");
int divisor = int.Parse(Console.ReadLine());

int modulo = dividendo % divisor;

Console.WriteLine("El módulo es: " + modulo);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("");
Console.WriteLine(" --   USO DE CHAR Y STRING   --");
Console.WriteLine("");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #1");

Console.WriteLine("Ingrese un Texto:");
string texto = Console.ReadLine();

string textoMayusculas = texto.ToUpper();
Console.WriteLine("La cadena de Texto en Mayúsculas es: " + textoMayusculas);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #2");

Console.WriteLine("Ingrese un Texto:");
string Texto = Console.ReadLine();

string textoMinusculas = texto.ToLower();
Console.WriteLine("La cadena de Texto en minúsculas es: " + textoMinusculas);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #3");

Console.WriteLine("Ingrese un Texto:");
string inputText = Console.ReadLine();

string reversedText = "";
for (int i = inputText.Length - 1; i >= 0; i--)
{
    reversedText += inputText[i];
}

Console.WriteLine("La cadena al revés es: " + reversedText);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #4");

Console.WriteLine("Ingrese una cadena de texto:");
string texto1 = Console.ReadLine();

Console.WriteLine("Ingrese la palabra a buscar:");
string palabra = Console.ReadLine();

int indice = texto1.IndexOf(palabra);

if (indice == -1)
{
    Console.WriteLine("La palabra no se encuentra en la cadena.");
}
else

    // Espacio - Pausa
    Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #5");

Console.WriteLine("Ingrese una cadena de texto:");

int numeroVocales = 0;

foreach (char letra in texto)
{
    if ("aeiouAEIOU".Contains(letra))
    {
        numeroVocales++;
    }
}

Console.WriteLine("La cadena contiene " + numeroVocales + " vocales.");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);



Console.WriteLine("");
Console.WriteLine(" --   USO DE DATOS NÚMERICOS   --");
Console.WriteLine("");

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #1");

Console.WriteLine("Ingresa la base del Triángulo");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la Altura del Triángulo");
double h = double.Parse(Console.ReadLine());

double area = (b * h) / 2;
Console.WriteLine("El Aréa del Triangulo es:" + area);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #2");

Console.WriteLine("Ingresa el diametro de la esfera:");
double d = double.Parse(Console.ReadLine());

double r = d / 2;

double v = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

Console.WriteLine("El volumen de la esfera es: {0:F2}", v);


// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #3");

Console.WriteLine("Ingrese la coordenada X del primer punto:");
double coordenadaX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la coordenada Y del primer punto:");
double coordenadaY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la coordenada X del segundo punto:");
double coordenadaX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la coordenada Y del segundo punto:");
double coordenadaY2 = double.Parse(Console.ReadLine());

double distanciaPuntos = Math.Sqrt(Math.Pow(coordenadaX2 - coordenadaX1, 2) + Math.Pow(coordenadaY2 - coordenadaY1, 2));

Console.WriteLine("La distancia entre los dos puntos es: " + distanciaPuntos);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #4");

Console.WriteLine("Ingrese la temperatura en grados Celsius:");
double temperaturaCelsius = double.Parse(Console.ReadLine());

double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

Console.WriteLine("La temperatura en grados Fahrenheit es: " + temperaturaFahrenheit);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("EJERCICIO #5");
Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");

double temperaturaFahrenheit2 = double.Parse(Console.ReadLine());

double temperaturaCelsius2 = (temperaturaFahrenheit2 - 32) * 5 / 9;

Console.WriteLine("La temperatura en grados Celsius es: " + temperaturaCelsius2);

// Espacio - Pausa
Console.WriteLine();
Thread.Sleep(2000);


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("  --   DIVIDIDE Y VENCÉRAS   --");
Console.WriteLine("");
Console.WriteLine("");

