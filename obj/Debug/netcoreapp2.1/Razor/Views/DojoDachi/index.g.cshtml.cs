#pragma checksum "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c205cec8da8dfe179a00cef1805fb6ab52206c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DojoDachi_index), @"mvc.1.0.view", @"/Views/DojoDachi/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DojoDachi/index.cshtml", typeof(AspNetCore.Views_DojoDachi_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38c205cec8da8dfe179a00cef1805fb6ab52206c", @"/Views/DojoDachi/index.cshtml")]
    public class Views_DojoDachi_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b59dda1405eb47548508bb34dca72a9c", async() => {
                BeginContext(39, 264, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>DojoDachi</title>
    <style>
        img{
            width: 300px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(310, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(311, 972, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58e68e13f3764e3e908a3d5cc5b42b7a", async() => {
                BeginContext(317, 31, true);
                WriteLiteral("\n    \n            <p>Fulness : ");
                EndContext();
                BeginContext(349, 19, false);
#line 16 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
                    Write(TempData["fulness"]);

#line default
#line hidden
                EndContext();
                BeginContext(368, 15, true);
                WriteLiteral(" , Happiness : ");
                EndContext();
                BeginContext(384, 20, false);
#line 16 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
                                                       Write(TempData["happines"]);

#line default
#line hidden
                EndContext();
                BeginContext(404, 12, true);
                WriteLiteral(" , Energy : ");
                EndContext();
                BeginContext(417, 18, false);
#line 16 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
                                                                                        Write(TempData["energy"]);

#line default
#line hidden
                EndContext();
                BeginContext(435, 11, true);
                WriteLiteral(" , Meals : ");
                EndContext();
                BeginContext(447, 17, false);
#line 16 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
                                                                                                                      Write(TempData["meals"]);

#line default
#line hidden
                EndContext();
                BeginContext(464, 123, true);
                WriteLiteral("</p>\n            <img src=\"https://www.clipartmax.com/png/middle/213-2131283_anime-modern-tamagotchi-shimashimatchi.png\" >\n");
                EndContext();
#line 18 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
       if(@TempData["gamestatus"]== "playing")
     {

#line default
#line hidden
                BeginContext(641, 53, true);
                WriteLiteral("            <div class=\"buttons\">\n                <p>");
                EndContext();
                BeginContext(695, 19, false);
#line 21 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
              Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(714, 310, true);
                WriteLiteral(@"</p>
                <a href=""/feed""><input type=""submit"" value=""Feed""></a>
                <a href=""/play""><input type=""submit"" value=""Play""></a>
                <a href=""/work""><input type=""submit"" value=""Work""></a>
                <a href=""/sleep""><input type=""submit"" value=""Sleep""></a>
            </div>
");
                EndContext();
#line 27 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
     }
         
        if(@TempData["gamestatus"] == "over")
        {


#line default
#line hidden
                BeginContext(1098, 15, true);
                WriteLiteral("            <p>");
                EndContext();
                BeginContext(1114, 19, false);
#line 32 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
          Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(1133, 126, true);
                WriteLiteral("</p>\n            <p>Do you want to play again???</p>\n            <a href=\"/restart\"><input type=\"submit\" value=\"Restart\"></a>\n");
                EndContext();
#line 35 "/Users/yehormelnyk/Desktop/Coding DOjo/C#/ASP.NET/DojoDachi/Views/DojoDachi/index.cshtml"
        }
     

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1283, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
