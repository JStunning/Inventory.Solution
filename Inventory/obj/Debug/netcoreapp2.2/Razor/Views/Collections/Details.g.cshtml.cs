#pragma checksum "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66cf57aceafa710a93cdbd011e141f7a5accae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collections_Details), @"mvc.1.0.view", @"/Views/Collections/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Collections/Details.cshtml", typeof(AspNetCore.Views_Collections_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66cf57aceafa710a93cdbd011e141f7a5accae7", @"/Views/Collections/Details.cshtml")]
    public class Views_Collections_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inventory.Models.Collection>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 47, true);
            WriteLiteral("\n<h2><u>Collection Details</u></h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(114, 40, false);
#line 10 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(154, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(157, 36, false);
#line 10 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(193, 10, true);
            WriteLiteral("</h3>\n<h3>");
            EndContext();
            BeginContext(204, 47, false);
#line 11 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(251, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(254, 43, false);
#line 11 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(297, 9, true);
            WriteLiteral("</h3>\n<p>");
            EndContext();
            BeginContext(307, 40, false);
#line 12 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(347, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(356, 69, false);
#line 13 "/Users/Guest/Desktop/Inventory.Solution/Inventory/Views/Collections/Details.cshtml"
Write(Html.ActionLink("Delete Collection", "Delete", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(425, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.Models.Collection> Html { get; private set; }
    }
}
#pragma warning restore 1591
