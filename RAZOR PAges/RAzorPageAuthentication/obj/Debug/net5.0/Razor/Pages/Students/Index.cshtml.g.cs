#pragma checksum "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "607d7c86a152d31d5dd5d7c08f9d8b7371ff9fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Students_Index), @"mvc.1.0.razor-page", @"/Pages/Students/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607d7c86a152d31d5dd5d7c08f9d8b7371ff9fe5", @"/Pages/Students/Index.cshtml")]
    public class Pages_Students_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
 foreach (var item in Model.Student) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 800, "\"", 823, 1);
#nullable restore
#line 31 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
WriteAttributeValue("", 815, item.Id, 815, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 876, "\"", 899, 1);
#nullable restore
#line 32 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
WriteAttributeValue("", 891, item.Id, 891, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 954, "\"", 977, 1);
#nullable restore
#line 33 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
WriteAttributeValue("", 969, item.Id, 969, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "D:\Krimal\ASP .NET CORE MVC\RAZOR PAges\RAzorPageAuthentication\Pages\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAzorPageAuthentication.Pages.Students.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RAzorPageAuthentication.Pages.Students.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RAzorPageAuthentication.Pages.Students.IndexModel>)PageContext?.ViewData;
        public RAzorPageAuthentication.Pages.Students.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
