namespace Example.Web.Infrastructure
{
    using System;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class HtmlHelperExtensions
    {
        public static bool IsActive(this IHtmlHelper helper, string area)
        {
            var currentArea = (string)helper.ViewContext.RouteData.Values["area"]!;
            return area.Equals(currentArea, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsActive(this IHtmlHelper helper, string area, string controller)
        {
            var currentArea = (string)helper.ViewContext.RouteData.Values["area"]!;
            var currentController = (string)helper.ViewContext.RouteData.Values["controller"]!;
            return area.Equals(currentArea, StringComparison.OrdinalIgnoreCase) &&
                   controller.Equals(currentController, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsActive(this IHtmlHelper helper, string area, string[] controllers)
        {
            var currentArea = (string)helper.ViewContext.RouteData.Values["area"]!;
            var currentController = (string)helper.ViewContext.RouteData.Values["controller"]!;
            return area.Equals(currentArea, StringComparison.OrdinalIgnoreCase) &&
                   controllers.Any(x => x.Equals(currentController, StringComparison.OrdinalIgnoreCase));
        }

        public static bool IsActive(this IHtmlHelper helper, string area, string controller, string action)
        {
            var currentArea = (string)helper.ViewContext.RouteData.Values["area"]!;
            var currentController = (string)helper.ViewContext.RouteData.Values["controller"]!;
            var currentAction = (string)helper.ViewContext.RouteData.Values["action"]!;
            return area.Equals(currentArea, StringComparison.OrdinalIgnoreCase) &&
                   controller.Equals(currentController, StringComparison.OrdinalIgnoreCase) &&
                   action.Equals(currentAction, StringComparison.OrdinalIgnoreCase);
        }
    }
}
