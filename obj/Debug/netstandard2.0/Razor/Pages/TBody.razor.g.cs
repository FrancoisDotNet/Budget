#pragma checksum "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31441fd22405187e4525bffbfc70d13a8defb862"
// <auto-generated/>
#pragma warning disable 1591
namespace Budget.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Budget;

#line default
#line hidden
#line 7 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Budget.Pages;

#line default
#line hidden
    public partial class TBody : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tbody");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "tr");
            __builder.AddAttribute(3, "class", (
#line 2 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                Body.Hidden[1]

#line default
#line hidden
            ) + " btn-primary" + " active");
            __builder.AddAttribute(4, "style", "font-weight: bold");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<td class=\"text-left\">Total</td>\r\n        ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
              Body.Transactions.Where(t => t.IsIncome).Sum(t => t.LastMonth) - Body.Transactions.Where(t => t.IsIncome == false).Sum(t => t.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#line 5 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
              Body.Transactions.Where(t => t.IsIncome).Sum(t => t.ThisMonth) - Body.Transactions.Where(t => t.IsIncome == false).Sum(t => t.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        <td></td>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "class", (
#line 8 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                Body.Hidden[1]

#line default
#line hidden
            ) + " btn-success" + " active");
            __builder.AddAttribute(16, "style", "font-weight: bold");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.AddMarkupContent(18, "<td class=\"text-left\">Income</td>\r\n        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#line 10 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
              Body.Transactions.Where(t => t.IsIncome).Sum(e => e.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#line 11 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
              Body.Transactions.Where(t => t.IsIncome).Sum(e => e.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        <td></td>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#line 14 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
     foreach (var category in Income)
    {

#line default
#line hidden
            __builder.AddContent(26, "        ");
            __builder.OpenElement(27, "tr");
            __builder.AddAttribute(28, "class", (
#line 16 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                    Body.Hidden[1]

#line default
#line hidden
            ) + " btn-success" + " ");
            __builder.AddAttribute(29, "style", "font-weight: bold");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "class", "text-left");
            __builder.AddContent(33, 
#line 17 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                                   category.Key

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#line 18 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                  category.Sum(e => e.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#line 19 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                  category.Sum(e => e.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            <td></td>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#line 22 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
         foreach (var transaction in category)
        {

#line default
#line hidden
            __builder.AddContent(42, "            ");
            __Blazor.Budget.Pages.TBody.TypeInference.CreateCascadingValue_0(__builder, 43, 44, 
#line 24 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                                   this

#line default
#line hidden
            , 45, (__builder2) => {
                __builder2.OpenComponent<Budget.Pages.TR>(46);
                __builder2.AddAttribute(47, "Transaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Budget.Pages.Transaction>(
#line 24 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                                                          transaction

#line default
#line hidden
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(48, "\r\n");
#line 25 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
        }

#line default
#line hidden
#line 25 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
         
    }

#line default
#line hidden
            __builder.AddContent(49, "    ");
            __builder.OpenElement(50, "tr");
            __builder.AddAttribute(51, "class", (
#line 27 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                Body.Hidden[1]

#line default
#line hidden
            ) + " btn-danger" + " active");
            __builder.AddAttribute(52, "style", "font-weight: bold");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.AddMarkupContent(54, "<td class=\"text-left\">Expenses</td>\r\n        ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#line 29 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
              Body.Transactions.Where(t => t.IsIncome == false).Sum(e => e.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#line 30 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
              Body.Transactions.Where(t => t.IsIncome == false).Sum(e => e.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        <td></td>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#line 33 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
     foreach (var category in Expense)
    {

#line default
#line hidden
            __builder.AddContent(62, "        ");
            __builder.OpenElement(63, "tr");
            __builder.AddAttribute(64, "class", (
#line 35 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                    Body.Hidden[1]

#line default
#line hidden
            ) + " btn-danger");
            __builder.AddAttribute(65, "style", "font-weight: bold");
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "class", "text-left");
            __builder.AddContent(69, 
#line 36 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                                   category.Key

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#line 37 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                  category.Sum(e => e.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#line 38 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                   category.Sum(e => e.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            <td></td>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#line 41 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
         foreach (var transaction in category)
        {

#line default
#line hidden
            __builder.AddContent(78, "            ");
            __Blazor.Budget.Pages.TBody.TypeInference.CreateCascadingValue_1(__builder, 79, 80, 
#line 43 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                                   this

#line default
#line hidden
            , 81, (__builder2) => {
                __builder2.OpenComponent<Budget.Pages.TR>(82);
                __builder2.AddAttribute(83, "Transaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Budget.Pages.Transaction>(
#line 43 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
                                                          transaction

#line default
#line hidden
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(84, "\r\n");
#line 44 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
        }

#line default
#line hidden
#line 44 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
         
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 48 "C:\Users\franc\OneDrive\Repos\Budget\Pages\TBody.razor"
       
    [CascadingParameter] Body Body { get; set; }

    public IEnumerable<IGrouping<string, Transaction>> Income { get; set; }
    public IEnumerable<IGrouping<string, Transaction>> Expense { get; set; }
    
    protected override void OnParametersSet()
    {
        Income = Body.Transactions.Where(t => t.IsIncome).OrderBy(t => t.Category).ThenBy(t => t.Title).GroupBy(t => t.Category);
        Expense = Body.Transactions.Where(t => t.IsIncome == false).OrderBy(t => t.Category).ThenBy(t => t.Title).GroupBy(t => t.Category);
    }

#line default
#line hidden
    }
}
namespace __Blazor.Budget.Pages.TBody
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
