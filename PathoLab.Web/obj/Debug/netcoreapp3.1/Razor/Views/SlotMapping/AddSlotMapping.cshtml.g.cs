#pragma checksum "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SlotMapping\AddSlotMapping.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SlotMapping_AddSlotMapping), @"mvc.1.0.view", @"/Views/SlotMapping/AddSlotMapping.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a", @"/Views/SlotMapping/AddSlotMapping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efe64be18ad298390ae23b73ed793dc8ec42f6099de9d3a886c7c094529c1c06", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SlotMapping_AddSlotMapping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PathoLab.Domain.SlotMappig.SlotMapping>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SlotMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSlotMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewSlotMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("HospitalName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("GetAllSlotByHId()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SlotMapping\AddSlotMapping.cshtml"
  
    ViewData["Title"] = "AddSlotMapping";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-title"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a7533", async() => {
                WriteLiteral("Add");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a9018", async() => {
                WriteLiteral("View");
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
            WriteLiteral("\r\n                </ul>\r\n                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 906, "\"", 914, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
            <!-- BASIC FORM ELEMENTS -->
            <!--===================================================-->
            <div class=""card-body"">
                <!--Static-->
                <div class=""form-group row"">
                    <input type=""hidden"" id=""hdnSMId"" />
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Hospital Name<span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a11535", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a11848", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 36 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SlotMapping\AddSlotMapping.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.HospitalName,"HospitalID","HospitalName"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SlotMapping\AddSlotMapping.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HospitalID);

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
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Slot Name<span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <select id=""SlotName"" onchange=""GetShiftTimeBySlotId()"" class=""form-control"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a15661", async() => {
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
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Slot Time from <span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-3 col-xl-2"">
                        <input type=""time"" id=""TimeFrom"" readonly class=""form-control"">
                    </div>
                    <label");
            BeginWriteAttribute("class", " class=\"", 2959, "\"", 2967, 0);
            EndWriteAttribute();
            WriteLiteral(@">To <span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-3 col-xl-2"">
                        <input type=""time"" id=""TimeTo"" readonly class=""form-control"">
                    </div>
                </div>

                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Doctor Name<span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <select id=""DoctorName"" class=""form-control"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64685f90dadd76941c65287a335dda678ba21946b7a973eeab44f01a1295a18129", async() => {
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
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input""> Day<span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-6 col-xl-4"" id=""Day"">
                        <input type=""checkbox"" id=""Monday"" class=""form-control"" value=""1"">
                        <label for=""Monday""> Monday</label>
                        <input type=""checkbox"" id=""Tuesday"" class=""form-control"" value=""2"">
                        <label for=""Tuesday""> Tuesday</label>
                        <input type=""checkbox"" id=""Wednesday"" class=""form-control"" value=""3"">
                        <label for=""Wednesday""> Wednesday</label>
                        <input type=""checkbox"" id=""Thursday"" class=""form-control"" value=""4"">
                        <label for=""Thursday""> Thursday</label>
                        <input type=""checkbox");
            WriteLiteral(@""" id=""Friday"" class=""form-control"" value=""5"">
                        <label for=""Friday""> Friday</label>
                        <input type=""checkbox"" id=""Saturday"" class=""form-control"" value=""6"">
                        <label for=""Saturday""> Saturday</label>
                        <input type=""checkbox"" id=""Sunday"" class=""form-control"" value=""7"">
                        <label for=""Sunday""> Sunday</label>
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                        <button class=""btn btn-danger mb-1"" id=""btnReset"">Reset</button>
                    </div>
                </div>
            </div>
            <!--===================================================-->
            <!-- END BASIC FORM ELE");
            WriteLiteral(@"MENTS -->
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        //breadcumb
        loadNavigation('Add SlotMapping', 'gldata', 'plsubmission', 'Add SlotMapping', '', 'Add SlotMapping');
        var SlotID = getUrlVars()[""SlotID""];
        var DoctorId = getUrlVars()[""DoctorId""];
        if (SlotID != undefined && DoctorId != undefined) {
            $(""#btnSubmit"").html(""Update"");
            $(""#btnReset"").html(""Cancel"");
            Edit(SlotID, DoctorId);
        }
    });
    //Validation
    function validate() {

        if ($('#HospitalName').val() == ""Select"") {
            alert(""Please Select Hospital Name !"");
            return false;
            $('#HospitalName').focus();
        }
        else if ($('#SlotName').val() == ""Select"") {
            alert(""Please Select Slot Name !"");
            return false;
            $('#SlotName').focus();
        }
        else if ($('#DoctorName').val() == ""Select"") {
            alert(""Please Se");
            WriteLiteral(@"lect Doctor Name !"");
            $('#DoctorName').focus();
            return false;
        }
        else {
            $(""#btnReset"").hide();
            return true;
        }
    }

    //Create
    $(""#btnSubmit"").click(function () {
            var selected = [];
            $('#Day input:checked').each(function () {
                selected.push($(this).attr('value'));
            });
            var dign = {
                SMId: $(""#hdnSMId"").val(),
                HospitalID: $(""#HospitalName"").val(),
                SlotID: $(""#SlotName"").val(),
                DoctorId: $(""#DoctorName"").val(),
                Day: selected.join("", ""),
            };
        if (validate()) {
            if (confirm(""Are you sure you want to Submit ?"")) {
                $.ajax({
                    url: ""/SlotMapping/AddSlotMapping"",
                    data: dign,
                    type: ""POST"",
                    success: function (result) {
                        if (getUrlVa");
            WriteLiteral(@"rs()[""SMId""] != undefined) {
                            alert(result);
                            window.location.href = ""/SlotMapping/ViewSlotMapping"";
                        }
                        else {
                            alert(result);
                            window.location.href = ""/SlotMapping/ViewSlotMapping"";
                            reset();
                        }
                    },
                    error: function (errormessage) {
                        alert(errormessage.responseText);
                    }
                });

            }
        }
    });

    //First Delete And Update
    function Edit(SlotID,DoctorId) {
            $.ajax({
                url: ""/SlotMapping/SlotMappingGetById?SlotID="" + SlotID + ""&DoctorId="" + DoctorId,
                type: ""GET"",
                contentType: ""application/json;charset=UTF-8"",
                dataType: ""json"",
                success: function (result) {
                    $('#hdnS");
            WriteLiteral(@"MId').val(result[0].SMId);
                    $(""#HospitalName"").val(result[0].HospitalID);
                    $(""#DoctorName"").val(result[0].DoctorId);
                   // Bind Slot Name By Using HospitalId  During Edit
                    $.ajax({
                        url: ""/Slot/GetSlotByHospitalId?HospitalID="" + result[0].HospitalID,
                        type: ""GET"",
                        success: function (result) {
                            data = JSON.parse(result);
                            var v = ""<option value='0'>--Select--</option>"";
                            $.each(data, function (i, item) {
                                v += ""<option value="" + item.SlotID + "">"" + item.SlotName + ""</option>"";
                            });
                            $(""#SlotName"").html(v);
                            $('#SlotName').val(data[0].SlotID);
                        },
                        error: function (error) {
                            jsonValue = jQuery");
            WriteLiteral(@".parseJSON(error.responseText);
                            alert(""Error : "" + jsonValue);
                        }
                    });
                    // Bind Slot Time By Using SlotId  During Edit
                    $.ajax({
                        url: ""/Slot/GetShiftBySlotId?SlotId="" + result[0].SlotID,
                        type: ""GET"",
                        success: function (result) {
                            data = JSON.parse(result);
                            $(""#TimeFrom"").val(data.Slot_TimeFrom);
                            $(""#TimeTo"").val(data.Slot_TimeTo);
                        },
                        error: function (error) {
                            jsonValue = jQuery.parseJSON(error.responseText);
                            alert(""Error : "" + jsonValue);
                        }
                    });
                    //Bind Checkbox  Data  During Edit
                    $.each(result, function (i, item) {
                        $(""input[");
            WriteLiteral(@"type=checkbox][value="" + item.DaysId+""]"").prop(""checked"", true);
                    });
                    $('#Day').find(':checkbox').each(function () {
                        $(this).attr('checked', $('#' + id).is(':checked'));
                    });
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        return false;
    }

    //Reset
    function reset() {
        $('#hdnSMId').val("""");
        $(""#HospitalName"").val(""0"");
        $(""#SlotName"").val(""0"");
        $(""#TimeFrom"").val("""");
        $(""#TimeTo"").val("""");
        $(""#DoctorName"").val(""0"");
        $(""#Day"").val("""");
    }
    
    //Cancle
    $(""#btnReset"").click(function () {
        reset();
        if (getUrlVars()[""SMId""] != undefined) {
            window.location.href = ""/SlotMapping/ViewSlotMapping"";
        }
    })
    //Cascading Databind
    //Get All Slot By Hospital Id
    function GetA");
            WriteLiteral(@"llSlotByHId() {
        $.ajax({
            url: ""/Slot/GetSlotByHospitalId?HospitalID="" + $('#HospitalName').val(),
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.SlotID + "">"" + item.SlotName + ""</option>"";
                });
                $(""#SlotName"").html(v);
                GetDoctorByHId();
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
    }

    //Get Doctor by Hospital Id
    function GetDoctorByHId() {
        $.ajax({
            url: ""/SlotMapping/DoctorNameByHId?HospitalID="" + $('#HospitalName').val(),
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(r");
            WriteLiteral(@"esult);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.UserId + "">"" + item.UserName + ""</option>"";
                });
                $(""#DoctorName"").html(v);
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
    }

    //Get Shift Time By Slot Id
    function GetShiftTimeBySlotId() {
        $.ajax({
            url: ""/Slot/GetShiftBySlotId?SlotId="" + $('#SlotName').val(),
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(result);
                $(""#TimeFrom"").val(data.Slot_TimeFrom);
                $(""#TimeTo"").val(data.Slot_TimeTo);
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""E");
            WriteLiteral("rror : \" + jsonValue);\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PathoLab.Domain.SlotMappig.SlotMapping> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591