using RestaurantSite.Models.Pages;
using RestaurantSite.Models.ViewModels;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using System.Text;
using System.Web.Mvc;

namespace RestaurantSite.Controllers
{
    public class RestaurantPageController : PageControllerBase<RestaurantPage>
    {
        public ActionResult Index(RestaurantPage currentPage)
        {
            var model = new RestaurantPageViewModel(currentPage);

            var table = new StringBuilder();
            if (model.CurrentPage.List != null)
            {
                table.Append("<table><tr><th>Item</th><th>Price</th><th>Image</th></tr>");
                foreach (var item in model.CurrentPage.List)
                {
                    table.Append("<tr><td>");
                    table.Append(item.Item);
                    table.Append("</td><td>");
                    table.Append(item.Price);
                    table.Append("</td><td><img class=\"smallImg\" src=\"");
                    var path = ServiceLocator.Current.GetInstance<UrlResolver>().GetUrl(item.Image);
                    table.Append(path);
                    table.Append("\" /></td></tr>");
                }
                table.Append("</table>");
            }

            //model.Table = new XhtmlString(table.ToString());
            return View(model);
        }
    }
}