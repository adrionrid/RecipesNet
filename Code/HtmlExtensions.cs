using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecipesNet
{
    public static class HtmlExtensions
    {
        public static HtmlString Index(this IHtmlHelper html)
        {
            var prefix = html.ViewData.TemplateInfo.HtmlFieldPrefix;
            var m = Regex.Match(prefix, @".+\[(\d+)\]");
            if (m.Success && m.Groups.Count == 2)
                return new HtmlString(m.Groups[1].Value);
            return null;
        }
    }
}
