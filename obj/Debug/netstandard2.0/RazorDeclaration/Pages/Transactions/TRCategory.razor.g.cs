#pragma checksum "c:\Users\franc\OneDrive\Repos\Budget\Pages\Transactions\TRCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f571ae6a1985ff7181750b0b06d401bc47b06c5"
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
    public partial class TRCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 14 "c:\Users\franc\OneDrive\Repos\Budget\Pages\Transactions\TRCategory.razor"
       
    [CascadingParameter] Table Table { get; set; }

    [Parameter] public IGrouping<string, Transaction> Category { get; set; }

    public void Changed() => StateHasChanged();

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService storage { get; set; }
    }
}
#pragma warning restore 1591