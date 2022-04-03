using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.CustomTags
{
    public class Roller : TagHelper
    {
        public string direction { get; set; }
        public string speed { get; set; }
        public string text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           
            output.TagName = "marquee";
            output.Attributes.SetAttribute("direction",direction);
            output.Attributes.SetAttribute("scrollamount", speed);
            output.Content.SetContent(text);
        }
    }
}
