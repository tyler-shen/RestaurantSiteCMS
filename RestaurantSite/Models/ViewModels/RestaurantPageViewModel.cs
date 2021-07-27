using RestaurantSite.Models.Pages;
using EPiServer.Core;

namespace RestaurantSite.Models.ViewModels
{
    public class RestaurantPageViewModel : PageViewModel<RestaurantPage>
    {
        public RestaurantPageViewModel(RestaurantPage currentPage) : base(currentPage)
        {
        }
    }
}