
using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirstByScaffold.Models;



using (var context = new EFCoreDatabaseFırstDbContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} :{p.Name} - {p.Price}");
    });
}