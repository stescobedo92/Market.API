using Market.API.Domain.Models;

namespace Market.API.Domain.Services.Communication
{
    public class ProductResponse : BaseResponse<Product>
    {
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="product">Saved product.</param>
        /// <returns>Response.</returns>
        public ProductResponse(Product product) : base(product) { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ProductResponse(string message) : base(message) { }
    }
}