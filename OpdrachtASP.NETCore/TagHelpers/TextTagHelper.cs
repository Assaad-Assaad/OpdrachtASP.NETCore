using Microsoft.AspNetCore.Razor.TagHelpers;

namespace OpdrachtASP.NETCore.TagHelpers
{
    [HtmlTargetElement("lorem")]
    public class TextTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            output.Content.AppendHtml("Lorem ipsum dolor sit amet, consectetur adipiscing elit...");
        }
    }
}
