using eShopSolution.ViewModel.Common;
using System.Collections.Generic;

namespace eShopSolution.ViewModel.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}