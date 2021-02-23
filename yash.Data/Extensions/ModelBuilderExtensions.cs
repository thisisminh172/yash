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
            modelBuilder.Entity<Gold>().HasData(
                new Gold() { Id=1,GoldCarat="14kt",Price=1034.8f},
                new Gold() { Id=2,GoldCarat="18kt",Price=1338.9f}
                );
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType() { Id=1,Name="RINGS"},
                new ProductType() { Id=2,Name="EARRINGS"},
                new ProductType() { Id=3,Name="PENDANTS"}
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id=1,Name="Anniversary"},
                new Category() { Id=2, Name = "Birthday"},
                new Category() { Id=3, Name = "Wedding"},
                new Category() { Id=4, Name = "Engagement"}
                );
            modelBuilder.Entity<Diamond>().HasData(
                new Diamond() {Id=1,DiamondShape="round",Price=7291f },
                new Diamond() {Id=2,DiamondShape="princess",Price=4799f },
                new Diamond() {Id=3,DiamondShape="oval",Price=5362f },
                new Diamond() {Id=4,DiamondShape="cushion",Price=4229f },
                new Diamond() {Id=5,DiamondShape="pear",Price=5802f },
                new Diamond() {Id=6,DiamondShape="radiant",Price=4443f },
                new Diamond() {Id=7,DiamondShape="emerald",Price=4476f },
                new Diamond() {Id=8,DiamondShape="asscher",Price=4137f },
                new Diamond() {Id=9,DiamondShape="marquise",Price=5596f },
                new Diamond() {Id=10,DiamondShape="heart",Price=5536f }
                );
            modelBuilder.Entity<Certification>().HasData(
                new Certification() { Id=1, Name = "BIS Hallmark",LinkUrl= "http://www.bis.org.in/" },
                new Certification() { Id=2, Name = "SGL",LinkUrl= "https://sgl-labs.com/" },
                new Certification() { Id=3, Name = "IGI",LinkUrl= "https://www.igi.org/" }
                );

        }
    }
}
