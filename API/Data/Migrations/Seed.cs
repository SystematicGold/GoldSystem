using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Migrations
{
    public class Seed
    {
        public static async Task SeedUser(DataContext context)
        {
            // ======================================   User Item
            if (await context.Users.AnyAsync()) return;
            var UserData = await File.ReadAllTextAsync("Data/UserSeed.json");
            var Options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var users = JsonSerializer.Deserialize<Users>(UserData);
            context.Users.Add(users);
            await context.SaveChangesAsync();
            // ======================================   Karat Item
            if (await context.KartItems.AnyAsync()) return;
            var KaratData = await File.ReadAllTextAsync("Data/KaratSeed.json");
            var KaratOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var Karat = JsonSerializer.Deserialize<List<KaratItem>>(KaratData);
            context.KartItems.AddRange(Karat);
            await context.SaveChangesAsync();
        }
    }
}