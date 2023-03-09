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
            // ======================================   User
            if (await context.User.AnyAsync()) return;
            var UserData = await File.ReadAllTextAsync("Data/UserSeed.json");
            var UserOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var User = JsonSerializer.Deserialize<User_>(UserData);
            context.User.Add(User);
            await context.SaveChangesAsync();
            // ======================================   DeffKarat
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
            // ======================================   Gold BarCode
            if (await context.DeffGoldBarCode.AnyAsync()) return;
            var GoldBarCodeData = await File.ReadAllTextAsync("Data/DeffGoldBarCodeSeed.json");
            var GoldBarCodeOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var GoldBarCode = JsonSerializer.Deserialize<List<DeffGoldBarCode_>>(GoldBarCodeData);
            context.DeffGoldBarCode.AddRange(GoldBarCode);
            await context.SaveChangesAsync();
            // ======================================   Gold Item Name
            if (await context.GoldDeffItemName.AnyAsync()) return;
            var GoldItemNameData = await File.ReadAllTextAsync("Data/GoldDeffItemNameSeed.json");
            var GoldItemNameOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var GoldItemName = JsonSerializer.Deserialize<List<GoldDeffItemName_>>(GoldItemNameData);
            context.GoldDeffItemName.AddRange(GoldItemName);
            await context.SaveChangesAsync();
            // ======================================   CountryOfOrigin
            if (await context.DeffCountryOfOrigin.AnyAsync()) return;
            var CountryOfOriginData = await File.ReadAllTextAsync("Data/DeffCountryOfOriginSeed.json");
            var CountryOfOriginOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var CountryOfOrigin = JsonSerializer.Deserialize<List<DeffCountryOfOrigin_>>(CountryOfOriginData);
            context.DeffCountryOfOrigin.AddRange(CountryOfOrigin);
            await context.SaveChangesAsync();
            // ======================================   DeffSupplier
            if (await context.DeffSupplier.AnyAsync()) return;
            var SupplierData = await File.ReadAllTextAsync("Data/DeffSupplierSeed.json");
            var SupplierOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var Supplier = JsonSerializer.Deserialize<List<DeffSupplier_>>(SupplierData);
            context.DeffSupplier.AddRange(Supplier);
            await context.SaveChangesAsync();
            // ======================================   Deff Tax Exempt
            if (await context.DeffTaxExempt.AnyAsync()) return;
            var TaxExemptData = await File.ReadAllTextAsync("Data/DeffTaxExemptSeed.json");
            var TaxExemptOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var TaxExempt = JsonSerializer.Deserialize<List<DeffTaxExempt_>>(TaxExemptData);
            context.DeffTaxExempt.AddRange(TaxExempt);
            await context.SaveChangesAsync();
            // ======================================   DeffItemCondition
            if (await context.DeffItemCondition.AnyAsync()) return;
            var ItemConditionData = await File.ReadAllTextAsync("Data/DeffItemConditionSeed.json");
            var ItemConditionOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var ItemCondition = JsonSerializer.Deserialize<List<DeffItemCondition_>>(ItemConditionData);
            context.DeffItemCondition.AddRange(ItemCondition);
            await context.SaveChangesAsync();
            // ======================================   DeffStoneType
            if (await context.DeffStoneType.AnyAsync()) return;
            var StoneTypeData = await File.ReadAllTextAsync("Data/DeffStoneTypeSeed.json");
            var StoneTypeOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var StoneType = JsonSerializer.Deserialize<List<DeffStoneType_>>(StoneTypeData);
            context.DeffStoneType.AddRange(StoneType);
            await context.SaveChangesAsync();
            // ======================================   DeffStoneName
            if (await context.DeffStoneName.AnyAsync()) return;
            var StoneNameData = await File.ReadAllTextAsync("Data/DeffStoneNameSeed.json");
            var StoneNameOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var StoneName = JsonSerializer.Deserialize<List<DeffStoneName_>>(StoneNameData);
            context.DeffStoneName.AddRange(StoneName);
            await context.SaveChangesAsync();
            // ======================================   DeffCaratOrGm
            if (await context.DeffCaratOrGm.AnyAsync()) return;
            var CaratOrGmData = await File.ReadAllTextAsync("Data/DeffCaratOrGmSeed.json");
            var CaratOrGmOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var CaratOrGm = JsonSerializer.Deserialize<List<DeffCaratOrGm_>>(CaratOrGmData);
            context.DeffCaratOrGm.AddRange(CaratOrGm);
            await context.SaveChangesAsync();
            // ======================================   DeffStoneClarity
            if (await context.DeffStoneClarity.AnyAsync()) return;
            var StoneClarityData = await File.ReadAllTextAsync("Data/DeffStoneClaritySeed.json");
            var StoneClarityOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var StoneClarity = JsonSerializer.Deserialize<List<DeffStoneClarity_>>(StoneClarityData);
            context.DeffStoneClarity.AddRange(StoneClarity);
            await context.SaveChangesAsync();
            // ======================================   DeffStoneColor
            if (await context.DeffStoneColor.AnyAsync()) return;
            var StoneColorData = await File.ReadAllTextAsync("Data/DeffStoneColorSeed.json");
            var StoneColorOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var StoneColor = JsonSerializer.Deserialize<List<DeffStoneColor_>>(StoneColorData);
            context.DeffStoneColor.AddRange(StoneColor);
            await context.SaveChangesAsync();
            // ======================================   DeffStoneCut
            if (await context.DeffStoneCut.AnyAsync()) return;
            var StoneCutData = await File.ReadAllTextAsync("Data/DeffStoneCutSeed.json");
            var StoneCutOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var StoneCut = JsonSerializer.Deserialize<List<DeffStoneCut_>>(StoneCutData);
            context.DeffStoneCut.AddRange(StoneCut);
            await context.SaveChangesAsync();

        }
    }
}