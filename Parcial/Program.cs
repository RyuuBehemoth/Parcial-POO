/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

using System.Drawing;
using System.Runtime.InteropServices;

bool menu()
{
    int o;
    bool rep;
    Console.WriteLine("\n\tParcial:\n1.Sumatoria\n2.Sumatoria Impares\n3.Zodiaco\n4.Numeros primos y sumatoria\n5.Clase libro\n6.Biblioteca\n7.Elementos principales de POO\n8.Salir\n");
    o = Convert.ToInt32(Console.ReadLine());
    if (o == 8)
    {
        rep = false;
    }
    else
    {
        rep = true;
        option(o);
    }
    return rep;
}

void option(int a)
{
    switch (a)
    {
        case 1:
            int n, sum;
            Console.WriteLine("Ingrese el numero n hasta el que quiere sumar:\t");
            n = Convert.ToInt32(Console.ReadLine());
            sum = op1(n);
            Console.WriteLine($"El resultado es:\t{sum}");
            break;
        case 2:
            int num, isum;
            Console.WriteLine("Ingrese el numero n hasta el que quiere sumar los impares:\t");
            num = Convert.ToInt32(Console.ReadLine());
            isum = op2(num);
            Console.WriteLine($"El resultado es:\t{isum}");
            break;
        case 3:
            int month, day;
            Console.WriteLine("Ingrese su dia de nacimiento:\t");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su mes de nacimiento:\t");
            month = Convert.ToInt32(Console.ReadLine());
            op3(month, day);
            break;
        case 4:
            op4();
            break;
        case 5:
            Console.WriteLine("Libro\n-----------------\nstring color;\nint codigo;\nstring titulo;\nstring autor;\nstring tipo de libro;\nbool disponibilidad;\nbool prestado;\nstring editorial;");
            Console.WriteLine("-----------------\ndisponibilidad();\nprestado();\ncodigo();");
            break;
        case 6:
            op6();
            break;
        case 7:
            Console.WriteLine("Los principales elementos de la POO son:\n- Clases\n- Atributos\n- Metodos o funciones\n- Herencia\n-Encapsulamiento\n- Abstraccion\n");
            break;
        default:
            Console.WriteLine("Ingresa una opcion valida\n");
            break;
    }
}

int op1(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

int op2(int a)
{
    int isum = 0;
    for (int i = 0; i <= a; i++)
    {
        if ((i % 2) != 0)
        {
            isum += i;
        }
    }
    return isum;
}

void op3(int a, int b)
{
    switch (a)
    {
        case 1:
            if (b >= 20)
            {
                Console.WriteLine("Su signo zodiacal es Acuario");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Capricornio");
            }
            break;
        case 2:
            if (b >= 19)
            {
                Console.WriteLine("Su signo zodiacal es Piscis");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Acuario");
            }
            break;
        case 3:
            if (b >= 21)
            {
                Console.WriteLine("Su signo zodiacal es Aries");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Piscis");
            }
            break;
        case 4:
            if (b >= 20)
            {
                Console.WriteLine("Su signo zodiacal es Tauro");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Aries");
            }
            break;
        case 5:
            if (b >= 21)
            {
                Console.WriteLine("Su signo zodiacal es Geminis");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Tauro");
            }
            break;
        case 6:
            if (b >= 21)
            {
                Console.WriteLine("Su signo zodiacal es Cancer");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Geminis");
            }
            break;
        case 7:
            if (b >= 23)
            {
                Console.WriteLine("Su signo zodiacal es Leo");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Cancer");
            }
            break;
        case 8:
            if (b >= 23)
            {
                Console.WriteLine("Su signo zodiacal es Virgo");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Leo");
            }
            break;
        case 9:
            if (b >= 23)
            {
                Console.WriteLine("Su signo zodiacal es Libra");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Virgo");
            }
            break;
        case 10:
            if (b >= 23)
            {
                Console.WriteLine("Su signo zodiacal es Escorpio");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Libra");
            }
            break;
        case 11:
            if (b >= 22)
            {
                Console.WriteLine("Su signo zodiacal es Sagitario");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Libra");
            }
            break;
        case 12:
            if (b >= 22)
            {
                Console.WriteLine("Su signo zodiacal es Capricornio");
            }
            else
            {
                Console.WriteLine("Su signo zodiacal es Sagitario");
            }
            break;
        default:
            Console.WriteLine();
            break;
    }
}

void op4()
{
    int prim = 0;
    int sump = 0;
    Console.WriteLine("Sumatoria numeros primos:\n");
    for (int np = 1; np <= 100; np++)
    {
        for (int j = 1; j <= np; j++)
        {
            if (np % j == 0)
            {
                prim++;
            }
        }
        if (prim == 2)
        {
            sump += np;
        }
        prim = 0;
    }
    Console.WriteLine($"{sump}\n");
}

void op6()
{
    Libro libro1 = new Libro();
    libro1.color = "azul";
    libro1.codigo = 1;
    libro1.titulo = "Ciencias Naturales 1°";
    libro1.autor = "Profe Javier";
    libro1.tipo_de_libro = "Ciencia";
    libro1.disponibilidad = true;
    libro1.prestado = false;
    libro1.editorial = "Colegio A";

    Libro libro2 = new Libro();
    libro2.color = "rojo";
    libro2.codigo = 2;
    libro2.titulo = "Matematicas 1°";
    libro2.autor = "Profe Manolo";
    libro2.tipo_de_libro = "Matematica";
    libro2.disponibilidad = true;
    libro2.prestado = false;
    libro2.editorial = "Colegio B";

    Libro libro3 = new Libro();
    libro3.color = "amarillo";
    libro3.codigo = 3;
    libro3.titulo = "Lengua 1°";
    libro3.autor = "Profe Susana";
    libro3.tipo_de_libro = "Gramatica";
    libro3.disponibilidad = false;
    libro3.prestado = true;
    libro3.editorial = "Colegio C";

    Libro[] biblioteca = new Libro[]{libro1,libro2,libro3};

    Console.WriteLine("\tBiblioteca:");

    for (int i = 0; i < biblioteca.Length; i++)
    {
        Console.WriteLine($"Tipo de Libro: {biblioteca[i].tipo_de_libro}");
        Console.WriteLine($"Titulo: {biblioteca[i].titulo}");
        Console.WriteLine($"Autor: { biblioteca[i].autor}");
        Console.WriteLine($"Disponibilidad: {biblioteca[i].disponibilidad}\n");
    }
}

bool repeat = true;
do
{
    repeat = menu();
} while (repeat);

public class Libro
{
    public string color;
    public int codigo;
    public string titulo;
    public string autor;
    public string tipo_de_libro;
    public bool disponibilidad;
    public bool prestado;
    public string editorial;
}