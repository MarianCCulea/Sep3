#pragma checksum "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89e7e4f965ddca50fae019120f6b729a2a4ec88"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebApp.Pages.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using BlazorWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\_Imports.razor"
using BlazorWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
using BlazorWebApp.Model.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
           [Authorize(Policy = "MustBeProvider")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public class OrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>OrderList</h1>\r\n");
            __builder.AddMarkupContent(1, "<span>Request result:</span>");
            __builder.AddMarkupContent(2, "<span id=\"result\">\r\n</span>\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, @"<thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Adress
            </th>
            <th>
                Invoice Adress
            </th>
            <th>
                Phone
            </th>
            <th>
                Total Price
            </th>
            <th>Delivered Status</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 32 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
         foreach (var order in orders)
        {
            var id = order.id;

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.AddContent(14, 
#nullable restore
#line 37 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                     order.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddContent(19, 
#nullable restore
#line 40 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                     order.adress

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddContent(24, 
#nullable restore
#line 43 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                     order.invoiceadress

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddContent(29, 
#nullable restore
#line 46 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                     order.phone

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.AddContent(34, 
#nullable restore
#line 49 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                     order.totalprice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, ";-\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(39);
            __builder.AddAttribute(40, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                                      order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 52 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                                                              ()=>ValidSubmit(order)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.AddMarkupContent(44, "<label for=\"delivered\">Delivered</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(45);
                __builder2.AddAttribute(46, "id", "delivered");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
                                                                   order.delivered

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.delivered = __value, order.delivered))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => order.delivered));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.AddMarkupContent(51, "<button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 59 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Orders\OrderList.razor"
       
    private IList<Order> orders
    { get; set; }

    protected override async Task OnInitializedAsync()
    {
        orders = await dataLayer.RequestAllOrdersAsync();
    }

    async Task ValidSubmit(Order order)
    {
        var response = await dataLayer.PutOrderAsync(order);
        orders = await dataLayer.RequestAllOrdersAsync();
        await jsRuntime.InvokeVoidAsync("setElementTextById", "result", response);


    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataLayer dataLayer { get; set; }
    }
}
#pragma warning restore 1591
