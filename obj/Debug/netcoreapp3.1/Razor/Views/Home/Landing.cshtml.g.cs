#pragma checksum "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287f303d2b4ae01576fdd7e890a117df722e22bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Landing), @"mvc.1.0.view", @"/Views/Home/Landing.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ehann\Desktop\EgyptTourism\Views\_ViewImports.cshtml"
using EgyptTourism;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ehann\Desktop\EgyptTourism\Views\_ViewImports.cshtml"
using EgyptTourism.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ehann\Desktop\EgyptTourism\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287f303d2b4ae01576fdd7e890a117df722e22bb", @"/Views/Home/Landing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4565b04b2b92016338f29c8628598d3eafb0bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Landing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
  
    int UserId = (int)Context.Session.GetInt32("UserId");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 text-center\" >\r\n        <h1>Welcome, ");
#nullable restore
#line 7 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
                Write(Context.Session.GetString("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"col-md-4 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287f303d2b4ae01576fdd7e890a117df722e22bb4710", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" | \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287f303d2b4ae01576fdd7e890a117df722e22bb6082", async() => {
                WriteLiteral("My Wishlist");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
                                                               WriteLiteral(UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<h3>Pharaoh Era Desitinations</h3>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
  
    foreach (Destination destination in ViewBag.Pharaoh)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 36rem;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 611, "\"", 657, 2);
            WriteAttributeValue("", 618, "/destination/", 618, 13, true);
#nullable restore
#line 23 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 631, destination.DestinationId, 631, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 663, "\"", 688, 1);
#nullable restore
#line 23 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 669, destination.ImgURL, 669, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image of destination\" class=\"card-img-top\"></a>\r\n            <div class=\"card-body\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 799, "\"", 845, 2);
            WriteAttributeValue("", 806, "/destination/", 806, 13, true);
#nullable restore
#line 25 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 819, destination.DestinationId, 819, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
                                                                                  Write(destination.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"



    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<h3>Coptic Destinations</h3>\r\n");
#nullable restore
#line 45 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
 foreach (var destination in ViewBag.Coptic)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 36rem;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1154, 2);
            WriteAttributeValue("", 1115, "/destination/", 1115, 13, true);
#nullable restore
#line 48 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1128, destination.DestinationId, 1128, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1160, "\"", 1185, 1);
#nullable restore
#line 48 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1166, destination.ImgURL, 1166, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image of destination\" class=\"card-img-top\"></a>\r\n            <div class=\"card-body\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1296, "\"", 1342, 2);
            WriteAttributeValue("", 1303, "/destination/", 1303, 13, true);
#nullable restore
#line 50 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1316, destination.DestinationId, 1316, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\">");
#nullable restore
#line 50 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
                                                                                  Write(destination.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 54 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Islamic</h3>\r\n");
#nullable restore
#line 58 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
 foreach (var destination in ViewBag.Islamic)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 36rem;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1565, "\"", 1611, 2);
            WriteAttributeValue("", 1572, "/destination/", 1572, 13, true);
#nullable restore
#line 61 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1585, destination.DestinationId, 1585, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1617, "\"", 1642, 1);
#nullable restore
#line 61 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1623, destination.ImgURL, 1623, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image of destination\" class=\"card-img-top\"></a>\r\n            <div class=\"card-body\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1753, "\"", 1799, 2);
            WriteAttributeValue("", 1760, "/destination/", 1760, 13, true);
#nullable restore
#line 63 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1773, destination.DestinationId, 1773, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\">");
#nullable restore
#line 63 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
                                                                                  Write(destination.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Recreation</h3>\r\n");
#nullable restore
#line 71 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
 foreach (var destination in ViewBag.Recreation)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 36rem;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2028, "\"", 2074, 2);
            WriteAttributeValue("", 2035, "/destination/", 2035, 13, true);
#nullable restore
#line 74 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 2048, destination.DestinationId, 2048, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2080, "\"", 2105, 1);
#nullable restore
#line 74 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 2086, destination.ImgURL, 2086, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image of destination\" class=\"card-img-top\"></a>\r\n            <div class=\"card-body\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2216, "\"", 2262, 2);
            WriteAttributeValue("", 2223, "/destination/", 2223, 13, true);
#nullable restore
#line 76 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
WriteAttributeValue("", 2236, destination.DestinationId, 2236, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\">");
#nullable restore
#line 76 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
                                                                                  Write(destination.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 80 "C:\Users\ehann\Desktop\EgyptTourism\Views\Home\Landing.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591