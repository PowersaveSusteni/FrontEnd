#pragma checksum "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d67f4141cb58445b5fde6d437df2c2e499ff5f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gravarkiv__GravFlytt), @"mvc.1.0.view", @"/Views/Gravarkiv/_GravFlytt.cshtml")]
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
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d67f4141cb58445b5fde6d437df2c2e499ff5f37", @"/Views/Gravarkiv/_GravFlytt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4a0d041100f1c7f5b87fd2c1f80209d75b00ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Gravarkiv__GravFlytt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KipWeb5.Models.Faktura.FakturaModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-6"">
        <label>Flytt hvem:</label>
        <input id=""idNavn"" class=""form-control k-textbox""/>
    </div>
    <div class=""col-lg-6"">
        <label>Flytt til:</label>
        <input id=""idPlassering"" class=""form-control k-textbox""/>
        <input hidden id=""idTilGrav"" class=""form-control k-textbox""/>
    </div>
</div>

<div class=""row"" style=""margin-top: 10px;"">
    <div class=""col-lg-6"">
        <div hidden>
            ");
#nullable restore
#line 21 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
        Write(Html.Kendo().CheckBox().Name("Symbolsk").Checked(false).Label("Flytt symbolsk"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div style=\"margin-top: 10px;\">\r\n            ");
#nullable restore
#line 24 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
        Write(Html.Kendo().CheckBox().Name("Stell").Checked(false).Label("Stell"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <div>\r\n            ");
#nullable restore
#line 29 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
        Write(Html.Kendo().CheckBox().Name("Bilde").Checked(false).Label("Bilde"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div style=\"margin-top: 10px;\">\r\n            ");
#nullable restore
#line 32 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
        Write(Html.Kendo().CheckBox().Name("Notat").Checked(false).Label("Notat"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>        \r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\" style=\"margin-top: 20px;\">\r\n    <div class=\"col-lg-6\">\r\n        <h4>Øvrige gravlagte i same grav</h4>\r\n        ");
#nullable restore
#line 40 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
    Write(Html.Kendo().Grid<KipWeb5.Models.GravarkivItem>()
            .Name("GravListeFlytt")
            .Columns(columns =>
            {
                columns.Select().Width(40);
                columns.Bound(q => q.Gravlagt_GUID).Visible(false);
                columns.Bound(q => q.FulltNavn).Width(220).Visible(true).Title("Navn");
            })
            .Scrollable()
            .Height(220)
            .Selectable(s => s
                .Mode(GridSelectionMode.Multiple)
                .Type(GridSelectionType.Row))
            .DataSource(dataSource => dataSource
                .Ajax()
                .Read(read => read.Action("getGravarkivListeNy", "Gravarkiv").Data("filterGravFlytt"))
                .PageSize(55)
            )
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <h4>Ubetalte faktura</h4>\r\n          ");
#nullable restore
#line 62 "C:\Visual Stuido 17\KipWeb5\Views\Gravarkiv\_GravFlytt.cshtml"
      Write(Html.Kendo().Grid<KipWeb5.Models.FakturaItem>()
            .Name("fakturaListeFlytt")
            .Columns(columns =>
            {
                columns.Select().Width(40);
                columns.Bound(q => q.FaktNr).Width(70).Title(Localizer["#"].Value);
                columns.Bound(q => q.KontoNr).Visible(false).Title(Localizer["Konto"].Value);
                columns.Bound(q => q.FaktDato).Width(100).Format("{0: dd.MM.yyyy}").Title("Fakturadato");
                columns.Bound(q => q.PrisMMVA).Width(100).Format("{0:n2}").Title("Pris m/mva").HtmlAttributes(new { style = "text-align: right;" });
            })
            .Selectable(s => s
                .Mode(GridSelectionMode.Multiple)
                .Type(GridSelectionType.Row))
            .Scrollable()
            .Height(220)
            .DataSource(dataSource => dataSource
                .Ajax()
                .Read(read => read.Action("getFakturaListeListe", "Faktura").Data("filterFaktura"))
                )
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KipWeb5.Models.Faktura.FakturaModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
