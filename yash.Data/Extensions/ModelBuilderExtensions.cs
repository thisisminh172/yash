using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Entities;

namespace yash.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin() { Id=1,Address="cmt8",Email="minhl93172@gmail.com",FirstName="Minh",LastName="Le",Password="123",Role=true},
                new Admin() { Id=2,Address="cmt8",Email="tuan123@gmail.com",FirstName="Tuan",LastName="Bui",Password="123",Role=false }
                );

            modelBuilder.Entity<RingSize>().HasData(
                new RingSize() { Id=1, SizeNumber=6},
                new RingSize() { Id=2, SizeNumber=7},
                new RingSize() { Id=3, SizeNumber=8},
                new RingSize() { Id=4, SizeNumber=9},
                new RingSize() { Id=5, SizeNumber=10},
                new RingSize() { Id=6, SizeNumber=11},
                new RingSize() { Id=7, SizeNumber=12},
                new RingSize() { Id = 8, SizeNumber = 13 },
                new RingSize() { Id=9, SizeNumber=14},
                new RingSize() { Id=10, SizeNumber=15},
                new RingSize() { Id=11, SizeNumber=16},
                new RingSize() { Id=12, SizeNumber=17},
                new RingSize() { Id=13, SizeNumber=18},
                new RingSize() { Id=14, SizeNumber=19},
                new RingSize() { Id=15, SizeNumber=20},
                new RingSize() { Id=16, SizeNumber=21},
                new RingSize() { Id=17, SizeNumber=22},
                new RingSize() { Id=18, SizeNumber=23},
                new RingSize() { Id = 19, SizeNumber = 24 },
                new RingSize() { Id = 20, SizeNumber = 25 },
                new RingSize() { Id = 21, SizeNumber = 26 },
                new RingSize() { Id = 22, SizeNumber = 27 },
                new RingSize() { Id = 23, SizeNumber = 28 },
                new RingSize() { Id = 24, SizeNumber = 29 },
                new RingSize() { Id = 25, SizeNumber = 30 }
                );
        }
    }
}
