#pragma checksum "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66dbba212f31025249f334350db87ec86de6938"
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
#line 1 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#line 2 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 3 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Budget;

#line default
#line hidden
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-dark text-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddAttribute(4, "class", (
#line 2 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                   Index.Hidden[1]

#line default
#line hidden
            ) + " " + (
#line 2 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                     Index.Active[0] == "active" && Budgets.Data == "Income" ? "d-none" : ""

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "style", "background-color: rgba(255, 255, 255, 0.05)");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "th");
            __builder.AddAttribute(10, "scope", "col");
            __builder.AddAttribute(11, "style", "width:33.33%;padding-right:0");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                  Edit

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "class", "btn" + " btn-light" + " btn-block" + " oi" + " oi-pencil" + " " + (
#line 5 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                                                                      Index.Active[0] == "active" ? "d-none" : ""

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                  Settings

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "class", "btn" + " btn-light" + " btn-block" + " oi" + " oi-cog" + " " + (
#line 6 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                                                                       Index.Active[0] == "active" ? "" : "d-none"

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "th");
            __builder.AddAttribute(23, "scope", "col");
            __builder.AddAttribute(24, "class", true);
            __builder.AddAttribute(25, "style", "width:33.33%");
            __builder.AddContent(26, 
#line 8 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                                           Budgets.Months[0]

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "th");
            __builder.AddAttribute(29, "scope", "col");
            __builder.AddAttribute(30, "class", 
#line 9 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                    Index.Hidden[1]

#line default
#line hidden
            );
            __builder.AddAttribute(31, "style", "width:30%");
            __builder.AddContent(32, 
#line 9 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                                                        Budgets.Months[1]

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "th");
            __builder.AddAttribute(35, "scope", "col");
            __builder.AddAttribute(36, "class", 
#line 10 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                    Index.Hidden[1]

#line default
#line hidden
            );
            __builder.AddAttribute(37, "style", "width:3,33%");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "tbody");
            __builder.AddAttribute(42, "class", 
#line 13 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                    settings ? "d-none" : ""

#line default
#line hidden
            );
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "tr");
            __builder.AddAttribute(45, "class", (
#line 14 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                    Index.Hidden[1]

#line default
#line hidden
            ) + " " + (
#line 14 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                      Index.Active[0] == "active" && Budgets.Data == "Expense" ? "btn-primary" : "d-none"

#line default
#line hidden
            ));
            __builder.AddAttribute(46, "style", "font-weight: bold");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.AddMarkupContent(48, "<td class=\"text-left\">Total</td>\r\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#line 16 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                  (storage.GetItem<List<Transaction>>("Income") == null ? 0 : (storage.GetItem<List<Transaction>>("Income")).Sum(e => e.LastMonth)) - (Budgets.Transactions.Sum(e => e.LastMonth)) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#line 17 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                  (storage.GetItem<List<Transaction>>("Income") == null ? 0 : (storage.GetItem<List<Transaction>>("Income")).Sum(e => e.ThisMonth)) - (Budgets.Transactions.Sum(e => e.ThisMonth)) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            <td></td>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "tr");
            __builder.AddAttribute(57, "class", (
#line 20 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                    Index.Hidden[1]

#line default
#line hidden
            ) + " " + (
#line 20 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                      Index.Active[0] == "active" && Budgets.Data == "Expense" ? "btn-danger" : Index.Active[0] == "active" ? "btn-success" : "d-none"

#line default
#line hidden
            ));
            __builder.AddAttribute(58, "style", "font-weight: bold");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "class", "text-left");
            __builder.AddContent(62, 
#line 21 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                   Budgets.Data

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#line 22 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                  Budgets.Transactions.Sum(e => e.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#line 23 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                  Budgets.Transactions.Sum(e => e.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            <td></td>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#line 26 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
         foreach (var category in Categories)
        {

#line default
#line hidden
            __builder.AddContent(71, "            ");
            __builder.OpenElement(72, "tr");
            __builder.AddAttribute(73, "class", (
#line 28 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                        Index.Hidden[1]

#line default
#line hidden
            ) + " " + (
#line 28 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                          Index.Active[0] == "active" ? (Budgets.Data == "Expense" ? "alert-danger" : "alert-success") : ""

#line default
#line hidden
            ));
            __builder.AddAttribute(74, "style", "font-weight: bold");
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "class", "text-left");
            __builder.AddContent(78, 
#line 29 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                       category.Key

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#line 30 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                      category.Sum(e => e.LastMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#line 31 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                       category.Sum(e => e.ThisMonth) + " €"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                <td></td>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#line 34 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
             foreach (var transaction in category)
            {

#line default
#line hidden
            __builder.AddContent(87, "                ");
            __Blazor.Budget.Pages.Table.TypeInference.CreateCascadingValue_0(__builder, 88, 89, 
#line 36 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                       this

#line default
#line hidden
            , 90, (__builder2) => {
                __builder2.OpenComponent<Budget.Pages.TR>(91);
                __builder2.AddAttribute(92, "Transaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Budget.Pages.Transaction>(
#line 36 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                                                              transaction

#line default
#line hidden
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(93, "\r\n");
#line 37 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
            }

#line default
#line hidden
#line 37 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(94, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", 
#line 42 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
              settings ? "" : "d-none"

#line default
#line hidden
            );
            __builder.AddMarkupContent(99, "\r\n");
            __Blazor.Budget.Pages.Table.TypeInference.CreateCascadingValue_1(__builder, 100, 101, 
#line 43 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
                       this

#line default
#line hidden
            , 102, (__builder2) => {
                __builder2.OpenComponent<Budget.Pages.Settings>(103);
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(104, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 46 "c:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Table.razor"
       
    [CascadingParameter] Budgets Budgets { get; set; }
    [CascadingParameter] Index Index { get; set; }

    public IEnumerable<IGrouping<string, Transaction>> Categories { get; set; }
    bool settings = false;
    
    protected override void OnParametersSet() =>
        Categories = Budgets.Transactions.OrderBy(t => t.Category).ThenBy(t => t.Title).GroupBy(t => t.Category);
    
    void Settings ()
    {
        settings = !settings;
    }
    
    void Edit() => Index.Hide();

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService storage { get; set; }
    }
}
namespace __Blazor.Budget.Pages.Table
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
