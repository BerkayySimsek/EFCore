using AutoMapper.QueryableExtensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;
using UdemyEFCore.CodeFirst.DTOs;
using UdemyEFCore.CodeFirst.Mappers;
using UdemyEFCore.CodeFirst.Models;

Initializer.Build();
using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} - {p.Stock} - {p.Barcode}");
    });
}
