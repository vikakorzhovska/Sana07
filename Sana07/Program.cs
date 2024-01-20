using Sana07;
using System.Text;
try
{
    Console.InputEncoding = Encoding.Unicode;
    Console.OutputEncoding = Encoding.Unicode;
    ShoppingCart shoppingCart = new ShoppingCart();

    Cake cake = new Cake("Шоколадна ніч", 690, 2, "Шоколадний", new DateTime(2024, 01, 19));
    Book book = new Book("Гаррі Поттер і Філософський камінь", 700, 4, "Джоан Роулінг", "Фантастика");
    Table table = new Table("Deco", 1099, 1, "Дерево", "medium");

    shoppingCart.AddItems(table);
    shoppingCart.AddItems(book);
    shoppingCart.AddItems(cake);

    Console.WriteLine("Товари в кошику:");
    List<string> items = shoppingCart.ItemsInfo();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }

    decimal total = shoppingCart.TotalPrice();
    Console.WriteLine($"Загальна вартість: {total}");
}
catch (PriceException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Введена ціна: {ex.Price}");
}
catch (CountException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Введена кількість: {ex.Count}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}