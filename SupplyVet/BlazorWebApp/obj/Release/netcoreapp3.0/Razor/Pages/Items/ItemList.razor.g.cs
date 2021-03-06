#pragma checksum "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "652dd96a9b34b356861bf75309d35866fadf70c0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebApp.Pages.Items
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
#line 2 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
using BlazorWebApp.Model.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
           [Authorize(Policy = "MustBeProvider")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/items")]
    public class ItemList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>ItemList</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/additem\">Add new item</a>\r\n</p>\r\n<br>");
            __builder.AddMarkupContent(2, "<span id=\"resultJson\">\r\n</span>\r\n\r\n");
            __builder.OpenElement(3, "form");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "p");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "asp-for", "Category");
            __builder.AddAttribute(9, "asp-items", "Model.Genres");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", true);
            __builder.AddContent(13, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        Title: <input type=\"text\" asp-for=\"SearchString\">\r\n        <input type=\"submit\" value=\"Filter\">\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, @"<thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                Category
            </th>
            <th>
                Price
            </th>
            <th>
                Items in stock
            </th>
            <th>Actions</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(22, "tbody");
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 48 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
         foreach (var item in items)
        {
            var id = item.id;
            var nam = item.name;

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddContent(29, 
#nullable restore
#line 54 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                     item.id

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
#line 57 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                     item.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.AddContent(39, 
#nullable restore
#line 60 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                     item.category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddContent(44, 
#nullable restore
#line 63 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                     item.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddContent(49, 
#nullable restore
#line 66 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                     item.nrofitems

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "href", 
#nullable restore
#line 69 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                              $"/items/{item.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(56, "alt", "Edit");
            __builder.AddContent(57, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, " /\r\n                    ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn-danger");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                                                         () => ConfirmDelete(id,nam)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 74 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal");
            __builder.AddAttribute(71, "id", "myModal");
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "modal-dialog");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-content");
            __builder.AddMarkupContent(78, "\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(79, "<div class=\"modal-header\">\r\n                <h4 class=\"modal-title\">Confirm delete</h4>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n            </div>\r\n\r\n            \r\n            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "modal-body");
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "hidden");
            __builder.AddAttribute(85, "id", "itemname");
            __builder.AddAttribute(86, "bind", 
#nullable restore
#line 90 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                                                         DeleteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                Are you sure you want to delete item <span id=\"itemname\"></span>?\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n            \r\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "modal-footer");
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.AddMarkupContent(92, "<button type=\"button\" class=\"btn\" data-dismiss=\"modal\">Cancel</button>\r\n                ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "type", "button");
            __builder.AddAttribute(95, "class", "btn btn-danger");
            __builder.AddAttribute(96, "onclick", 
#nullable restore
#line 97 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
                                                                      DeleteItem

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(97, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Items\ItemList.razor"
       
    private int DeleteId;
    private string DeleteItem;
    private IList<Item> items
    { get; set; }
    private User user;
    protected override async Task OnInitializedAsync()
    {
        items = await DataLayer.RequestAllItemsAsync();
    }

    protected async Task ConfirmDelete(int id ,string name)
    {
        bool confirmed = await jsRuntime.InvokeAsync<bool>("confirm", "Are you sure u want to delete item " + name + " ?");
        if (confirmed)
        {

            var response=await DataLayer.DeleteItem(id);
             items = await DataLayer.RequestAllItemsAsync();
            await jsRuntime.InvokeVoidAsync("setElementTextById", "resultJson", response);
        }
        else
        {

        }
    }

    protected async Task DeleteBook()
    {


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataLayer DataLayer { get; set; }
    }
}
#pragma warning restore 1591
