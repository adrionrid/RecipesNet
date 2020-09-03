#pragma checksum "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f429c8b0831310f9fb24f773920109e90e279169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipesNet.Pages.Recipes.Pages_Recipes_Details), @"mvc.1.0.razor-page", @"/Pages/Recipes/Details.cshtml")]
namespace RecipesNet.Pages.Recipes
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
#nullable restore
#line 3 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
using RecipesNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f429c8b0831310f9fb24f773920109e90e279169", @"/Pages/Recipes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9cedc82da66f9e449d1dfcda675d07e451d9ade", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img rounded rounded-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
  
    ViewData["Title"] = Html.DisplayFor(model => model.Recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .card {
        max-width: 48rem;
    }
</style>

<div class=""d-flex justify-content-center"">
    <div class=""card border-light text-decoration-none text-dark"">
        <div class=""flex-column mx-3"">
            <div class=""d-flex justify-content-between border-bottom mb-2"">
                <div>
                    <div class=""text-left small"">
                        ");
#nullable restore
#line 20 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Recipe.DishType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ·\r\n                        ");
#nullable restore
#line 22 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Recipe.Cuisine.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Recipe.Cuisine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 843, "\"", 851, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h1 class=\"card-title\">\r\n                            ");
#nullable restore
#line 27 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Recipe.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h1>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 32 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
               Write(await Html.PartialAsync("_EditDeleteButtonGroup", Model.Recipe.Id.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"card-body table-light p-0 small\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f429c8b0831310f9fb24f773920109e90e2791697064", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1375, "~/img/Recipes/", 1375, 14, true);
#nullable restore
#line 36 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
AddHtmlAttributeValue("", 1389, Model.Recipe.Id, 1389, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1407, ".jpg", 1407, 4, true);
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
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 39 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
           Write(Html.DisplayFor(model => model.EnergyValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-text text-justify py-4\">\r\n                <h5>\r\n                    ");
#nullable restore
#line 43 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
               Write(Html.DisplayNameFor(x => x.Recipe.Ingredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h5>\r\n                <div class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 46 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                     foreach (var item in Model.Recipe.Ingredients)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"list-group-item d-flex flex-row justify-content-between\">\r\n                            <div>\r\n                                ");
#nullable restore
#line 50 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                           Write(Html.DisplayFor(x => item.Ingredient.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                ");
#nullable restore
#line 53 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                           Write(Html.DisplayFor(x => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 54 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                           Write(Models.Content.Units.Gramm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 57 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"d-flex flex-column\">\r\n                <div class=\"d-flex flex-row justify-content-between\">\r\n                    <h5>\r\n                        ");
#nullable restore
#line 63 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                   Write(Html.DisplayNameFor(x => x.Recipe.Instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                    <h5>\r\n                        <i class=\"far fa-clock\"></i>\r\n                        ");
#nullable restore
#line 67 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Recipe.CookingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                </div>\r\n                <div class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 71 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                     foreach (var item in Model.Recipe.Instructions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"list-group-item text-justify py-2\">\r\n                            ");
#nullable restore
#line 74 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                        Write(Model.Recipe.Instructions.IndexOf(item) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n                            ");
#nullable restore
#line 75 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                       Write(Html.DisplayFor(x => item.Entry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 77 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesNet.Pages.Recipes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Pages.Recipes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesNet.Pages.Recipes.DetailsModel>)PageContext?.ViewData;
        public RecipesNet.Pages.Recipes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
