using DevReviews.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevReviews.API.Persistence.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);

        Task UpdateAsync(Product product);

        Task<Product> GetByIdAsync(int id);

        Task<List<Product>> GetAllAsync();

        Task<Product> GetDetailsByIdAsync(int id);

        Task AddReviewAsync(ProductReview productReview);

        Task<ProductReview> GetReviewByIdAsync(int id);
    }
}