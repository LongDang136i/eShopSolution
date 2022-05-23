using eShopSolution.ViewModel.System.Languages;
using System.Collections.Generic;

namespace eShopSolution.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Language { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}