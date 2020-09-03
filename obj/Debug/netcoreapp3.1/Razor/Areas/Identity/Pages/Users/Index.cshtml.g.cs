#pragma checksum "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c7e391dc29b2f7519dedb1ee28b559c02a94f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Users_Index), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c7e391dc29b2f7519dedb1ee28b559c02a94f4", @"/Areas/Identity/Pages/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ac5799cb14c85f9e545d0f53400445450473b0", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container text-center mb-3 bg-white rounded-pill border-bottom border-light"">
    <h1 class=""text-capitalize text-dark font-weight-bold"">
        Users
    </h1>
</div>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th>

            </th>
            <th>
                ");
#nullable restore
#line 17 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Users[0].UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Users[0].Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Roles[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
         foreach (var item in Model.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\"", 783, "\"", 838, 1);
#nullable restore
#line 30 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
WriteAttributeValue("", 791, item.EmailConfirmed ? "" : "table-secondary", 791, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td class=\"col-1 btn-group btn-block\">\r\n                ");
#nullable restore
#line 32 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(await Html.PartialAsync(RecipesNet.Models.Content.Buttons.Delete, item.Id.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(await Html.PartialAsync(RecipesNet.Models.Content.Buttons.Edit, item.Id.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 42 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
                 foreach (var role in Model.GetIdentityRole(item).Result)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        ");
#nullable restore
#line 45 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
                   Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Games\VSprojects\RecipesNet\Areas\Identity\Pages\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesNet.Areas.Identity.Pages.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Areas.Identity.Pages.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Areas.Identity.Pages.Users.IndexModel>)PageContext?.ViewData;
        public RecipesNet.Areas.Identity.Pages.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591