using NextLane.Sección_1;
using NextLane.Sección_2;
using NextLane.Sección_2.Vehicle___Car;

class Program
{
    static void Main(string[] args)
    {
        // SECCIÓN 1: INSTANCIA SINGLETON
        Console.WriteLine("=== SECCIÓN 1: INSTANCIA SINGLETON ===");

        var database1 = Database.GetInstance();
        database1.Query("SELECT * FROM Users");

        var database2 = Database.GetInstance();
        database2.Query("SELECT * FROM Products");

        Console.WriteLine();

        Console.WriteLine("Comprobación Singleton:");
        Console.WriteLine($"Ambas referencias son iguales? {database1 == database2}");

        Console.WriteLine();

        // SECCIÓN 2: MANIPULACIÓN DE CADENAS Y EXCEPCIONES
        Console.WriteLine("=== SECCIÓN 2: MANIPULACIÓN DE CADENAS Y EXCEPCIONES ===");

        Console.WriteLine("CONSIGNA A) REVERSIÓN DE STRING");
        Console.WriteLine(StringManipulator.ReversedString("hola"));
        
        Console.WriteLine("CONSIGNA C) MANEJO DE EXCEPCIÓN NULL");
        try
        {
            ErrorHandler.SomeMethod(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo una excepción: {ex.Message}");
        }

        Console.WriteLine();

        // SECCIÓN 3: AUTOS Y VEHÍCULOS
        Console.WriteLine("=== SECCIÓN 3: AUTOS Y VEHÍCULOS ===");

        Car myCar = new Car("Toyota", "Corolla", 2020, "Gasoline");

        double distance = 500;
        double consumption = 50;

        double efficiency = myCar.CalculateFuelEfficiency(distance, consumption);
        Console.WriteLine($"The fuel efficiency is: {efficiency} km/liter");

        Console.WriteLine();
    }
}