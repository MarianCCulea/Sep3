#pragma checksum "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b856eaee87992f926008b7dbc1122b48e4ae3bb8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebApp.Pages.Items
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
using BlazorWebApp.Model.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
using BlazorWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
           [Authorize(Policy = "MustBeProvider")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/additem")]
    public class AddItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add new item</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                  item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                        ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"name\">Name:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "Class", "form-control");
                __builder2.AddAttribute(16, "id", "name");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                               item.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.name = __value, item.name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 19 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label for=\"category\">Category:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "Class", "form-control");
                __builder2.AddAttribute(31, "id", "category");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                                   item.category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.category = __value, item.category))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 24 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.AddMarkupContent(43, "<label for=\"description\">Description:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(44);
                __builder2.AddAttribute(45, "Class", "form-control");
                __builder2.AddAttribute(46, "id", "description");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                                          item.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.description = __value, item.description))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 29 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.AddMarkupContent(58, "<label for=\"price\">Price:</label>\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateInputNumber_3(__builder2, 59, 60, "form-control", 61, "price", 62, 
#nullable restore
#line 33 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                                  item.price

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.price = __value, item.price)), 64, () => item.price);
                __builder2.AddMarkupContent(65, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_4(__builder2, 66, 67, 
#nullable restore
#line 34 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.AddMarkupContent(73, "<label for=\"url\">Picture Url:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "Class", "form-control");
                __builder2.AddAttribute(76, "id", "url");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                              item.url

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.url = __value, item.url))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.url));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_5(__builder2, 81, 82, 
#nullable restore
#line 39 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.url

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group");
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.AddMarkupContent(88, "<label for=\"quantity\">Item Quantity:</label>\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateInputNumber_6(__builder2, 89, 90, "form-control", 91, "quantity", 92, 
#nullable restore
#line 43 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                                     item.quantity

#line default
#line hidden
#nullable disable
                , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.quantity = __value, item.quantity)), 94, () => item.quantity);
                __builder2.AddMarkupContent(95, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_7(__builder2, 96, 97, 
#nullable restore
#line 44 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(98, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group");
                __builder2.AddMarkupContent(102, "\r\n        ");
                __builder2.AddMarkupContent(103, "<label for=\"quantitytype\">Quantity Type(please choose between ml , mg and ml/mg):</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "Class", "form-control");
                __builder2.AddAttribute(106, "id", "quantitytype");
                __builder2.AddAttribute(107, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                                       item.quantitytype

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.quantitytype = __value, item.quantitytype))));
                __builder2.AddAttribute(109, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.quantitytype));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_8(__builder2, 111, 112, 
#nullable restore
#line 49 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.quantitytype

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(113, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group");
                __builder2.AddMarkupContent(117, "\r\n        ");
                __builder2.AddMarkupContent(118, "<label for=\"nrofitems\">Items in stock:</label>\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateInputNumber_9(__builder2, 119, 120, "form-control", 121, "nrofitems", 122, 
#nullable restore
#line 53 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                                      item.nrofitems

#line default
#line hidden
#nullable disable
                , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.nrofitems = __value, item.nrofitems)), 124, () => item.nrofitems);
                __builder2.AddMarkupContent(125, "\r\n        ");
                __Blazor.BlazorWebApp.Pages.Items.AddItem.TypeInference.CreateValidationMessage_10(__builder2, 126, 127, 
#nullable restore
#line 54 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                  () => item.nrofitems

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(128, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n\r\n    ");
                __builder2.AddMarkupContent(130, "<h3 id=\"result\">\r\n    </h3>\r\n    ");
                __builder2.AddMarkupContent(131, "<button type=\"submit\" class=\"btn btn-primary\">Add Item</button><hr>\r\n    ");
                __builder2.OpenElement(132, "button");
                __builder2.AddAttribute(133, "class", "btn btn-secondary");
                __builder2.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(135, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\AddItem.razor"
       

    Item item = new Item();

    void BackToList()
    {
        NavigationManager.NavigateTo("/items");
    }

    void Cancel()
    {
        BackToList();
    }

    private async Task ValidSubmit()
    {
        var response=await dataLayer.PostItemAsync(item);
        if (response.Equals("false"))
        {
            await jsRuntime.InvokeVoidAsync("setElementTextById", "result", "Check values and try again.");
        }
        else
        {
            BackToList();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataLayer dataLayer { get; set; }
    }
}
namespace __Blazor.BlazorWebApp.Pages.Items.AddItem
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
