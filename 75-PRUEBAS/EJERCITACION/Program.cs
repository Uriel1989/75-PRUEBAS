using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EJERCITACION
{
    class Program
    {
        static void Main(string[] args)
        {
            //MOSTRAR LOS NUMEROS IMPARES DESDE 0 HASTA 100:
            int a = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    a = a + 1;
                    Console.WriteLine("Los impares entre 0 y 100 son:" + i);
                }
            }

            Console.WriteLine("Los impares desde 0 hasta 100 son: " + a);
            Console.ReadKey();

            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            //MOSTRAR LOS NUMEROS PARES DESDE 0 HASTA 100:

            //int a = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        a = a + 1;
            //        console.writeline("los pares entre 0 y 100 son:" + i);
            //    }
            //}

            //console.writeline("los pares desde 0 hasta 100 son: " + a);
            //console.readkey();

            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            //MOSTRAR LOS NUMEROS DESDE 200 HASTA 350:

            //for (int i = 200; i <= 350; i++)
            //{
            //    Console.WriteLine("Los numeros de la serie son:" + i);

            //}

            //Console.ReadKey();

            //MOSTRAR LOS NUMEROS DESDE 100 HASTA 0 EN ORDEN DECRECIENTE:

            //for (int i=100; i>=0; i--)
            //{
            //    Console.WriteLine("Los numeros de la serie son:" + i);
            //}

            //Console.ReadKey();

            //MOSTRAR Y SUMAR LOS NUMEROS QUE SEAN MULTIPLOS DE 3:

            //int a = 0;
            //int i;

            //for ( i=0; i<=100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Los multiplos de 3 son:" + i);
            //        a = a + i;
            //    }
            //}

            //Console.WriteLine("La suma de todos los multiplos de 3 es:" + a);

            //Console.ReadKey();

            //MOSTRAR LOS MULTIPLOS 2 Y 3 DENTRO DE LA SERIE DE 0 A 100:

            //for (int i=0; i<=100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Los multiplos de 2 son:" + i);
            //    }
            //}

            //for (int i=0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Los multiplos de 3 son:" + i);
            //    }
            //}

            //Console.ReadKey();

            //HACER UN ARRAY DE 5 POSICIONES QUE MUESTRE PARES, IMPARES, EN QUE POSICION ESTAN Y CUANTOS SON PARES E IMPARES:

            //int b = 0;
            //int c = 0;
            //Console.WriteLine("Ingrese la cantidad de numeros:");
            //int cantidadDeNumeros = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[cantidadDeNumeros];

            //a[0] = 10;
            //a[1] = 15;
            //a[2] = 20;
            //a[3] = 7;
            //a[4] = 2;

            //for (int i=0; i < cantidadDeNumeros; i++)
            //{
            //if (a[i] % 2 == 0)
            //{
            //    Console.WriteLine("En la posicion: " + i + " el valor par es: " + a[i]);
            //    b = b + 1;
            //}
            //if (a[i] % 2 != 0)
            //{
            //Console.WriteLine("En la posicion: " + i + " el valor impar es: " + a[i]);
            //    c = c + 1;

            //}
            //}

            ////Console.WriteLine("La cantidad de pares es: " + b);
            ////Console.WriteLine("La cantidad de impares es: " + c);
            /*Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Ingrese 2 numeros para realizar las operaciones basicas:");

            decimal num1 = Convert.ToInt32(Console.ReadLine());

            decimal num2 = Convert.ToInt32(Console.ReadLine());

            decimal suma = num1 + num2;

            decimal resta = num1 - num2;

            decimal multiplicacion = num1 * num2;

            decimal division = num1 / num2;

            Console.WriteLine("Los resultados son:");

            Console.WriteLine("Suma:" + suma);

            Console.WriteLine("Resta:" + resta);

            Console.WriteLine("Multiplicacion:" + multiplicacion);

            Console.WriteLine("Division:" + division);

            Console.WriteLine("Desea continuar?, ingrese 's', para cerrar ingrese 'n':");

            string acceso = Convert.ToString(Console.ReadLine());

            while (acceso == "s")
            {
                Console.WriteLine("Ahora ingrese los numeros:");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = Convert.ToInt32(Console.ReadLine());

                suma = num1 + num2;

                resta = num1 - num2;

                multiplicacion = num1 * num2;

                division = num1 / num2;

                Console.WriteLine("Los resultados son:");

                Console.WriteLine("Suma:" + suma);

                Console.WriteLine("Resta:" + resta);

                Console.WriteLine("Multiplicacion:" + multiplicacion);

                Console.WriteLine("Division:" + division);

                Console.WriteLine("Desea continuar?");

                acceso = Console.ReadLine();

            }*/

            /*Console.CursorLeft = 35;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Ingrese la cantidad de palabras a calcular:");

            int palabra = Convert.ToInt32(Console.ReadLine());

            List<string> CONTADOR = new List<string>();

            int CONTEO = 0;

            Console.WriteLine("Ingrese las palabras:");

            for ( int i= 0; i< palabra; i++)
            {
                string IngresoDatos = Console.ReadLine();

                CONTADOR.Add(IngresoDatos);
            }

            for (int i=0; i < CONTADOR.Count; i++)
            {
                CONTADOR[i].Count();
                CONTEO += CONTADOR[i].Length;
            }

            Console.WriteLine("Las palabras ingesadas son:" + CONTADOR.Count);
            Console.WriteLine("El numero de caracteres utilizados es de:" + CONTEO);

            */

            //Console.WriteLine("Ingrese numeros:");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int e = Convert.ToInt32(Console.ReadLine());
            //int f = Convert.ToInt32(Console.ReadLine());
            //int g = Convert.ToInt32(Console.ReadLine());
            //int h = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();

            //int[] contenedor = { a, b, c, d, e, f, g, h };


            //for (int posicion = 0; posicion < contenedor.Length; posicion++)
            //{
            //    Console.WriteLine("Posicion " + (posicion + 1) + ": " + contenedor[posicion]);
            //}

            //SALUDO:

            //Console.CursorLeft = 30;

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Ingrese su nombre:");

            //string nombre = Convert.ToString(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Hola" + " " + nombre);

            // CALCULO DE AREA Y PERIMETRO DE CIRCULO

            //Console.CursorLeft = 30;

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Vamos a calcular perimetro y area de un circulo:");

            //Console.WriteLine("Ingrese el radio:");

            //double radio = Convert.ToDouble(Console.ReadLine());

            //double perimetro = radio * 2*3.14;

            //double area = radio * radio * 3.14;

            //Console.WriteLine("Perimetro:" + perimetro + ". " + "Area:" +" " +  area);

            // CALCULO DE  PROMEDIO DE 4 NOTAS
            //Console.CursorLeft = 30;

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Vamos a calcular el promedio de 4 notas:");

            //int primero = Convert.ToInt32(Console.ReadLine());
            //int segundo = Convert.ToInt32(Console.ReadLine());
            //int tercero = Convert.ToInt32(Console.ReadLine());
            //int cuarto = Convert.ToInt32(Console.ReadLine());

            //int promedio = (primero + segundo + tercero + cuarto) / 4;

            //Console.WriteLine("Promedio:" + promedio);

            //CONVERSION DE CENTIMETRO A PULGADA

            //Console.CursorLeft = 30;

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Ingrese la medida de centimetros para pasarla a pulgadas:");

            //double centimetro = Convert.ToDouble(Console.ReadLine());

            //double pulgada = centimetro * 2.54;

            //Console.Clear();

            //Console.WriteLine("Centimetros ingreados:" + centimetro);

            //Console.WriteLine("Pasaje a pulgadas:" + pulgada);

            //INVERSION DE NUMEROS


            //Console.CursorLeft = 30;

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Vamos a invertir un numero de 3 digitos");

            //char[] NumIng = Console.ReadLine().ToCharArray();

            //Array.Reverse(NumIng);

            //string inversion = new string(NumIng);

            //Console.WriteLine("El numero invertido es:" + inversion);

            //FORMULA DE PITAGORAS

            //Console.CursorLeft = 30;

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Formula de Pitagoras");

            //double A, B = 0;

            //double hipotenusa = 0;

            //Console.WriteLine("Ingrese los catetos a y b:");

            // A = double.Parse(Console.ReadLine());

            // B = double.Parse(Console.ReadLine());

            //hipotenusa = Math.Sqrt((A * A) + (B * B));

            //Console.WriteLine("La hipotenusa es:" + hipotenusa);

            /*01.- Todos los lunes, miércoles y viernes, una persona corre la misma ruta y cronometra los tiempos obtenidos. 
             * Determinar el tiempo promedio que la persona tarda en recorrer la ruta en una semana cualquiera.*/
            //decimal Lunes, Miercoles, Viernes;

            //Console.WriteLine("Ingrese los tiempos realizados para cada dia en minutos.");

            //Console.WriteLine("Ingrese el tiempo realizado el lunes:");
            //Lunes = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese el tiempo realizado el miercoles:");
            //Miercoles = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese el tiempo realizado el viernes:");
            //Viernes = Convert.ToInt32(Console.ReadLine());

            //decimal Promedio = (Lunes + Miercoles + Viernes) / 3;

            //Console.WriteLine("El tiempo promedio es de: " + Promedio);

            //Console.ReadKey();

            /*02.- Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas. 
             * El vendedor desea saber cuanto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes 
             * y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.*/


            //double sBase, venta1, venta2, venta3, comision1, comision2, comision3, tComisiones, tSueldo;
            //string nomVendedor;

            //Console.Write(" Ingrese el nombre del vendedor : ");
            //nomVendedor = Console.ReadLine();

            //Console.Write("\n Ingrese el sueldo base : ");
            //sBase = Double.Parse(Console.ReadLine());

            //Console.Write("\n Ingrese valor de primera venta : ");
            //venta1 = Double.Parse(Console.ReadLine());
            //comision1 = venta1 * 0.10;

            //Console.Write("\n Ingrese valor de segunda venta : ");
            //venta2 = Double.Parse(Console.ReadLine());
            //comision2 = venta2 * 0.10;

            //Console.Write("\n Ingrese valor de tercera venta : ");
            //venta3 = Double.Parse(Console.ReadLine());
            //comision3 = venta3 * 0.10;

            //tComisiones = comision1 + comision2 + comision3;
            //tSueldo = sBase + tComisiones;

            //Console.WriteLine("\n El total de comisiones es de:"+ tComisiones);
            //Console.WriteLine(" El sueldo base mas las comisiones es de:" + tSueldo);

            //Console.ReadKey();

            /*03.- Una tienda ofrece un descuento del 15% sobre el total de la compra y 
             * un cliente desea saber cuanto deberá pagar finalmente por su compra.*/

            //double ValorIncial;
            //double ValorTotal = 0;
            //double promocion = 0;
            //double descuento = 0.15;

            //Console.WriteLine("Ingrese el valor del conjunto de las compras realizadas:");

            //ValorIncial = Convert.ToDouble(Console.ReadLine());

            //promocion = descuento * ValorIncial;

            //ValorTotal = ValorIncial - promocion;

            //Console.WriteLine("El valor del descuento es de: " + " " + promocion);
            //Console.WriteLine("El valor total con el descuento del 15% incluido es de: " + " " + ValorTotal);

            //Console.ReadKey();

            /*04.- Un alumno desea saber cual será su calificación final en la materia de Algoritmos. 
             *Dicha calificación se compone de los siguientes porcentajes:
             *55 % del promedio de sus tres calificaciones parciales.
             *30 % de la calificación del examen final.
             *15 % de la calificación de un trabajo final.*/

            //double nota1, nota2, nota3,nota4, TrabajoPractico;
            //double ExamenFinal = 0;
            //double promedio = 0;
            //double TrabajoFinal = 0;

            //double CalificacionFinal = 0;

            //Console.WriteLine("Ingrese el valor de la primera nota parcial:");
            //nota1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de la segunda nota parcial:");
            //nota2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de la tercera nota parcial:");
            //nota3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Ingrese la nota del examen final:");
            //nota4 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Ingrese la nota del trabajo practico final:");
            //TrabajoPractico = Convert.ToDouble(Console.ReadLine());

            //promedio = (nota1 + nota2 + nota3) * 0.55;

            //ExamenFinal = nota4 * 0.30;

            //TrabajoFinal = TrabajoPractico * 0.15;

            //CalificacionFinal = (promedio + ExamenFinal + TrabajoFinal) /3;

            //Console.WriteLine("La calificacion final para el alumno en cuestion es de: " + " " + CalificacionFinal);


            /*5-Calcular el nuevo salario de un obrero 
             * si obtuvo un incremento del 25% sobre su salario anterior.*/

            //double SalarioAumentado = 0;

            //Console.WriteLine("Ingrese el salario del obrero para calcular el aumento");
            //double Salario = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //SalarioAumentado = Salario * 1.25;

            //Console.WriteLine("El salario original del obrero era de: " + Salario +" "+  "pesos.");
            //Console.WriteLine("El salario con el aumento es de: " + SalarioAumentado + " " +"pesos.");

            /*6-Mini-Calculadora*/

            //    float primero;     // El primer número
            //    float segundo;     // El segundo número
            //    string operacion;   // La operación a realizar 

            //    Console.Title = "Mini-Calculadora"; // Damos formato a la consola
            //    Console.BackgroundColor = ConsoleColor.White;
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.Clear();

            //    Console.SetCursorPosition(3, 2); // Pedimos el primer número
            //    Console.WriteLine("Introduzca el primer  número");
            //    Console.SetCursorPosition(60, 2);
            //    primero = float.Parse(Console.ReadLine());

            //    Console.SetCursorPosition(3, 3); // Pedimos la operación
            //    Console.WriteLine("Introduzca la operación a realizar (+,-,*,/)");
            //    Console.SetCursorPosition(59, 3);
            //    operacion = Console.ReadLine();

            //    Console.SetCursorPosition(3, 4); // Pedimos el segundo número
            //    Console.WriteLine("Introduzca el segundo número");
            //    Console.SetCursorPosition(60, 4);
            //    segundo = float.Parse(Console.ReadLine());


            //    Console.SetCursorPosition(57, 5); // Mostramos la solucion...
            //    Console.WriteLine("__________");

            //    Console.SetCursorPosition(3, 6);
            //    Console.WriteLine("El resultado es");
            //    Console.SetCursorPosition(60, 6);

            //    Console.WriteLine(calcular(primero, segundo, operacion));
            //    Console.ReadKey();

            //    Console.ReadKey();
            //}

            //private static string calcular(float primero, float segundo, string operacion)
            //{
            //    float temp;
            //    switch (operacion) // Estructura con switch
            //    {
            //        case "+":
            //            temp = primero + segundo;
            //            return temp.ToString();
            //        case "-":
            //            temp = primero - segundo;
            //            return temp.ToString();
            //        case "*":
            //            temp = primero * segundo;
            //            return temp.ToString();
            //        case "/":
            //            temp = primero / segundo;
            //            return temp.ToString();
            //    }
            //    return "-1";

            /*7-Cree un programa que pida el ingreso de un numero 
             * y muestre las tablas de multiplicar de este desde el uno al 15*/

            //Console.WriteLine("Un numero para mostrar su tabla de multiplicacion:");

            //int NumeroIngresado = Convert.ToInt32(Console.ReadLine());

            //for ( int i=0; i<=15; i++)
            //{
            //    Console.WriteLine( NumeroIngresado + "*"+ i + " = " + NumeroIngresado*i );
            //}

            /*8-Conteo de Caracteres*/
            //Console.CursorLeft = 20;

            //Console.WriteLine("Vamos a contar la cantidad de caracteres utilizados en total en todas las palabras ingresadas:");
            //Console.WriteLine("Ingrese la cantidad de palabras:");
            //int CantidadDePalabras = Convert.ToInt32(Console.ReadLine());

            //string[] PalabrasIngresadas = new string[CantidadDePalabras];

            //int NumeroDeCaracteres = 0;

            //Console.WriteLine("Ahora ingrese las palabras:");

            //for (int i=0; i<CantidadDePalabras; i++)
            //{
            //    PalabrasIngresadas[i] = Console.ReadLine();
            //    NumeroDeCaracteres += PalabrasIngresadas[i].Length;
            //}

            //Console.WriteLine("El numero de caracteres utilizados es: " + NumeroDeCaracteres);

            //10-Conteo de Caracteres
            //Console.WriteLine("Conteo de caracteres utilizados:");

            //string PalabraIngresada = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Numero de caracteres: " + PalabraIngresada.Length);

            Console.ReadKey();
        }
    }
}
