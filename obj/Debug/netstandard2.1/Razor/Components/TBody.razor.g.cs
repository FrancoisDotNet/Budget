<<<<<<< HEAD
#pragma checksum "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb1ff38aedc6cc0179843ec5876314d1b2c68a0"
=======
#pragma checksum "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb1ff38aedc6cc0179843ec5876314d1b2c68a0"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
// <auto-generated/>
#pragma warning disable 1591
namespace Budget.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
<<<<<<< HEAD
#nullable restore
#line 1 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
=======
#line 1 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
#nullable restore
#line 2 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
=======
#line 2 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
using System.Globalization;

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
#nullable restore
#line 3 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
=======
#line 3 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
using Budget.Models;

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
#nullable restore
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\_Imports.razor"
=======
#line 4 "c:\Users\meyerf\Downloads\dev\repos\Budget\_Imports.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
using Budget.Components;

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
    public partial class TBody : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tbody");
            __builder.AddAttribute(1, "class", 
<<<<<<< HEAD
#nullable restore
#line 1 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 1 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                Body.IsTransfer ? "d-none" : ""

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddAttribute(4, "class", (
<<<<<<< HEAD
#nullable restore
#line 2 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 2 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                 Body.IsEdit ? "d-none" : ""

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            ) + " btn-primary" + " active");
            __builder.AddAttribute(5, "style", "font-weight: bold");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<td class=\"text-left\">Total</td>\r\n        ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
<<<<<<< HEAD
#nullable restore
#line 4 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 4 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
             Body.Budget.Total()[0].ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
<<<<<<< HEAD
#nullable restore
#line 5 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 5 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
             Body.Budget.Total()[1].ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "tr");
            __builder.AddAttribute(16, "class", (
<<<<<<< HEAD
#nullable restore
#line 7 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 7 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                 Body.IsEdit ? "d-none" : ""

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            ) + " btn-primary" + " active");
            __builder.AddAttribute(17, "style", "font-weight: bold");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<td class=\"text-left\">Balance</td>\r\n        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
<<<<<<< HEAD
#nullable restore
#line 9 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 9 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
             Body.Budget.Balance()[0].ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
<<<<<<< HEAD
#nullable restore
#line 10 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 10 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
             Body.Budget.Balance()[1].ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
<<<<<<< HEAD
#nullable restore
#line 12 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 12 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
     for (int i = 0; i < 2; i++)
    {

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.OpenElement(28, "tr");
            __builder.AddAttribute(29, "class", (
#nullable restore
#line 14 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            __builder.AddContent(27, "        ");
            __builder.OpenElement(28, "tr");
            __builder.AddAttribute(29, "class", (
#line 14 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                     Body.IsEdit ? "d-none" : ""

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            ) + " btn-" + (
#nullable restore
#line 14 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            ) + " btn-" + (
#line 14 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                                                        i == 0 ? "success" : "danger"

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            ) + " active");
            __builder.AddAttribute(30, "style", "font-weight: bold");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.AddMarkupContent(32, "<td class=\"text-left\">Income</td>\r\n            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
<<<<<<< HEAD
#nullable restore
#line 16 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 16 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                 Body.Budget.Categories()[i].Sum(c => c.Sum(t => t.Previous)).ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
<<<<<<< HEAD
#nullable restore
#line 17 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 17 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                 Body.Budget.Categories()[i].Sum(c => c.Sum(t => t.Current)).ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
<<<<<<< HEAD
#nullable restore
#line 19 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 19 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
         foreach (var category in Body.Budget.Categories()[i])
        {

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.OpenElement(41, "tr");
            __builder.AddAttribute(42, "class", (
#nullable restore
#line 21 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            __builder.AddContent(40, "            ");
            __builder.OpenElement(41, "tr");
            __builder.AddAttribute(42, "class", (
#line 21 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                         Body.IsEdit ? "d-none" : ""

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            ) + " btn-" + (
#nullable restore
#line 21 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            ) + " btn-" + (
#line 21 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                                                            i == 0 ? "success" : "danger"

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            ));
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "class", "text-left");
            __builder.AddContent(46, 
<<<<<<< HEAD
#nullable restore
#line 22 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 22 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                                       category.Key

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
<<<<<<< HEAD
#nullable restore
#line 23 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 23 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                      category.Sum(e => e.Previous).ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
<<<<<<< HEAD
#nullable restore
#line 24 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 24 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                      category.Sum(e => e.Current).ToString("C")

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
<<<<<<< HEAD
#nullable restore
#line 26 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 26 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
             foreach (var transaction in category)
            {

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            __builder.AddContent(55, "                ");
            __Blazor.Budget.Components.TBody.TypeInference.CreateCascadingValue_0(__builder, 56, 57, 
#nullable restore
#line 28 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            __builder.AddContent(55, "                ");
            __Blazor.Budget.Components.TBody.TypeInference.CreateCascadingValue_0(__builder, 56, 57, 
#line 28 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                                       this

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            , 58, (__builder2) => {
                __builder2.OpenComponent<Budget.Components.TR>(59);
                __builder2.AddAttribute(60, "Transaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Budget.Models.Transaction>(
#nullable restore
#line 28 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            , 58, (__builder2) => {
                __builder2.OpenComponent<Budget.Components.TR>(59);
                __builder2.AddAttribute(60, "Transaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Budget.Models.Transaction>(
#line 28 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                                                              transaction

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(61, "\r\n");
<<<<<<< HEAD
#nullable restore
#line 29 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 29 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
            }

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
#nullable restore
#line 29 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 29 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
             
        }

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
#nullable restore
#line 30 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
#line 30 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
         
    }

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\franc\OneDrive\Repos\Budget\Components\TBody.razor"
=======
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 34 "c:\Users\meyerf\Downloads\dev\repos\Budget\Components\TBody.razor"
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
        [CascadingParameter] Body Body { get; set; } 

#line default
#line hidden
<<<<<<< HEAD
#nullable disable
=======
>>>>>>> 806b58afa15ce6b7400905aca3a75790b6e2b441
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService service { get; set; }
    }
}
namespace __Blazor.Budget.Components.TBody
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
