namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product(10, 50);
        Markers markers = new Markers(20, 30, "фломастеры для рисования ", 2);

        Console.WriteLine("Информация о продукте:");
        product.DisplayInfo();
        Console.WriteLine($"стоимость товара: {product.Cost()}");

        Console.WriteLine("\nИнформация о фломастерах:");
        markers.DisplayInfo();
        Console.WriteLine($"Стоимость фломастера: {markers.Cost():F2}");
    }
}