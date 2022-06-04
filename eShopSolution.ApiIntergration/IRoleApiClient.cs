using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntergration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}