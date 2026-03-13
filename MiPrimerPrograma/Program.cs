using System.Security.Cryptography;

namespace MiPrimerPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 1: tipos de salida

            Console.Write("Hola Mundo!");
            Console.WriteLine("Cristopher Villegas");
            Console.Beep();
            // Esto es un comentario
            /* Esto también
             * es un comentario
             * pero de varias líneas */
            Console.WriteLine("\tHola");
            Console.WriteLine("\bMundo");
            Console.WriteLine("\nHola mundo");
            Console.WriteLine("Mi nombre es: \nCristopher");

            // Console.ReadLine();

            Console.WriteLine("---------------------------------------------");
            // Clase 2: Variables

            int x; // Declaración
            x = 123; // Inicializar
            Console.WriteLine(x);
            int y = 321; //Declarar e Inicializar
            Console.WriteLine(y);
            int z = x + y;
            Console.WriteLine(z);
            int edad = 33;
            Console.WriteLine("Tu edad es: " + edad + " años");
            double altura = 1.76;
            Console.WriteLine("Tu altura es: " + altura + " metros");
            bool vivo = true;
            Console.WriteLine("¿Estás vivo? " + vivo);
            char simbolo = '@';
            Console.WriteLine("Tu símbolo es: " + simbolo);
            string nombre = "Cristopher";
            Console.WriteLine("Hola " + nombre + "!");
            string usuario = simbolo + nombre;
            Console.WriteLine("Tu nombre de usuario es: " + usuario);

            Console.WriteLine("---------------------------------------------");
            // Clase 3: Constantes

            /*Es un valor inmutable que se define al compilar el programa 
             * y que no cambia jamás mientras el programa se está ejecutando 
             * y ayuda a agregar seguridad y estabilidad al código porque 
             * nadie puede alterar esos valores por accidente o apropósito*/
            const double PI = 3.14159; 
            Console.WriteLine(PI);

            Console.WriteLine("---------------------------------------------");
            // Clase 4: Conversión de tipos

            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            int c = 123;
            double d = Convert.ToDouble(c) + .1;
            Console.WriteLine(d);
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            int e = 321;
            string f = Convert.ToString(e);
            Console.WriteLine(f);
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());
            string g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());
            string i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());
            int k = -150;
            bool l = Convert.ToBoolean(k); //cualquier número diferente de 0 será true, sólo 0 será false
            Console.WriteLine(l);
            Console.WriteLine(k.GetType());
            Console.WriteLine(l.GetType());

            Console.WriteLine("---------------------------------------------");
            // Clase 5: Entrada de usuario
            
            Console.Write("Escribe tu nombre: ");
            string name = Console.ReadLine();
            Console.Write("Escribe tu edad: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hola " + name);
            Console.WriteLine("Tienes " + age + " Años");
            
            // Clase 6: Aritmetica Básica
            Console.WriteLine("---------------------------------------------");

            int amigos = 5;
            amigos = amigos + 1;
            amigos += 1; //forma abrebiada de la anterior
            amigos++; //suma 1 y sólo 1
            Console.WriteLine(amigos);
            amigos = amigos - 1;
            amigos -= 1; //forma abrebiada de la anterior
            amigos--; //resta 1 y sólo 1
            Console.WriteLine(amigos);
            amigos = amigos * 2;
            amigos *= 2;
            Console.WriteLine(amigos);
            amigos = amigos / 2; 
            amigos /= 2; //trucha aquí porque esto regresa un int y no un double
            Console.WriteLine(amigos);
            int resto = amigos % 2; //esto te puede servir para saber si un número es par o inpar
            Console.WriteLine(resto);

            // Clase 7: Clase Math
            Console.WriteLine("---------------------------------------------");

            double m = 3;
            double n = Math.Pow(m, 27); // Esto eleva a la potencia que le pongas
            Console.WriteLine(n);
            double o = 7;
            double p = Math.Pow(m, n); // La potencia puede ser una variable también
            Console.WriteLine(p);
            double q = Math.Sqrt(o); // Esto saca la raíz cuadrada
            Console.WriteLine(q);
            o = -7.35;
            double r = Math.Abs(o); // Esto te trae un número absoluto, es útil para convertir números negativos a positivos
            Console.WriteLine(r);
            double s = Math.Round(o); // Esto redondea
            Console.WriteLine(s);
            double t = Math.Ceiling(o); // Esto redondea hacia arriba sin importar el decimal
            Console.WriteLine(t);
            double u = Math.Floor(o); // Esto redondea hacia abajo sin importar el decimal
            Console.WriteLine(u);
            double v = Math.Max(m, o); // Esto me dice el número más alto
            Console.WriteLine(v);
            double w = Math.Min(m, o); //Esto me dice el número más bajo
            Console.WriteLine(w);

            // Clase 8: Números Aleatorios
            Console.WriteLine("---------------------------------------------");

            Random random = new Random();

            int num = random.Next(0,6) + 1; //esto te da un número random entre 1 y más de 2mil millones, así que ponle un rango de números para que no se haga mucho desmadre
            Console.WriteLine(num);
            double numb = random.NextDouble(); // Esto te da un número entre 0 y 1 con 16 decimales
            Console.WriteLine(numb);

            // si necesito tirar 3 dados de 6 no necesito crear más objetos, con el de la linea 151 es suficiente:
            int num1 = random.Next(1,7);
            int num2 = random.Next(1,7);
            int num3 = random.Next(1,7);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);


        }
    }
}