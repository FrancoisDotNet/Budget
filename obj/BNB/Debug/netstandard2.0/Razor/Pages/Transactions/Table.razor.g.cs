#pragma checksum "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37bb5be1c8c83972834d409a513dbc20b021607e"
// <auto-generated/>
#pragma warning disable 1591
namespace Budget.Pages.Transactions
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#line 2 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 3 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
using Budget;

#line default
#line hidden
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-dark table-hover");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddAttribute(4, "class", "thead-dark");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "th");
            __builder.AddAttribute(9, "scope", "col");
            __builder.AddContent(10, 
#line 4 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                             Data

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "th");
            __builder.AddAttribute(13, "scope", "col");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddContent(15, 
#line 6 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.AddMonths(-1).ToString("MMM"))

#line default
#line hidden
            );
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "th");
            __builder.AddAttribute(19, "scope", "col");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddContent(21, 
#line 9 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("MMM"))

#line default
#line hidden
            );
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "th");
            __builder.AddAttribute(25, "scope", "col");
            __builder.AddAttribute(26, "class", "text-right");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", (
#line 12 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                                UnHideAndHide[1]

#line default
#line hidden
            ) + " btn" + " btn-light" + " oi" + " oi-pencil");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                                                                                        Edit

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", (
#line 13 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                             UnHideAndHide[0]

#line default
#line hidden
            ) + " btn-group");
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger oi oi-x");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                                                                      Edit

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-success oi oi-check");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                                                                           Save

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "tbody");
            __builder.AddMarkupContent(48, "\r\n        ");
            __Blazor.Budget.Pages.Transactions.Table.TypeInference.CreateCascadingValue_0(__builder, 49, 50, 
#line 21 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                               this

#line default
#line hidden
            , 51, (__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n");
#line 22 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
             foreach (var category in Categories)
            {

#line default
#line hidden
                __builder2.AddContent(53, "                ");
                __builder2.OpenComponent<Budget.Pages.Transactions.TRCategory>(54);
                __builder2.AddAttribute(55, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.IGrouping<System.String, Budget.Pages.Transactions.Transaction>>(
#line 24 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
                                      category

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n");
#line 25 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
            }

#line default
#line hidden
                __builder2.AddContent(57, "        ");
            }
            );
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 30 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\Table.razor"
       
    [CascadingParameter(Name="data")] public string Data { get; set; }

    public List<Transaction> Transactions { get; set; }
    public IEnumerable<IGrouping<string, Transaction>> Categories { get; set; }
    public string[] UnHideAndHide { get; set; } = { "d-none", "" };

    void Edit()
    {
        UnHideAndHide[0] = UnHideAndHide[0] == "" ? "d-none" : "";
        UnHideAndHide[1] = UnHideAndHide[1] == "" ? "d-none" : "";
    }

    void Save()
    {
        storage.SetItem(Data, Transactions);
    }

    protected override void OnParametersSet()
    {
        List<Transaction> stored = storage.GetItem<List<Transaction>>(Data);
        Console.WriteLine(stored is null ? "null" : "exist");
        Transactions = stored is null ? new List<Transaction>() : stored;
        Transactions.Add(
            new Transaction() { Category = "", Title = "", LastMonth = 0, ThisMonth = 0, IsDone = false });
        Categories = Transactions.OrderBy(t => t.Category).ThenBy(t => t.Title).GroupBy(t => t.Category);
    }

    public void Changed()
    {
        OnParametersSet();
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService storage { get; set; }
    }
}
namespace __Blazor.Budget.Pages.Transactions.Table
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
    }
}
#pragma warning restore 1591
