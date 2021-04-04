namespace Example.Web.Infrastructure.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement(Attributes = ConditionAttributeName)]
    public sealed class ConditionTagHelper : TagHelper
    {
        private const string ConditionAttributeName = "i-if";

        [HtmlAttributeName(ConditionAttributeName)]
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}
