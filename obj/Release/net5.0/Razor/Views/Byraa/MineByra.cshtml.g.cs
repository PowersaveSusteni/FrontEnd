#pragma checksum "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e630973bd6fc66f3b1547d0613287d2748177d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Byraa_MineByra), @"mvc.1.0.view", @"/Views/Byraa/MineByra.cshtml")]
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
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\_ViewImports.cshtml"
using KipWeb5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Visual Stuido 17\KipWeb5\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e630973bd6fc66f3b1547d0613287d2748177d01", @"/Views/Byraa/MineByra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4a0d041100f1c7f5b87fd2c1f80209d75b00ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Byraa_MineByra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KipWeb5.Models.Bestilling.BestillingModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Ny.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Lagre.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Slette.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MineByraInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("controller", new global::Microsoft.AspNetCore.Html.HtmlString("ByraBestilling"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Lagre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("byraaBestilling"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
  
    ViewData["Title"] = Localizer["Begravelsesbyråer"];
    ViewData["LogOnOk"] = "2";
    ViewData["Menu"] = "Grunnregister";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e630973bd6fc66f3b1547d0613287d2748177d017424", async() => {
                WriteLiteral("\r\n    <div id=\"confirm\"></div>\r\n\r\n    <div class=\"container-fluid padding-0\">\r\n\r\n        <div class=\"form-group row\" id=\"heading\" style=\"min-height: 70px;\">\r\n            <div class=\"col-2 unselectable\">\r\n                <h3>");
#nullable restore
#line 19 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
               Write(Localizer["Byrå"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
            </div>

            <div class=""col-8"">

            </div>

            <div class=""col-2"">
                <div id=""infoLagring""></div>
            </div>

        </div>

        <div class=""row"" style=""min-height: 720px; border: 1px solid lightgrey; padding-top: 10px; padding-right: 10px; margin: 5px;"">


            <div class=""col-6"" id=""funksjoner"">

                
                    <button type=""button"" name=""ny"" class=""commandline"" onclick=""showDialogFinnByraa()"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e630973bd6fc66f3b1547d0613287d2748177d018709", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
#nullable restore
#line 40 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
                   Write(Localizer["Ny"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n\r\n                    <button type=\"submit\" name=\"lagre\" class=\"commandline\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e630973bd6fc66f3b1547d0613287d2748177d0110185", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
#nullable restore
#line 45 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
                   Write(Localizer["Lagre"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n\r\n                    <button type=\"button\" name=\"slette\" class=\"commandline\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1627, "\"", 1637, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e630973bd6fc66f3b1547d0613287d2748177d0111824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
#nullable restore
#line 50 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
                   Write(Localizer["Slette"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n\r\n                \r\n\r\n\r\n                <div class=\"form-group\" style=\"margin-top: 10px;\">\r\n                    <h4>");
#nullable restore
#line 57 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
                   Write(Localizer["Liste over byrå med tilgang"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n                    ");
#nullable restore
#line 59 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
                Write(Html.Kendo().Grid<KipWeb5.Models.ByraaItem>()
                        .Name("listeByraa")
                        .Columns(columns =>
                            {
                                columns.Bound(q => q.fbGuid).Visible(false);
                                columns.Bound(q => q.Navn);
                                columns.Bound(q => q.ViskWeb).Width(60).ClientHeaderTemplate("<img src='" + Url.Content("~/images/") + "internet.svg' width='24' height='24' >").ClientTemplate("<img src='" + Url.Content("~/images/") + "#:data.ViskWeb#.svg' width='24' height='24' alt='#: data.ViskWeb#' />");
                                columns.Bound(q => q.Registrering).Width(60).ClientHeaderTemplate("<img src='" + Url.Content("~/images/") + "key-filled.svg' width='24' height='24' >").ClientTemplate("<img src='" + Url.Content("~/images/") + "#:data.Registrering#.svg' width='24' height='24' alt='#: data.Registrering#' />");
                            })
                        .HtmlAttributes("style='height: 770px'")
                        .Scrollable()
                        .Selectable(s => s
                            .Mode(GridSelectionMode.Single)
                            .Type(GridSelectionType.Row))
                        //.Events(events => events
                        //    .Change("onFunksjonChange"))
                        .DataSource(dataSource => dataSource
                            .Ajax()
                            .Read(read => read.Action("getMineByraaListe", "Byraa"))
                        )
                    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-7\">\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e630973bd6fc66f3b1547d0613287d2748177d0115494", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"DialogBegravelse\">\r\n\r\n  ");
#nullable restore
#line 97 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
Write(Html.Kendo().Dialog()
        .Name("dialogFinnByrå")
        .Title("Finn byrå")
        .Content(
            Html.Kendo().Grid<KipWeb5.Models.ByraaItem>()
            .Name("grdByraa")
            .Columns(columns =>
                {
                columns.Select().Width(45);
                columns.Bound(e => e.Fellesraad).Visible(false);
                columns.Bound(e => e.Navn);
                columns.Bound(e => e.Adresse);
                columns.Bound(e => e.PostNr).Width(70);
                columns.Bound(e => e.Telefon).Width(120);
                })
            .Height(450)
            .Scrollable()
            //.Events(e => e.DataBound("onReserveringDataBound"))
            .DataSource(dataSource => dataSource
                .Ajax()
                .Read(read => read
                .Action("getAlleByraaListe", "Byraa")
                )
            )
            //.Events(ev => ev.DataBound("treeViewDataBound").Check("treeViewCheck"))
            .ToHtmlString()
            )
        .Width(900)
        .Height(600)
        .Modal(false)
        .Visible(false)
        .Actions(actions =>
            {
            actions.Add().Text("Avbryt");
            actions.Add().Text("Velg").Action("onActionOK").Primary(true);
            })
        .Events(ev => ev.Close("onClose").Open("onOpen"))
    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

</div>

<script id=""liste-template"" type=""text/x-kendo-template"">
    <span class=""k-state-default"" style=""font-weight: #:data.BoldTekst#; color:#:data.BoldTekstColor#;"">#: data.Navn#</span>
</script>

<script type=""text/javascript"">

    function showDialogFinnByraa() {
        var grdGraver = $(""#grdByraa"").data(""kendoGrid"");
        grdGraver.dataSource.read();
        $('#dialogFinnByrå').data(""kendoDialog"").open();
    }

</script>

<script id=""funksjoner"" type=""text/javascript"">


    function onClose() {
        $(""#showDialogBtn"").fadeIn();
    }

    function onOpen() {
        $(""#showDialogBtn"").fadeOut();
    }

    function onActionOK(e) {
        var grid = $(""#grdByraa"").data(""kendoGrid"");
        var selected = [];

        //get all selected rows (those which have the checkbox checked)
        grid.select().each(function () {
            selected.push(grid.dataItem(this));
        });

        var nodes = """";
        for (var i = 0; i < selected.length");
            WriteLiteral("; i++) {\r\n            nodes += selected[i].Fellesraad + \";\";\r\n        }\r\n\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \'");
#nullable restore
#line 179 "C:\Visual Stuido 17\KipWeb5\Views\Byraa\MineByra.cshtml"
             Write(Url.Action("leggTilByra", "Byraa"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {fellesraad: nodes}
        }).done(function (result) {
            if (result.Result == true) {
                var grid = $(""#listeByraa"").data(""kendoGrid"");
                grid.dataSource.read();
            }
            else {
                alert(result.ErrorTekst);  
                }
            });

    }


</script>


<script>

  

</script>

<style>
    div.k-listbox {
        height: 530px;
    }
</style>

<script>

    $('#myTab a').click(function (e) {
        e.preventDefault();
        $(this).tab('show');
    });

    // store the currently selected tab in the hash value
    $(""ul.nav-tabs > li > a"").on(""shown.bs.tab"", function (e) {
        var id = $(e.target).attr(""href"").substr(1);
        window.location.hash = id;
    });

    // on load of the page: switch to the currently selected tab
    var hash = window.location.hash;
    $('#myTab a[href=""' + hash + '""]').tab('show');

</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KipWeb5.Models.Bestilling.BestillingModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
