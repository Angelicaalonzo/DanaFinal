#pragma checksum "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4192cce4c469d05bb4cab835ab652c0d41a152c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.PagesBooks_Index), @"mvc.1.0.razor-page", @"/PagesBooks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/PagesBooks/Index.cshtml", typeof(AspNetCore.PagesBooks_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4192cce4c469d05bb4cab835ab652c0d41a152c", @"/PagesBooks/Index.cshtml")]
    public class PagesBooks_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 156, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(254, 49, false);
#line 17 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 55, false);
#line 20 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 49, false);
#line 23 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 49, false);
#line 26 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(624, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
 foreach (var item in Model.Book) {

#line default
#line hidden
            BeginContext(747, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(796, 40, false);
#line 35 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(836, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(892, 46, false);
#line 38 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(938, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(994, 40, false);
#line 41 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1090, 40, false);
#line 44 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1205, "\"", 1228, 1);
#line 47 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
WriteAttributeValue("", 1220, item.ID, 1220, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1281, "\"", 1304, 1);
#line 48 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
WriteAttributeValue("", 1296, item.ID, 1296, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1305, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1359, "\"", 1382, 1);
#line 49 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
WriteAttributeValue("", 1374, item.ID, 1374, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1383, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "/Users/angelicaalonzo/Desktop/DanaFinalProject/PagesBooks/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1433, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DanaFinalProject.PagesBooks.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DanaFinalProject.PagesBooks.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DanaFinalProject.PagesBooks.IndexModel>)PageContext?.ViewData;
        public DanaFinalProject.PagesBooks.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
