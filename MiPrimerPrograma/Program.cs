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


            // Clase 2: Variables
            Console.WriteLine("---------------------------------------------");
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


            // Clase 3: Constantes
            Console.WriteLine("---------------------------------------------");
            /*Es un valor inmutable que se define al compilar el programa 
             * y que no cambia jamás mientras el programa se está ejecutando 
             * y ayuda a agregar seguridad y estabilidad al código porque 
             * nadie puede alterar esos valores por accidente o apropósito*/
            const double PI = 3.14159; 
            Console.WriteLine(PI);


            // Clase 4: Conversión de tipos
            Console.WriteLine("---------------------------------------------");
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

        }
    }
}