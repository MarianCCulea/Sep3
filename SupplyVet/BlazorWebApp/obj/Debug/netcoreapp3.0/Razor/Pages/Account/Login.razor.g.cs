#pragma checksum "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Account\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6fdcd8576d9649120a595835e7a0d9a3b0b61d3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebApp.Pages.Account
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
#line 2 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Account\Login.razor"
using BlazorWebApp.Model.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>User name:</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "user name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Account\Login.razor"
                                                            _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<label>Password</label>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "password");
            __builder.AddAttribute(17, "placeholder", "password");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Account\Login.razor"
                                                               _password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Account\Login.razor"
                                          PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Login");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Sprite\Desktop\SEP3\SemesterProject3\BlazorWebApp\Pages\Account\Login.razor"
       

    private string _username;
    private string _password;

    public async Task PerformLogin()
    {
         

        var interop = new Interop(JsRuntime);
        string antiforgerytoken = await interop.GetElementByName("__RequestVerificationToken");

        // Here I provide fields matching the arguments of my login method, in LoginRequester.cshtml.cs
        var fields = new { __RequestVerificationToken = antiforgerytoken, username = _username, password = _password };

        // Here I make a call to the loginRequester.cshtml.cs, the post method, with fields as argument.
        // it happens through the Interop.cs class
        await interop.SubmitForm("/loginRequester/", fields);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData UserData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591