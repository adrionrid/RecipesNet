#pragma checksum "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b75cce35533c069b6423aa23fdd18907f4b46a89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipesNet.Pages.Ingredients.Pages_Ingredients_Index), @"mvc.1.0.razor-page", @"/Pages/Ingredients/Index.cshtml")]
namespace RecipesNet.Pages.Ingredients
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
#line 1 "C:\Games\VSprojects\RecipesNet\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\VSprojects\RecipesNet\Pages\_ViewImports.cshtml"
using RecipesNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Games\VSprojects\RecipesNet\Pages\_ViewImports.cshtml"
using RecipesNet.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75cce35533c069b6423aa23fdd18907f4b46a89", @"/Pages/Ingredients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9cedc82da66f9e449d1dfcda675d07e451d9ade", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ingredients_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover; height:8rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Ingredient image not found."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
  
    ViewData["Title"] = Html.DisplayNameFor(model => model.Ingredient);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
Write(await Html.PartialAsync("_Title", "Ingredients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<style>\r\n    .card {\r\n        min-width: 16rem;\r\n    }\r\n</style>\r\n\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 17 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
     foreach (var item in Model.Ingredient)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-secondary my-3\">\r\n            <div class=\"card-header text-dark\">\r\n                <div class=\"d-flex justify-content-between\">\r\n                    <h5 class=\"card-title\">\r\n                        ");
#nullable restore
#line 23 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                    ");
#nullable restore
#line 25 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
               Write(await Html.PartialAsync("_EditDeleteButtonGroup", item.Id.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <h6 class=\"card-subtitle small border-bottom\">\r\n                    ");
#nullable restore
#line 28 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Type.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h6>\r\n            </div>\r\n            <div class=\"card-body table-light p-0\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b75cce35533c069b6423aa23fdd18907f4b46a896463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1060, "~/img/Ingredients/", 1060, 18, true);
#nullable restore
#line 32 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
AddHtmlAttributeValue("", 1078, Html.DisplayFor(modelItem => item.Id), 1078, 40, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1118, ".jpg", 1118, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("}\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p class=\"card-text text-justify p-3\">\r\n                    ");
#nullable restore
#line 34 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"card-footer p-0\">\r\n                ");
#nullable restore
#line 38 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnergyValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 44 "C:\Games\VSprojects\RecipesNet\Pages\Ingredients\Index.cshtml"
Write(Html.DisplayFor(x => x.Ingredient.Pagination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesNet.Pages.Ingredients.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Pages.Ingredients.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Pages.Ingredients.IndexModel>)PageContext?.ViewData;
        public RecipesNet.Pages.Ingredients.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
