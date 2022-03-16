
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetPulbicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
