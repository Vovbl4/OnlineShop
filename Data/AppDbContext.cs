using Microsoft.EntityFrameworkCore;
using MyWebSiteMVC.Models;

namespace MyWebSiteMVC.Data;

public class AppDbContext : DbContext //Tot fisieru conectarea cu SQL, necesita migratie dupa update la file-u acesta //add-migration Orders -Context MyWebSiteMVC.Data.AppDbContext
{//Tools->Nuget->Console //update-database -Context MyWebSiteMVC.Data.AppDbContext
    public DbSet<Blog> posts { get; set; } = null!;
    public DbSet<Item> items { get; set; } = null!;
    public DbSet<Category> categories { get; set; } = null!;
    public DbSet<Order> orders { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}

