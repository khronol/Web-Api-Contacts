#pragma checksum "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6818ef62d648a3e49f1b255e09de80520b5a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Contacts.Pages.Home.Views_Home_Editor), @"mvc.1.0.view", @"/Views/Home/Editor.cshtml")]
namespace Contacts.Pages.Home
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
#line 1 "D:\Contacts\dadaFerrum\Contacts\Views\_ViewImports.cshtml"
using Contacts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6818ef62d648a3e49f1b255e09de80520b5a38", @"/Views/Home/Editor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a2c88465cd5c434c411aaabbd5792762879d89", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contacts.Views.Home.IndexModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Info/UpdateData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb6818ef62d648a3e49f1b255e09de80520b5a384214", async() => {
                WriteLiteral("\r\n    <title>DADADAD</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb6818ef62d648a3e49f1b255e09de80520b5a385210", async() => {
                WriteLiteral("\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Фамилия</th>\r\n            <th>Имя</th>\r\n            <th>Отчество</th>\r\n            <th>Номер</th>\r\n            <th>Адрес</th>\r\n            <th>Описание</th>\r\n        </tr>\r\n");
#nullable restore
#line 17 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
          
            foreach (Contacts.Models.Kont kont in ViewBag.Contacts)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb6818ef62d648a3e49f1b255e09de80520b5a386027", async() => {
                    WriteLiteral("\r\n                <tr style=\"background-color: yellow; font-weight: bold\">\r\n                    <td>\r\n                        <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 692, "\"", 708, 1);
#nullable restore
#line 23 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 700, kont.Id, 700, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" disabled=\"disabled\" style=\"width: 20px\" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"SurName\"");
                    BeginWriteAttribute("value", " value=\"", 864, "\"", 885, 1);
#nullable restore
#line 26 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 872, kont.Surname, 872, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"Name\"");
                    BeginWriteAttribute("value", " value=\"", 998, "\"", 1020, 1);
#nullable restore
#line 29 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 1006, kont.MainName, 1006, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"Otch\"");
                    BeginWriteAttribute("value", " value=\"", 1133, "\"", 1151, 1);
#nullable restore
#line 32 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 1141, kont.Otch, 1141, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"Phone\"");
                    BeginWriteAttribute("value", " value=\"", 1265, "\"", 1284, 1);
#nullable restore
#line 35 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 1273, kont.Phone, 1273, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"Address\"");
                    BeginWriteAttribute("value", " value=\"", 1400, "\"", 1421, 1);
#nullable restore
#line 38 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 1408, kont.Surname, 1408, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"Caption\"");
                    BeginWriteAttribute("value", " value=\"", 1537, "\"", 1558, 1);
#nullable restore
#line 41 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 1545, kont.Caption, 1545, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input name=\"id\" type=\"submit\"");
                    BeginWriteAttribute("value", " value=\"", 1671, "\"", 1696, 2);
                    WriteAttributeValue("", 1679, "изменить-", 1679, 9, true);
#nullable restore
#line 44 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
WriteAttributeValue("", 1688, kont.Id, 1688, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" style=\"height:30px; background-color:navy;color: white; font-weight: bold\" />\r\n                    </td>\r\n                </tr>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "D:\Contacts\dadaFerrum\Contacts\Views\Home\Editor.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n        ");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contacts.Views.Home.IndexModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
