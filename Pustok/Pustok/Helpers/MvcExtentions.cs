using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace Pustok.Helpers
{
    public static class MvcExtentions
    {
        public static string ActiveClasses(this IHtmlHelper helper,string controller, string action, string ClassName="active")
        {
            var currentController= helper.ViewContext.RouteData.Values["controller"] as string;
            var currentAction= helper.ViewContext.RouteData.Values["action"] as string;

            return (currentController == controller && currentAction == action) ? ClassName : "";   
        }
    }
}
