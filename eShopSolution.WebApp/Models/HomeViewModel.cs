using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Utilities.Slides;
using System.Collections.Generic;

namespace eShopSolution.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}