namespace Example.Web.Infrastructure
{
    using Example.Web.Infrastructure.Http;

    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc;

    public static class UrlHelperExtensions
    {
        public static HtmlString ReplaceQuery(this IUrlHelper helper, string key, string value) =>
            new(helper.ActionContext.HttpContext.Request.Query.Replace(key, value));
    }
}
