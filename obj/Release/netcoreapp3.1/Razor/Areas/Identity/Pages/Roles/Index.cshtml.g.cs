#pragma checksum "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be9e12a9aaee8927ac7877b78e26af540254796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Roles_Index), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Roles/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\_ViewImports.cshtml"
using RecipesNet.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\_ViewImports.cshtml"
using RecipesNet.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be9e12a9aaee8927ac7877b78e26af540254796", @"/Areas/Identity/Pages/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ac5799cb14c85f9e545d0f53400445450473b0", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Roles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
  
    ViewData["Title"] = "Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
Write(await Html.PartialAsync("_Title", "Roles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"col-1\"></th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Roles[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
         foreach (var item in Model.Roles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
               Write(await Html.PartialAsync(RecipesNet.Models.Content.Buttons.Delete, item.Id.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Roles\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesNet.Areas.Identity.Pages.Roles.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Areas.Identity.Pages.Roles.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Areas.Identity.Pages.Roles.IndexModel>)PageContext?.ViewData;
        public RecipesNet.Areas.Identity.Pages.Roles.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591