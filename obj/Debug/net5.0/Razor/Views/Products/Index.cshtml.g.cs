#pragma checksum "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5db1f3da96718f3e2239034c64c1775ca66ae8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5db1f3da96718f3e2239034c64c1775ca66ae8c", @"/Views/Products/Index.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<N0855975_assessment2.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 279, "\"", 326, 1);
#nullable restore
#line 16 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
WriteAttributeValue("", 301, ViewData["NameSortParm"], 301, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
                                                                                 Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 552, "\"", 600, 1);
#nullable restore
#line 22 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
WriteAttributeValue("", 574, ViewData["PriceSortParm"], 574, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
                                                                                  Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1523, "\"", 1546, 1);
#nullable restore
#line 52 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
WriteAttributeValue("", 1538, item.Id, 1538, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1599, "\"", 1622, 1);
#nullable restore
#line 53 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
WriteAttributeValue("", 1614, item.Id, 1614, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1677, "\"", 1700, 1);
#nullable restore
#line 54 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
WriteAttributeValue("", 1692, item.Id, 1692, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Admin\source\repos\N0855975_assessment2\Views\Products\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<N0855975_assessment2.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591