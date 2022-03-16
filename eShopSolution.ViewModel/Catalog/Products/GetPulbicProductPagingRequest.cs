
using eShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Catalog.Products
{
    public  class GetPulbicProductPagingRequest: PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
