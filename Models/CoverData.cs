using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Shop.Models;

namespace Shop.Models
{
    public static class CoverData
    {
        public static void Initialize (ShopContext context)
        {
            if (!context.Towels.Any())
            {
                context.Towels.Add(new Towel { Color = "black", Hight = 10, Id = 1, Material = "Cotton", With = 20 });
                context.SaveChanges();
            }
        }
    }
}
