namespace RiwiMusic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a Riwi Music");
        while (true)
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("Ingrese una de las opciones");
            Console.WriteLine("1. Gestión de Conciertos");
            Console.WriteLine("2. Gestión de Clientes");
            Console.WriteLine("3. Gestión de Tiquetes");
            Console.WriteLine("4. Historial de Compras");
            Console.WriteLine("5. Consultas Avanzadas (LINQ)");
            Console.WriteLine("6. Salir del programa");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Gestión de Conciertos");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Gestión de Clientes");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Gestión de Tiquetes");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Historial de Compras");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Consultas Avanzadas (LINQ)");
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Salir del programa");
                    break;

            }
            break;

        }
    }
    
}