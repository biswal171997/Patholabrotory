#pragma checksum "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DignosisConfiguration\AddDignosisConfiguration.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DignosisConfiguration_AddDignosisConfiguration), @"mvc.1.0.view", @"/Views/DignosisConfiguration/AddDignosisConfiguration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb", @"/Views/DignosisConfiguration/AddDignosisConfiguration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efe64be18ad298390ae23b73ed793dc8ec42f6099de9d3a886c7c094529c1c06", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DignosisConfiguration_AddDignosisConfiguration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PathoLab.Domain.DignosisConfigurationMaster.DignosisConfiguration>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DignosisConfiguration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddDignosisConfiguration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewDignosisConfiguration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlDignosisValue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlLabTestMethodology"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btnok"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DignosisConfiguration\AddDignosisConfiguration.cshtml"
  
    ViewData["Title"] = "AddDignosisConfiguration";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    table td {
        border: 1px solid black;
        padding: 4px 12px;
    }
</style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb8151", async() => {
                WriteLiteral("Add Dignosis Configuration");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb9659", async() => {
                WriteLiteral("View Dignosis Configuration");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </ul>
            </div>
            <!--===================================================-->
            <!-- BASIC FORM ELEMENTS 1 -->
            <!--===================================================-->
            <div class=""card-body"">
                <!--Static-->
                <div class=""form-group row"">
                    <input type=""hidden"" value=""0"" id=""hdnDignosisConfigId"" />
                    <div class=""col-xs-12 col-md-6 col-xl-6"">
                        <label class=""control-label""><b>Dignosis Value</b><span class=""text-danger"">*</span></label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb11795", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb12108", async() => {
                    WriteLiteral("--Select--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#nullable restore
#line 41 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DignosisConfiguration\AddDignosisConfiguration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Name,"DignosisID","Name"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DignosisConfiguration\AddDignosisConfiguration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DignosisID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                </div>
                <div class=""form-group row"">
                    <input type=""hidden"" id=""hdnPatientID"" />
                    <div class=""col-xs-12 col-md-6 col-xl-6"">
                        <label class=""control-label""><b>Lab Test Methodology</b><span class=""text-danger"">*</span></label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb15793", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb16106", async() => {
                    WriteLiteral("--Select--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#nullable restore
#line 51 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DignosisConfiguration\AddDignosisConfiguration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.LabTestName,"LabTestId","LabTestName"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DignosisConfiguration\AddDignosisConfiguration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LabTestId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                </div>
            </div>
            <!--===================================================-->
            <!-- END BASIC FORM ELEMENTS 1-->
            <!--==============================================================================================================================================-->
            <!-- BASIC FORM ELEMENTS 2 -->
            <!--===================================================-->
            <div class=""card-body"">

                <div class=""col-12 col-md-12 col-xl-12"">
");
            WriteLiteral(@"                    <div>
                        <table id=""tblDignosisConfiguration"">
                            <tr>
                                <td rowspan=""2""><b>Investigation Name</b></td>
                                <td colspan=""2""><b>Biological Reference Interval</b></td>
                                <td rowspan=""2""><b>Unit</b></td>
                                <td rowspan=""2""><b>Action</b></td>
                            </tr>
                            <tr>
                                <td><b>Minimum Percentage</b></td>
                                <td><b>Maximum Percentage</b></td>
                            </tr>
                            <tbody id=""tbody""></tbody>
                        </table><br />
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <button class");
            WriteLiteral(@"=""btn btn-md btn-primary pull-right"" id=""addBtn"" type=""button""> Add </button>
                            </div>
                        </div>
                    </div><br />
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                        <button class=""btn btn-danger mb-1"" onclick=""reset()"" id=""btnReset"">Reset</button>
                    </div>
                </div>
                <div class=""modal fade"" id=""SubmitModal"" tabindex=""1"" role=""dialog""
                     aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                        <div class=""modal-content"">
                            <");
            WriteLiteral(@"div class=""modal-header"">
                                <h5 style=""color:aquamarine""> Dignosis Configuration Details</h5>
                            </div>
                            <div class=""modal-body"">
                                <h6 class=""modalMsg""></h6>
                            </div>
                            <div class=""modal-footer"">
                                <input type=""submit"" class=""btn btn-info btn-sm submitConfirm hbtn"" value=""Yes"" styk=""display:none"" />
                                <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal fade"" id=""SuccessModal"" tabindex=""1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                    <div class=""modal-dialog modal-dialog-centered"" ");
            WriteLiteral(@"role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""resultMsg"" style=""color:blue""></h5>
                            </div>
                            <div class=""modal-body"">
                                <h5 class=""msgsuccess""></h5>
                            </div>
                            <div class=""modal-footer"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc002fbe3ac4126f1266d126f4724f73eabdf1b1ed3211d15121c492248b7fb23795", async() => {
                WriteLiteral("Close");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal fade"" id=""UnSuccessModal"" tabindex=""1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""resultMsg"" style=""color:blue""></h5>
                            </div>
                            <div class=""modal-body"">
                                <h5 class=""msgunsuccess""></h5>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" ");
            WriteLiteral(@">Close</button>

                            </div>
                        </div>
                    </div>
                </div>

                <!--===================================================-->
                <!-- END BASIC FORM ELEMENTS 2 -->
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">

    $(document).ready(function () {
        //breadcumb
        var DignosisID = getUrlVars()[""DignosisID""];
        var LabTestId = getUrlVars()[""LabTestId""];
        if (DignosisID != undefined && LabTestId != undefined) {
            $(""#btnSubmit"").html(""Update"");
            $(""#btnReset"").html(""Cancel"");
            Edit(DignosisID, LabTestId);

        }
    });
  //< !--=================================================== -->
    function validate() {
        if ($('#ddlDignosisValue').val() == 0) {
            alert(""Please Select Dignosis!"");
            $('#ddlDignosisValue').focus();
            return false;

        }
      ");
            WriteLiteral(@"  else if ($('#ddlLabTestMethodology').val() == 0) {
            alert(""Please Select TestMethodology!"");
            $('#ddlLabTestMethodology').focus();
            return false;

        }
        else if ($('#tblDignosisConfiguration').val() == """") {
            alert(""Please Enter Data!"");
            $('#tblDignosisConfiguration').focus();
            return false;
        }
        else
            return true;
    }
    //< !--=================================================== -->
    //UPDATE
    function Edit(DignosisID, LabTestId) {
        $.ajax({
            url: ""/DignosisConfiguration/GetDignosisConfigurationById?DignosisID="" + DignosisID + ""&LabTestId="" + LabTestId,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (data) {
                $('#hdnDignosisConfigId').val(data[0].DignosisConfigId);
                $('#ddlDignosisValue').val(data[0].DignosisID);
                ");
            WriteLiteral(@"$('#ddlLabTestMethodology').val(data[0].LabTestId);
                $.each(data, function (i, item) {
                    $('#tbody').append(`<tr id=""R${++rowIdx}"">
                    <td class=""row-index text-center"">
                    <input id=""txtInvestigationName"" value=""${item.InvestigationName}"" class=""inputs form-control m-input"">
                    </td>
                     <td class=""row-index text-center"">
                     <input id=""txtMinimumPercentage"" value=""${item.MinimumPercentage}"" type=""text"" maxlength = ""100"" size = ""10""class=""form-control m-input"">
                    </td>
                     <td class=""row-index text-center"">
                     <input id=""txtMaximumPercentage"" value=""${item.MaximumPercentage}"" type=""text"" maxlength = ""100"" size = ""10""class=""form-control m-input"">
                    </td>
                    <td class=""row-index text-center"">
                     <input id=""txtUnit"" type=""text"" value=""${item.Unit}"" maxlength = ""100"" size = ""10""c");
            WriteLiteral(@"lass=""form-control m-input"">
                    </td>
                      
                       <td class=""text-center"">
                        <button class=""btn btn-danger"" remove id=""action""
                         type=""button"">Remove</button>
                       </td>
                    </tr>`
                    );
                });
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
    //< !--=================================================== -->
    //< !--=================================================== -->

    function reset() {
        window.location.href = ""/DignosisConfiguration/AddDignosisConfiguration"";
    }
    //< !--=================================================== -->

    //Create
    $(""#btnSubmit"").click(function () {
        var selected = [];
        $('#newinput option:selected').each(function () {
            selected.push($(this).attr('value'))");
            WriteLiteral(@";
        });

        // Array of data we'll retu
        var entity = []; //array declaring to store the records to send it to controller
        //var entity = {};

        var tbl = document.getElementById('tbody');
        for (var i = 0; i < tbl.rows.length; i++) {
            var item1 = {};
            item1.DignosisConfigId = parseInt($(""#hdnDignosisConfigId"").val());
            item1.DignosisID = parseInt($(""#ddlDignosisValue"").val());
            item1.LabTestId = parseInt($(""#ddlLabTestMethodology"").val());
            item1.InvestigationName = tbl.rows[i].children[0].children[0].value;
            item1.MinimumPercentage = parseFloat(tbl.rows[i].children[1].children[0].value);
            item1.MaximumPercentage = parseFloat(tbl.rows[i].children[2].children[0].value);
            item1.Unit = tbl.rows[i].children[3].children[0].value;
            entity.push(item1);
        }
        if (validate()) {
            if (confirm(""Are you sure you want to Submit ?"")) {
          ");
            WriteLiteral(@"      $.ajax({
                    url: ""/DignosisConfiguration/CreateDignosisConfiguration"",
                    data: JSON.stringify(entity),
                    type: ""POST"",
                    contentType: ""application/json;charset=utf-8"",
                    dataType: ""json"",
                    success: function (result) {
                        if (getUrlVars()[""DignosisConfigId""] != undefined) {
                            alert(result)
                            location.href = ""/DignosisConfiguration/ViewDignosisConfiguration"";
                        }
                        else {
                            alert(result);
                            location.href = ""/DignosisConfiguration/ViewDignosisConfiguration"";
                            reset();

                        }
                    },
                    error: function (errormessage) {
                        alert(errormessage.responseText);
                    }
                });
            }
    ");
            WriteLiteral(@"    }
    });
    //< !--=================================================== -->

    //Cancle
    $(""#btnCancel"").click(function () {
        reset();
        if (getUrlVars()[""DignosisConfigId""] != undefined) {
            window.location.href = ""/DignosisConfiguration/ViewDignosisConfiguration"";
        }
    })
    //< !--=================================================== -->
    //Update
    //Add Textbox Inside The Table Cells(Dynamic)

    // Denotes total number of rows
    var rowIdx = """";
    // jQuery button click event to add a row
    $('#addBtn').on('click', function () {
        // Adding a row inside the tbody.
        $('#tbody').append(`<tr id=""R${++rowIdx}"">
             <td class=""row-index text-center"">
             <input id=""txtInvestigationName"" class=""inputs form-control m-input"">
             </td>
              <td class=""row-index text-center"">
              <input id=""txtMinimumPercentage"" type=""text"" maxlength = ""100"" size = ""10""class=""form-control m-inp");
            WriteLiteral(@"ut"">
             </td>
              <td class=""row-index text-center"">
              <input id=""txtMaximumPercentage"" type=""text"" maxlength = ""100"" size = ""10""class=""form-control m-input"">
             </td>
             <td class=""row-index text-center"">
              <input id=""txtUnit"" type=""text"" maxlength = ""100"" size = ""10""class=""form-control m-input"">
             </td>
              <td class=""text-center"">
                <button class=""btn btn-danger"" remove id=""action""
                  type=""button"">Remove</button>
                </td>
              </tr>`
        );
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
    ");
            WriteLiteral(@"        var id = $(this).attr('id');

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

    //< !--=================================================== -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PathoLab.Domain.DignosisConfigurationMaster.DignosisConfiguration> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591