#pragma checksum "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7bf32b66806649847d2eb38b69236f75b6a419"
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
using System.Globalization;

#line default
#line hidden
#line 2 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 3 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
using Budget;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "bg-secondary" + " navbar" + " btn-group" + " " + (
#line 3 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                                           Hidden[1]

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "style", "padding:12px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                      Home

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "class", "btn" + " btn-outline-dark" + " oi" + " oi-home" + " " + (
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                                                                    Active[0]

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                      Expense

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "class", "btn" + " btn-outline-dark" + " oi" + " oi-thumb-down" + " " + (
#line 5 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                                                                             Active[1]

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                      Income

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "class", "btn" + " btn-outline-dark" + " oi" + " oi-thumb-up" + " " + (
#line 6 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                                                                          Active[2]

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "article");
            __builder.AddAttribute(18, "class", 
#line 9 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                  Active[2] == "active" ? "d-none" : ""

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\r\n    ");
            __Blazor.Budget.Pages.Index.TypeInference.CreateCascadingValue_0(__builder, 20, 21, 
#line 10 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                           this

#line default
#line hidden
            , 22, (__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Budget.Pages.Budgets>(24);
                __builder2.AddAttribute(25, "Data", "Expense");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "article");
            __builder.AddAttribute(30, "class", 
#line 14 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                  Active[1] is "active" ? "d-none" : ""

#line default
#line hidden
            );
            __builder.AddMarkupContent(31, "\r\n    ");
            __Blazor.Budget.Pages.Index.TypeInference.CreateCascadingValue_1(__builder, 32, 33, 
#line 15 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
                           this

#line default
#line hidden
            , 34, (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<Budget.Pages.Budgets>(36);
                __builder2.AddAttribute(37, "Data", "Income");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\Users\franc\OneDrive\Repos\Budget\Pages\Index.razor"
       
    public string[] Hidden { get; set; } = { "d-none", "" };
    public string[] Active = new string[] {"active", "", ""};

    void Home() => Active = new string[] {"active", "", ""};

    void Expense() => Active = new string[] {"", "active", ""};

    void Income() => Active = new string[] {"", "", "active"};

    public void Hide()
    {
        Hidden = Hidden[0] is "" ? new string[] {"d-none", "" } : new string[] {"", "d-none" } ;
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService storage { get; set; }
    }
}
namespace __Blazor.Budget.Pages.Index
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
