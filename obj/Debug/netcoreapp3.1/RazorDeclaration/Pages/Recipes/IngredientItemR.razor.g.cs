#pragma checksum "C:\Games\VSprojects\RecipesNet\Pages\Recipes\IngredientItemR.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354b7ddc6316718d67a5218c6121f426e3bdebbf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RecipesNet.Pages.Recipes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class IngredientItemR : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Games\VSprojects\RecipesNet\Pages\Recipes\IngredientItemR.razor"
       

    public string Name { get; set; } = "Jon";

    protected async Task AddItem()
    {
        if (Name == "Jon")
        {
            Name = "Susan";
        }
        else
        {
            Name = "Jon";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591