#pragma checksum "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2488e52e4d9d17bf00280250f951548bc805f83e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipesNet.Pages.Shared.Pages_Shared__IngredientItem), @"mvc.1.0.view", @"/Pages/Shared/_IngredientItem.cshtml")]
namespace RecipesNet.Pages.Shared
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
#line 3 "C:\Games\VSprojects\RecipesNet\Pages\_ViewImports.cshtml"
using RecipesNet.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
using RecipesNet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2488e52e4d9d17bf00280250f951548bc805f83e", @"/Pages/Shared/_IngredientItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9cedc82da66f9e449d1dfcda675d07e451d9ade", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__IngredientItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<RecipesNet.Models.IngredientItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group input-group\">\r\n        <input type=\"hidden\" name=\"Model.Index\"");
            BeginWriteAttribute("value", " value=\"", 191, "\"", 207, 1);
#nullable restore
#line 7 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
WriteAttributeValue("", 199, item.Id, 199, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 241, "\"", 266, 3);
            WriteAttributeValue("", 248, "Model[", 248, 6, true);
#nullable restore
#line 8 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
WriteAttributeValue("", 254, item.Id, 254, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 262, "].Id", 262, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 267, "\"", 283, 1);
#nullable restore
#line 8 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
WriteAttributeValue("", 275, item.Id, 275, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"input-group-prepend\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2488e52e4d9d17bf00280250f951548bc805f83e5181", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Model[");
#nullable restore
#line 10 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("].IngredientId");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
AddHtmlAttributeValue("", 395, item.IngredientId, 395, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (IEnumerable<SelectListItem>)ViewBag.Ingredients;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <input");
            BeginWriteAttribute("name", " name=\"", 552, "\"", 583, 3);
            WriteAttributeValue("", 559, "Model[", 559, 6, true);
#nullable restore
#line 13 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
WriteAttributeValue("", 565, item.Id, 565, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 573, "].Quantity", 573, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 584, "\"", 606, 1);
#nullable restore
#line 13 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
WriteAttributeValue("", 592, item.Quantity, 592, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" />
        <div class=""input-group-append"">
            <button type=""button"" class=""btn btn-outline-danger form-control"" onclick=""$(this).parent().remove()"">
                <i class=""fas fa-trash""></i>
            </button>
        </div>
    </div>
");
#nullable restore
#line 20 "C:\Games\VSprojects\RecipesNet\Pages\Shared\_IngredientItem.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<RecipesNet.Models.IngredientItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
