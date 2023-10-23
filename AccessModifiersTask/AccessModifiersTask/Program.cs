using AccessModifiersTask.Models;

namespace AccessModifiersTask
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("How many notebooks do you want to add?: ");
            int notebookCount = Convert.ToInt32(Console.ReadLine());

            Notebook[] notebooks = new Notebook[notebookCount];

            for (int i = 0; i < notebookCount; i++)
            {
                Console.WriteLine($"\nNotebook {i + 1}");
                Console.Write("Model(3 to 30 symbols): ");
                string model = Console.ReadLine();
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("RAM (0-128 GB): ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Storage (positive number in GB): ");
                int storage = Convert.ToInt32(Console.ReadLine());
                Console.Write("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Stock count: ");
                int stock = Convert.ToInt32(Console.ReadLine());

                notebooks[i] = new Notebook(stock, price, model, brand, ram, storage);
            }

            // Print the details of added notebooks
            Console.WriteLine("\nNotebooks added to the system:");
            for (int i = 0; i < notebookCount; i++)
            {
                Console.WriteLine($"Notebook {i + 1} - Model: {notebooks[i].Model}, Brand: {notebooks[i].Brand}, RAM: {notebooks[i].RAM} GB, Storage: {notebooks[i].Storage} GB");
            }
        }
    }
}