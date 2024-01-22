using asp.DataAccess.Repository.IRepository;
using asp.Models;
using ProjektnaASP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb!=null)
            {
                objFromDb.Title = obj.Title;
				objFromDb.Price = obj.Price;
            	objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price5 = obj.Price5;
                objFromDb.Description = obj.Description;
				objFromDb.CategoryId = obj.CategoryId;
			    if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
