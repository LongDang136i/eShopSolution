using eShopSolution.ViewModel.Catalog.Categories;
using eShopSolution.ViewModel.Catalog.Products;

namespace eShopSolution.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }
    }
}