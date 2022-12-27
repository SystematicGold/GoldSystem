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
            if (await context.User.AnyAsync()) return;
            var UserData = await File.ReadAllTextAsync("Data/UserSeed.json");
            var Options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var users = JsonSerializer.Deserialize<User_>(UserData);
            context.User.Add(users);
            await context.SaveChangesAsync();
            // ======================================   Karat Item
            if (await context.DeffKarat.AnyAsync()) return;
            var KaratData = await File.ReadAllTextAsync("Data/KaratSeed.json");
            var KaratOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var Karat = JsonSerializer.Deserialize<List<DeffKarat_>>(KaratData);
            context.DeffKarat.AddRange(Karat);
            await context.SaveChangesAsync();
            // ======================================   Pay Method
            if (await context.DeffPayMethod.AnyAsync()) return;
            var PayMethodData = await File.ReadAllTextAsync("Data/PayMethodSeed.json");
            var PayMethodOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var PayMethod = JsonSerializer.Deserialize<List<DeffPayMethod_>>(PayMethodData);
            context.DeffPayMethod.AddRange(PayMethod);
            await context.SaveChangesAsync();
            // ======================================   DeffGoldBarCode
            if (await context.DeffGoldBarCode.AnyAsync()) return;
            var DeffGoldBarCodeData = await File.ReadAllTextAsync("Data/DeffGoldBarCodeSeed.json");
            var DeffGoldBarCodeOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var DeffGoldBarCode = JsonSerializer.Deserialize<List<DeffGoldBarCode_>>(DeffGoldBarCodeData);
            context.DeffGoldBarCode.AddRange(DeffGoldBarCode);
            await context.SaveChangesAsync();
        }
    }
}