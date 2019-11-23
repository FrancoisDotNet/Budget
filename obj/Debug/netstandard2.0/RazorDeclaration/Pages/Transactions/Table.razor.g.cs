#pragma checksum "c:\Users\franc\OneDrive\Repos\Budget\Pages\Transactions\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62916264175b1a1a84e968934d6a96008363a50"
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
#line 1 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#line 2 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 3 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "c:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Budget;

#line default
#line hidden
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 30 "c:\Users\franc\OneDrive\Repos\Budget\Pages\Transactions\Table.razor"
       
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
#pragma warning restore 1591
