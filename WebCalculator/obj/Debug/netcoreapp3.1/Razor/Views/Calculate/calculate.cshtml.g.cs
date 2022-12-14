#pragma checksum "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\Calculate\calculate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c00181ddbb927b8ec03d2b22434a7e41ef3f721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculate_calculate), @"mvc.1.0.view", @"/Views/Calculate/calculate.cshtml")]
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
#line 1 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c00181ddbb927b8ec03d2b22434a7e41ef3f721", @"/Views/Calculate/calculate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea914b35850a00275709f524f4b0ae27c2788f89", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculate_calculate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:arial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .ui {
        background-color: white;
        width: 210px;
        height: 380px;
        border-style: solid;
        border-width: 2px;
        padding: 10px;
        align-items: baseline;
    }

    .numBtn {
        color: maroon;
        width: 50px;
        height: 50px;
    }

    .opBtn {
        background-color: maroon;
        color: white;
        font-size: 24px;
        width: 50px;
        height: 50px;
    }

    .calBtn {
        background-color: blue;
        color: white;
        font-size: 24px;
        width: 170px;
        height: 50px;
    }

    .clrBtn {
        background-color: green;
        color: white;
        font-size: 18px;
        width: 50px;
        height: 50px;
    }

    .numtxt {
        background-color: grey;
        color: white;
        font-size: 14;
        height: 40px;
        text-align: right;
    }
</style>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>");
            WriteLiteral(@"
<script>
$(document).ready(function(){
  $("".numBtn"").click(function(){
	var value1 = $( this ).val();
	var value2 = $( ""#input"" ).val();
    $( ""#input"" ).val( value2+value1);
  });

  $("".clrBtn"").click(function(){
	$( ""#input"" ).val("""");
  });

  $("".opBtn"").click(function(){
	var value1 = $( this ).val();
	var value2 = $( ""#input"" ).val();
    $( ""#input"" ).val( value2+value1);
  });
	$("".calBtn"").click(function(){
		var value2 = eval($( ""#input"" ).val());
		$( ""#input"" ).val( value2);
	  });
});
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c00181ddbb927b8ec03d2b22434a7e41ef3f7215132", async() => {
                WriteLiteral(@"
    <div class=""ui"" align=""center"">
        <table>
            <tr>
                <td colspan=""3""><input type=""text"" class=""numtxt"" id=""input""></td>
            </tr>
            <tr>
                <td><button class=""numBtn"" value=""1"">1</button></td>
                <td><button class=""numBtn"" value=""2"">2</button></td>
                <td><button class=""numBtn"" value=""3"">3</button></td>
            </tr>
            <tr>
                <td><button class=""numBtn"" value=""4"">4</button></td>
                <td><button class=""numBtn"" value=""5"">5</button></td>
                <td><button class=""numBtn"" value=""6"">6</button></td>
            </tr>
            <tr>
                <td><button class=""numBtn"" value=""7"">7</button></td>
                <td><button class=""numBtn"" value=""8"">8</button></td>
                <td><button class=""numBtn"" value=""9"">9</button></td>
            </tr>
            <tr>
                <td><button class=""numBtn"" value=""0"">0</button></td>
                <t");
                WriteLiteral(@"d><button class=""opBtn"" value=""/"">/</button></td>
                <td><button class=""opBtn"" value=""*"">*</button></td>
            </tr>
            <tr>
                <td><button class=""opBtn"" value=""-"">-</button></td>
                <td><button class=""opBtn"" value=""+"">+</button></td>
                <td><button class=""clrBtn"" value=""c"">C</button></td>
            </tr>
            <tr>
                <td colspan=""3""><button class=""calBtn"" value=""="">=</button></td>
            </tr>
        </table>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
