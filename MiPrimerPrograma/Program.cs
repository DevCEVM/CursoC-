namespace MiPrimerPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}