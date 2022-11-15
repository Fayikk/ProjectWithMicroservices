using Discount.Grpc.Entities;
using System.Threading.Tasks;

namespace Discount.Grpc.Repository
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string ProductName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string ProductName);
    }
}
