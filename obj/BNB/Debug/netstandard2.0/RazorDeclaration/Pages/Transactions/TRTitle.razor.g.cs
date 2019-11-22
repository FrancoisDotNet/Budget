#pragma checksum "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\TRTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50eaefab087c061fd5f98de33332919091b66f8b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TRTitle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 33 "C:\Users\meyerf\Downloads\dev\repos\Budget\Pages\Transactions\TRTitle.razor"
       
    [CascadingParameter] Table Table { get; set; }
    [CascadingParameter] TRCategory TRCategory { get; set; }

    [Parameter] public Transaction Transaction { get; set; }

    private Transaction transaction;
    private string style, icon;

    protected override void OnParametersSet()
    {
        transaction = Transaction;
        style = Transaction.IsDone ? "info" : "outline-info";
        icon = Transaction.IsDone ? "check" : "x";
    }

    void Done()
    {
        style = style == "info" ? "info" : "outline-info";
        icon = icon == "check" ? "check" : "x";
        Transaction.IsDone = !Transaction.IsDone;

        Save();
    }


    void Delete()
    {
        Table.Transactions.Remove(Table.Transactions.Find(t => (t.Category == Transaction.Category) &&
            (t.Title == Transaction.Title) &&
            (t.LastMonth == Transaction.LastMonth) &&
            (t.ThisMonth == Transaction.ThisMonth)));
        Save();
    }

    void Update()
    {
        if (!string.IsNullOrWhiteSpace(transaction.Category) && !string.IsNullOrWhiteSpace(transaction.Title))
        {
            Delete();
            Table.Transactions.Add(transaction);
            Save();
        }
    }

    void Save()
    {
        Table.Transactions.RemoveAll(t => (t.Category == ""));
        Table.Changed();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService storage { get; set; }
    }
}
#pragma warning restore 1591
