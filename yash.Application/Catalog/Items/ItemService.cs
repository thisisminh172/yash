using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using System.Linq;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Items;
using Microsoft.EntityFrameworkCore;
using yash.ViewModels.Catalog.ItemImages;

namespace yash.Application.Catalog.Items
{
    public class ItemService : IItemService
    {
        private readonly YashDbContext _context;
        public ItemService(YashDbContext context)
        {
            _context = context;
        }
        public Task<int> Create(ItemCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int goldId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ItemViewModel>> GetAll()
        {

            var query = from i in _context.Items
                        join img in _context.ItemImages on i.Id equals img.ItemId where img.IsDefault == true
                        join pt in _context.ProductTypes on i.ProductId equals pt.Id into ipt
                        from pt in ipt.DefaultIfEmpty()
                        join g in _context.Golds on i.GoldId equals g.Id into ig
                        from g in ig.DefaultIfEmpty()
                        join d in _context.Diamonds on i.DiamondId equals d.Id into id
                        from d in id.DefaultIfEmpty()
                        join c in _context.Categories on i.CategoryId equals c.Id into ic
                        from c in ic.DefaultIfEmpty()
                        join rs in _context.RingSizes on i.RingSizeId equals rs.Id into irs
                        from rs in irs.DefaultIfEmpty()
                        join cer in _context.Certifications on i.CertifyId equals cer.Id into icer
                        from cer in icer.DefaultIfEmpty()
                        select new { i, pt, g, d, c, rs, cer, img };


                        

            var data = await query
                .Select(x => new ItemViewModel()
                {
                    Id = x.i.Id,
                    Name = x.i.Name,
                    CategoryName = x.c.Name,
                    CertifyName = x.cer.Name,
                    DiamondCarat = x.i.DiamondCarat,
                    DiamondShapeName = x.d.DiamondShape,
                    GoldCaratName = x.g.GoldCarat,
                    GoldWeight = x.i.GoldWeight,
                    ProductName = x.pt.Name,
                    RingSizeNumber = x.rs.SizeNumber,
                    ThumbnailImage = x.img.ItemImageUrl,
                    TotalMaking = x.i.TotalMaking,
                    WastageInPercentage = x.i.WastageInPercentage,
                    itemImageViewModels = (from img in _context.ItemImages
                                                 where img.ItemId == x.i.Id
                                                 select new ItemImageViewModel()
                                                 {
                                                     ItemImageUrl = img.ItemImageUrl
                                                 }).ToList()
                }).ToListAsync();

            return data;
        }

        public async Task<List<ItemImageViewModel>> GetAllImages(int itemId)
        {
            var images = await _context.ItemImages.Where(x => x.ItemId == itemId).ToListAsync();
            var listImages = new List<ItemImageViewModel>();
            foreach(var img in images)
            {
                listImages.Add(new ItemImageViewModel() { ItemImageUrl = img.ItemImageUrl});
            }
            return listImages;
        }

        public async Task<ItemViewModel> GetById(int itemId)
        {
            var item = await _context.Items.FindAsync(itemId);
            var images = await _context.ItemImages.Where(x => x.ItemId == itemId).ToListAsync();

            var categoryName = await _context.Categories.Where(x => x.Id == item.CategoryId).FirstOrDefaultAsync();
            var certifyName = await _context.Certifications.Where(x => x.Id == item.CertifyId).FirstOrDefaultAsync();
            var diamondShapeName = await _context.Diamonds.Where(x => x.Id == item.DiamondId).FirstOrDefaultAsync();
            var goldCaratName = await _context.Golds.Where(x => x.Id == item.GoldId).FirstOrDefaultAsync();
            var productName = await _context.ProductTypes.Where(x => x.Id == item.ProductId).FirstOrDefaultAsync();
            var ringSizeNumber = await _context.RingSizes.Where(x => x.Id == item.RingSizeId).FirstOrDefaultAsync();


            var itemViewModel = new ItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                CategoryName = categoryName.Name,
                CertifyName = certifyName.Name,
                DiamondCarat = item.DiamondCarat,
                DiamondShapeName = diamondShapeName.DiamondShape,
                GoldCaratName = goldCaratName.GoldCarat,
                GoldWeight = item.GoldWeight,
                ProductName = productName.Name,
                RingSizeNumber = ringSizeNumber.SizeNumber,
                TotalMaking = item.TotalMaking,
                WastageInPercentage = item.WastageInPercentage,
                itemImageViewModels = await (from img in _context.ItemImages where img.ItemId == item.Id select new ItemImageViewModel(){ 
                 ItemImageUrl = img.ItemImageUrl,
                 IsDefault = img.IsDefault
                }).ToListAsync()
            };
            return itemViewModel;
        }

        public async Task<List<ItemViewModel>> GetItemsByCategory(int categoryId)
        {
            //var items = await _context.Items.Where(x => x.CategoryId == categoryId).ToListAsync();

            var query = from i in _context.Items where i.ProductId==categoryId
                        join img in _context.ItemImages on i.Id equals img.ItemId
                        where img.IsDefault == true
                        join pt in _context.ProductTypes on i.ProductId equals pt.Id into ipt
                        from pt in ipt.DefaultIfEmpty()
                        join g in _context.Golds on i.GoldId equals g.Id into ig
                        from g in ig.DefaultIfEmpty()
                        join d in _context.Diamonds on i.DiamondId equals d.Id into id
                        from d in id.DefaultIfEmpty()
                        join c in _context.Categories on i.CategoryId equals c.Id into ic
                        from c in ic.DefaultIfEmpty()
                        join rs in _context.RingSizes on i.RingSizeId equals rs.Id into irs
                        from rs in irs.DefaultIfEmpty()
                        join cer in _context.Certifications on i.CertifyId equals cer.Id into icer
                        from cer in icer.DefaultIfEmpty()
                        select new { i, pt, g, d, c, rs, cer, img };
            var data = await query
                .Select(x => new ItemViewModel()
                {
                    Id = x.i.Id,
                    Name = x.i.Name,
                    CategoryName = x.c.Name,
                    CertifyName = x.cer.Name,
                    DiamondCarat = x.i.DiamondCarat,
                    DiamondShapeName = x.d.DiamondShape,
                    GoldCaratName = x.g.GoldCarat,
                    GoldWeight = x.i.GoldWeight,
                    ProductName = x.pt.Name,
                    RingSizeNumber = x.rs.SizeNumber,
                    ThumbnailImage = x.img.ItemImageUrl,
                    TotalMaking = x.i.TotalMaking,
                    WastageInPercentage = x.i.WastageInPercentage,
                    itemImageViewModels = (from img in _context.ItemImages
                                           where img.ItemId == x.i.Id
                                           select new ItemImageViewModel()
                                           {
                                               ItemImageUrl = img.ItemImageUrl
                                           }).ToList()
                }).ToListAsync();

            return data;
        }
    }
}
