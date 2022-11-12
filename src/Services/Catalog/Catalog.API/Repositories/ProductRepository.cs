using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ICatalogContext _ıcatalogContext;

        public ProductRepository(ICatalogContext ıcatalogContext)
        {
            _ıcatalogContext = ıcatalogContext;
        }

        
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _ıcatalogContext
                .Products
                .Find(p => true)//Fin metodu için mongoDB driver kullanımaktır.Veritabanı arama işlemi için
                .ToListAsync();
        }
        public async Task<Product> GetProduct(string id)
        {
            return await _ıcatalogContext
                .Products
                .Find(p => p.Id==id)//Fin metodu için mongoDB driver kullanımaktır.Veritabanı arama işlemi için
                .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Name, name);

            return await _ıcatalogContext
                            .Products
                            .Find(filter)
                            .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Category, categoryName);

            return await _ıcatalogContext
                            .Products
                            .Find(filter)
                            .ToListAsync();
        }

        public async Task CreateProduct(Product product)
        {
            await _ıcatalogContext.Products.InsertOneAsync(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var updateResult = await _ıcatalogContext
                                        .Products
                                        .ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> DeleteProduct(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, id);

            DeleteResult deleteResult = await _ıcatalogContext
                                                .Products
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
