#pragma checksum "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\PathoLab\CollectSample.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10805c88be6621a8bb521e7eb81900d511fcc27b00fd47cac001d146add433d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PathoLab_CollectSample), @"mvc.1.0.view", @"/Views/PathoLab/CollectSample.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\_ViewImports.cshtml"
using PathoLab.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\_ViewImports.cshtml"
using PathoLab.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"10805c88be6621a8bb521e7eb81900d511fcc27b00fd47cac001d146add433d6", @"/Views/PathoLab/CollectSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efe64be18ad298390ae23b73ed793dc8ec42f6099de9d3a886c7c094529c1c06", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PathoLab_CollectSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/printprescription.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PathoLab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link  active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CollectSample", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\PathoLab\CollectSample.cshtml"
  
    ViewData["Title"] = "CollectSample";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";
    var ResultData = ViewBag.Result as List<PathoLab.Domain.PathoBilMasterl.PathoBill>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Collect Sample</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10805c88be6621a8bb521e7eb81900d511fcc27b00fd47cac001d146add433d66381", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb p-0 mb-0 bg-transparent"" id=""navigation"">
            </ol>
        </nav>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10805c88be6621a8bb521e7eb81900d511fcc27b00fd47cac001d146add433d67984", async() => {
                WriteLiteral("Collection Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10805c88be6621a8bb521e7eb81900d511fcc27b00fd47cac001d146add433d69481", async() => {
                WriteLiteral(" Sample Collection");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </ul>\r\n                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 1059, "\"", 1067, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
            <!--===================================================-->
            <!-- BASIC FORM ELEMENTS 1 -->
            <!--===================================================-->
            <h4>Patient Details</h4>
            <div class=""card-body"">
                <input type=""hidden"" id=""hdnPathoBillId"" class=""form-control m-input"">
                <input type=""hidden"" id=""hdnCollectionId"" class=""form-control m-input"">
                <div class=""form-group row"">
                    <div class=""col-xs-12 col-md-2 col-xl-2"">
                        <label class=""control-label""><b>Name:-</b></label>
                        <label id=""lblName""></label>
                    </div>
                    <div class=""col-xs-12 col-md-3 col-xl-");
            WriteLiteral(@"3"">
                        <label class=""control-label""><b>MobileNo:-</b> </label>
                        <label id=""lblMobile""></label>
                    </div>
                    <div class=""col-xs-12 col-md-1 col-xl-1"">
                        <label class=""control-label""><b>Age:-</b> </label>
                        <label id=""lblAge""></label>
                    </div>
                    <div class=""col-xs-12 col-md-2 col-xl-2"">
                        <label class=""control-label""><b>Gender:-</b></label>
                        <label id=""lblGender""></label><br />
                    </div>
                    <div class=""col-xs-12 col-md-3 col-xl-3"">
                        <label class=""control-label""><b>Email:-</b></label>
                        <label id=""lblEmail""></label><br />
                    </div>
                </div>
            </div>


            <!--===================================================-->
            <!-- END BASIC FORM ELEMENTS 1-->
       ");
            WriteLiteral(@"     <!--==============================================================================================================================================-->
            <!-- BASIC FORM ELEMENTS 2 -->
            <!--===================================================-->
            <div class=""card-body"">
                <div class=""form-group row"">
                    <div class=""col-12 col-md-12 col-xl-12"">
                        <div>
                            <table id=""tblTestBill"" class=""col-12 col-md-12 col-xl-12"">
                                <tr>
                                    <td><b>Sl#</b></td>
                                    <td><b>Test Name</b></td>
                                    <td><b>BarCodeNo</b></td>
");
            WriteLiteral(@"                                </tr>
                                <tbody id=""tbody""></tbody>

                            </table><br />
                        </div><br />
                    </div>
                </div>

                <!--==============================================================================================================================================-->

                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                    <div class=""col-12 col-md-4 col-xl-4"" style=""margin-left:300px"">
                        <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                    </div>
                </div>

                <!--==============================================================================================================================================-->
                <!-- END BASIC FORM ELEMENTS 2 -->
            </div>
        </div>
");
            WriteLiteral(@"    </div>
</div>
<script>
    $(document).ready(function () {
        //breadcumb
        var PathoBillId = getUrlVars()[""PathoBillId""];
        if (PathoBillId != undefined) {
            Collect(PathoBillId);
            Report(PathoBillId);
            Barcode(PathoBillId);
        }

    });
    var PathoBillIdTemp;
    var CollectionIdTemp;
    //DataBind From PathoLabCollection Table
    function Collect(PathoBillId) {
        $.ajax({
            url: ""/PathoLab/GetPatientDetailsByPathoBillId?PathoBillId="" + PathoBillId,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                $('#hdnPathoBillId').text(result.PathoBillId);
                PathoBillIdTemp = result.PathoBillId;
                CollectionIdTemp = result.CollectionId;
                $('#hdnCollectionId').text(result.CollectionId);
                $('#lblName').text(result.FullName);
               ");
            WriteLiteral(@" $('#lblDate').text(result.DateOfAppointment);
                $('#lblAge').text(result.Age);
                $('#lblGender').text(result.Gender);
                $('#lblMobile').text(result.Mobile);
                $('#lblEmail').text(result.Email);
                $('#lblLabTestMethodology').text(result.LabTestName);
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }

    //< !--=================================================== -->
    function Barcode(PathoBillId) {
        $.ajax({
            url: ""/PathoLab/GetBarcodeByPathoBillId?PathoBillId="" + PathoBillId,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (data) {
                $(""#divBarcode"").html(""<img style='height:50px;width:200px' src='"" + JSON.parse(data).BarcodeImage + ""' alt='' />"");
            },
            //error: function (erro");
            WriteLiteral(@"rmessage) {
            //    alert(errormessage.responseText);
            //}
        });
    }
    //< !--=================================================== -->

    function Report(PathoBillId) {
        $.ajax({
            url: ""/PathoLab/BindingTest?PathoBillId="" + PathoBillId,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (data) {
                // Denotes total number of rows
                var rowIdx = """";
                // Adding a row inside the tbody.
                $.each(data, function (i, item) {
                    $('#tbody').append(`<tr id=""R${++rowIdx}"">
                      <td class=""row-index text-center"">
                     <label  class=""control-label"">${rowIdx}</label>
                    </td>
                     <td class=""row-index text-center"">
                     <label id=""txtTestName""  class=""control-label"">${item.LabTestName}</label>
            ");
            WriteLiteral(@"        <input type=""hidden"" value=""${item.LabTestId}"" id=""hdnLabTestId"" class=""form-control m-input"">
                    </td>
                     <td class=""row-index text-center"">
                  <input id=""txtBarcode"" type=""text"" maxlength = ""100"" size = ""10""class=""form-control m-input"" >
                 </td>

                    </tr>`
                    );
                });
            },
            //error: function (errormessage) {
            //    alert(errormessage.responseText);
            //}
        });
        // jQuery button click event to remove a row.
        $('#tbody').on('click', '.remove', function () {

            // Getting all the rows next to the row
            // containing the clicked button
            var child = $(this).closest('tr').nextAll();

            // Iterating across all the rows
            // obtained to change the index
            child.each(function () {
                // Getting <tr> id.
                var id = $(this).att");
            WriteLiteral(@"r('id');
                // Getting the <p> inside the .row-index class.
                var idx = $(this).children('.row-index').children('p');
                // Gets the row number from <tr> id.
                var dig = parseInt(id.substring(1));
                // Modifying row index.
                idx.html(`Row ${dig - 1}`);
                // Modifying row id.
                $(this).attr('id', `R${dig - 1}`);
            });

            // Removing the current row.
            $(this).closest('tr').remove();

            // Decreasing total number of rows by 1.
            rowIdx--;
        });
    }
    //< !--=================================================== -->
    //Create
    $(""#btnSubmit"").click(function () {
        var selected = [];
        $('#newinput option:selected').each(function () {
            selected.push($(this).attr('value'));
        });
        // Array of data we'll retu
        var Items = []; //array declaring to store the records to send it to");
            WriteLiteral(@" controller
        var entity = {};
        var tbl = document.getElementById('tbody');
        for (var i = 0; i < tbl.rows.length; i++) {
            var item1 = {};
            item1.LabTestId = tbl.rows[i].children[1].children[1].value;
            item1.Barcode = tbl.rows[i].children[2].children[0].value;
            Items.push(item1);
        }
        entity.CollectionSample = Items;
        
        entity.PathoBillId = PathoBillIdTemp;
        entity.CollectionId = CollectionIdTemp;
        debugger
        if (confirm(""Are you sure you want to Submit ?"")) {
            $.ajax({
                url: ""/PathoLab/SampleCollectionInfo"",
                data: entity,
                type: ""POST"",
                success: function (result) {
                    if (result = ""Data Saved Successfully"") {
                        alert(result);

                        location.href = ""/PathoLab/ViewCollection"";
                    }
                    else {
                       ");
            WriteLiteral(@" alert(result);
                        reset();
                    }
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }
    });

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
