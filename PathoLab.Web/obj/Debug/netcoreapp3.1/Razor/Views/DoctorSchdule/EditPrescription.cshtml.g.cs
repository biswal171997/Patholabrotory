#pragma checksum "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DoctorSchdule\EditPrescription.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "214ee8cdcc2f8807687ac587a98c885f9e38e8726ffd645ba5871fb38d60a471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoctorSchdule_EditPrescription), @"mvc.1.0.view", @"/Views/DoctorSchdule/EditPrescription.cshtml")]
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
#nullable restore
#line 1 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DoctorSchdule\EditPrescription.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"214ee8cdcc2f8807687ac587a98c885f9e38e8726ffd645ba5871fb38d60a471", @"/Views/DoctorSchdule/EditPrescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efe64be18ad298390ae23b73ed793dc8ec42f6099de9d3a886c7c094529c1c06", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DoctorSchdule_EditPrescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DoctorSchdule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewsPrescription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPrescription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DoctorSchdule\EditPrescription.cshtml"
  
    ViewData["Title"] = "EditPrescription";
    Layout = "~/Views/Shared/_LayoutaDoctorDynamic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .logo {
        flex: 1;
    }

        .logo img {
            width: 120px;
            height: 120px;
            float: left;
        }

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
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214ee8cdcc2f8807687ac587a98c885f9e38e8726ffd645ba5871fb38d60a4716462", async() => {
                WriteLiteral("View Prescription");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214ee8cdcc2f8807687ac587a98c885f9e38e8726ffd645ba5871fb38d60a4717961", async() => {
                WriteLiteral("Edit Prescription");
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
            WriteLiteral("\r\n\r\n                </ul>\r\n\r\n                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 1528, "\"", 1536, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
            <!--===================================================-->
            <hr />
            <!-- BASIC FORM ELEMENTS 1 -->
            <!--===================================================-->
            <div class=""card-body"">
                <!--Static-->
                <div class=""form-group row"">
                    <input type=""hidden"" id=""hdnPatientID"" />
                    <input type=""hidden"" id=""hdnPrescriptionId"" />
");
            WriteLiteral(@"                    <div class=""col-xs-12 col-md-3 col-xl-3"">
                        <label class=""control-label"" for=""RegdNo""  ><b>Regd No</b></label>
                        <input id=""txtRegdNo"" class=""form-control"" disabled />
                    </div>
                    <div class=""col-xs-12 col-md-4 col-xl-4"">
                        <input type=""hidden"" id=""hdnHospitalId""");
            BeginWriteAttribute("value", " value=\"", 2721, "\"", 2792, 1);
#nullable restore
#line 66 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DoctorSchdule\EditPrescription.cshtml"
WriteAttributeValue("", 2729, HttpContextAccessor.HttpContext.Session.GetInt32("HospitalID"), 2729, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <label class=\"control-label\" for=\"HospitalName\"><b>Hospital Name</b></label>\r\n                        <input id=\"txtHospitalName\" class=\"form-control\"  disabled");
            BeginWriteAttribute("value", " value=\"", 2982, "\"", 3056, 1);
#nullable restore
#line 68 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DoctorSchdule\EditPrescription.cshtml"
WriteAttributeValue("", 2990, HttpContextAccessor.HttpContext.Session.GetString("HospitalName"), 2990, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""col-xs-12 col-md-3 col-xl-3"">
                        <label class=""control-label""><b>Doctor Name</b></label>
                        <input id=""txtDoctorName"" class=""form-control"" disabled");
            BeginWriteAttribute("value", " value=\"", 3313, "\"", 3383, 1);
#nullable restore
#line 72 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\DoctorSchdule\EditPrescription.cshtml"
WriteAttributeValue("", 3321, HttpContextAccessor.HttpContext.Session.GetString("UserName"), 3321, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""col-xs-12 col-md-2 col-xl-2"">
                        <label class=""control-label"" for=""DateOfAppointment""><b>Date</b></label>
                        <input id=""txtDate"" disabled class=""form-control"" />
                    </div>
                    <div class=""col-xs-12 col-md-3 col-xl-3"">
                        <label class=""control-label""  for=""FullName""><b>Name</b></label>
                        <input id=""txtName"" disabled  class=""form-control"" />
                    </div>
                    <div class=""col-12 col-md-3 col-xl-3"">
                        <label class="" control-label"" for=""GuardianName""><b>Husband/Father/Mother   Name</b> </label>
                        <input id=""txtHFMName"" class=""form-control"" />
                    </div>
                    <div class=""col-12 col-md-2 col-xl-2"">
                        <label class=""control-label""  for=""Mobile""><b>Mobile No</b> </label>
                        <input ");
            WriteLiteral(@"id=""txtMobile"" disabled class=""form-control"" />
                    </div>
                    <div class=""col-12 col-md-2 col-xl-2"">
                        <label class=""control-label"" for=Email><b>Email</b></label>
                        <input id=""txtEmail"" disabled type=""email"" class=""form-control"" />
                    </div>
                    <div class=""col-12 col-md-1 col-xl-1"">
                        <label class=""control-label"" for=""Age""><b>Age</b> </label>
                        <input id=""txtAge"" disabled  class=""form-control"" />
                    </div> 
                    <div class=""col-12 col-md-1 col-xl-1"">
                        <label class=""control-label"" for=""Gender""><b>Gender</b> </label>
                        <input id=""txtGender"" disabled  class=""form-control"" />
                    </div>
                </div>
            </div>
            <!--===================================================-->
            <!-- END BASIC FORM ELEMENTS 1-->
         ");
            WriteLiteral(@"   <!--==============================================================================================================================================-->
            <hr />
            <!-- BASIC FORM ELEMENTS 2 -->
            <!--===================================================-->
            <div class=""card-body"">
                <div class=""form-group row"">
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <label class=""control-label"" for=""BloodPressure""> <b>Blood Pressure</b> </label>
                        <input type=""text"" id=""txtBloodPressure"" class=""form-control"" />
                        <label class="" control-label"" for=""Height""> <b> Height </b></label>
                        <input type=""text"" id=""txtHeight"" class=""form-control"" />
                        <label class="" control-label"" for=""Weight""> <b> Weight </b></label>
                        <input type=""text"" id=""txtWeight"" class=""form-control"" />
                        <label class=""contr");
            WriteLiteral(@"ol-label"" for=""OxygenLevel""> <b>Oxygen Level</b> </label>
                        <input type=""text"" id=""txtOxygenLevel"" class=""form-control"" />
                        <label class="" control-label"" for=""Pulse""> <b> Pulse </b></label>
                        <input type=""text"" id=""txtPulse"" class=""form-control"" />
                        <label class=""control-label"" for=""Temperature""> <b>Temperature </b> </label>
                        <input type=""text"" id=""txtTemperature"" class=""form-control"" />
                    </div>
                    <div class=""col-12 col-md-6 col-xl-8"">
                        <label class=""control-label"" for=""Symptoms""><b>Symptoms</b>  </label>
                        <textarea id=""txtSymptoms"" cols=""40"" rows=""6"" class=""form-control""></textarea>
                        <label class="" control-label"" for=""PatientHistory""><b>Patient History </b> </label>
                        <textarea id=""txtHistory"" cols=""40"" rows=""6"" class=""form-control""></textarea>
               ");
            WriteLiteral(@"     </div>
                </div>

                <hr />

                <div class=""form-group row"">
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <label class="" control-label"" for=""Dignosis""><b>  Dignosis Test</b> </label>
");
            WriteLiteral(@"                        <div id=""newinput""> <input type=""hidden"" id=""hdndignosiscount"" /></div>
                        <button id=""rowAdder"" type=""button"" class=""btn btn-dark pull-right"">
                            <span class=""bi bi-plus-square-dotted"">
                            </span> ADD
                        </button>
                    </div>
                    <div class=""col-12 col-md-6 col-xl-8"">
                        <label class="" control-label"" id=""txtPrescribeMedicine""> <b>Prescribe Medicine </b> </label>
                        <div>
                            <table id=""tblMedicine"">
                                <tr>
                                    <td>Medicine Name</td>
                                    <td>Dosages</td>
                                    <td>Duration</td>
                                    <td>Action</td>
                                </tr>
                                <tbody id=""tbody""></tbody>
                            </table><b");
            WriteLiteral(@"r />
                            <div class=""form-group row"">
                                <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                                <div class=""col-12 col-md-6 col-xl-4"">
                                    <button class=""btn btn-md btn-primary pull-right"" id=""addBtn"" type=""button""> Add </button>
");
            WriteLiteral(@"                                </div>
                            </div>
                        </div><br />
                        <div class=""form-group row"">
                            <div class=""col-12 col-md-10 col-xl-12"">
                                <label class=""control-label"" for=""OtherAdvice""><b>Other Advice</b>  </label>
                                <textarea id=""txtOtherAdvice"" cols=""40"" rows=""6"" class=""form-control""></textarea>
                            </div>
                        </div>
                    </div>
                </div>

                <hr />

                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                        <button class=""btn btn-danger mb-1"" onclick=""reset()""id=""btnReset"">Reset</button>
                    </d");
            WriteLiteral(@"iv>
                </div>


                <!--===================================================-->
                <!-- END BASIC FORM ELEMENTS 2 -->
            </div>
        </div>
    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/jquery-ui.js""></script>
<link href=""http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/themes/ui-lightness/jquery-ui.css"" rel=""stylesheet"" type=""text/css"" />

<script type=""text/javascript"">

    $(document).ready(function () {
        //breadcumb
        var PrescriptionId = getUrlVars()[""PrescriptionId""];
        var PatientID = getUrlVars()[""PatientID""];
        if (PrescriptionId != undefined && PatientID != undefined) {
            $(""#btnSubmit"").html(""Update"");
            $(""#btnReset"").html(""Cancel"");
            Edit(PrescriptionId, PatientID);
        }
    });
    //< !--===============================================");
            WriteLiteral(@"==== -->
    function reset() {
        window.location.href = ""/DoctorSchdule/ViewsPrescription"";
    }
    //< !--=================================================== -->
    //< !--=================================================== -->
    //UPDATE
    function Edit(PrescriptionId, PatientID) {
        $.ajax({
            url: ""/DoctorSchdule/GetPrescriptionDetailsByPId?PrescriptionId="" + PrescriptionId + ""&PatientID="" + PatientID,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                $('#hdnPatientID').val(result.PatientID);
                $('#hdnPrescriptionId').val(result.PrescriptionId);
                $(""#txtRegdNo"").val(result.RegdNo);
                $(""#hdnHospitalId"").val(result.HospitalID);
                $(""#txtHospitalName"").val(result.HospitalName);
                $(""#txtDate"").val(result.DateOfAppointment);
                $(""#txtName"").val(result.FullN");
            WriteLiteral(@"ame);
                $(""#txtHFMName"").val(result.GuardianName);
                $(""#txtMobile"").val(result.Mobile);
                $(""#txtEmail"").val(result.Email);
                $(""#txtAge"").val(result.Age);
                $(""#txtGender"").val(result.Gender);
                $('#txtHeight').val(result.Height);
                $('#txtWeight').val(result.Weight);
                $('#txtBloodPressure').val(result.BloodPressure);
                $('#txtOxygenLevel').val(result.OxygenLevel);
                $(""#txtPulse"").val(result.Pulse);
                $(""#txtTemperature"").val(result.Temperature);
                $('#txtSymptoms').val(result.Symptoms);
                $('#txtHistory').val(result.PatientHistory);
                $('#txtOtherAdvice').val(result.OtherAdvice);
                $.ajax({
                    url: ""/DoctorSchdule/GetDignosisByPId?PrescriptionId="" + PrescriptionId,
                    type: ""GET"",
                    success: function (result) {
                 ");
            WriteLiteral(@"       data = JSON.parse(result);
                        $.each(data, function (i, item) {
                            DignosisDataBindForEdit(item.DignosisID);
                        });
                        $(""#"" + id).html(v);
                    },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        alert(""Error : "" + jsonValue);
                    }
                });
                $.ajax({
                    url: ""/DoctorSchdule/GetMedicineByPId?PrescriptionId="" + PrescriptionId,
                    type: ""GET"",
                    success: function (result) {
                        data = JSON.parse(result);
                        MedicineDataBindForEdit(data);
                    },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        alert(""Error : "" + jsonValue);
                    }
 ");
            WriteLiteral(@"               });
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
    //< !--=================================================== -->

    //Dignosis Data Bind At The Time Of Edit
    function DignosisDataBindForEdit(value) {
        $(""#hdndignosiscount"").val(parseFloat($(""#hdndignosiscount"").val() + 1));//Dynamic Id for Dynamic Dropdown
        newRowAdd =
            '<div id=""row""> <div class=""input-group m-3""><select id=""ddlDignosis-' + $(""#hdndignosiscount"").val() + '""  class=""form-control"" >< option value = ""0"" > --Select--</option ></select >' +
            '<div class=""input-group-prepend"">' +
            '<button class=""btn btn-danger"" id=""DeleteRow"" type=""button"">' +
            '<i class=""fa fa-trash-o""></i></button> </div>' +
            '</div> </div>';
        $('#newinput').append(newRowAdd);
        GetDignosisOfEachDropdownById('ddlDignosis-' + $(""#hdndignosiscount"").val(), value)");
            WriteLiteral(@";
    };
    //< !--=================================================== -->
    //Adding Add More Option In Dignosis
    $(""#rowAdder"").click(function () {
        $(""#hdndignosiscount"").val(parseFloat($(""#hdndignosiscount"").val() + 1));//Dynamic Id for Dynamic Dropdown
        newRowAdd =
            '<div id=""row""> <div class=""input-group m-3""><select id=""ddlDignosis-' + $(""#hdndignosiscount"").val() + '""  class=""form-control"" >< option value = ""0"" > --Select--</option ></select >' +
            '<div class=""input-group-prepend"">' +
            '<button class=""btn btn-danger"" id=""DeleteRow"" type=""button"">' +
            '<i class=""fa fa-trash-o""></i></button> </div>' +
            '</div> </div>';
        $('#newinput').append(newRowAdd);
        GetDignosisOfEachDropdownById('ddlDignosis-' + $(""#hdndignosiscount"").val());
    });

    $(""body"").on(""click"", ""#DeleteRow"", function () {
        $(this).parents(""#row"").remove();
    })
    //< !--==============================================");
            WriteLiteral(@"===== -->
    //Dropdown data bind
    function GetDignosisOfEachDropdownById(id, value) {
        $.ajax({
            url: ""/DoctorSchdule/GetDignosis"",
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    if (value != undefined && value == item.DignosisID) {
                        v += ""<option value="" + item.DignosisID + "" selected>"" + item.Name + "" </option>"";
                    }
                    else {
                        v += ""<option value="" + item.DignosisID + "">"" + item.Name + "" </option>"";
                    }
                });
                $(""#"" + id).html(v);
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
    }
    //Add Textb");
            WriteLiteral(@"ox Inside The Table Cells
    // Denotes total number of rows
    var rowIdx = """";
    // jQuery button click event to add a row
    $('#addBtn').on('click', function () {
        // Adding a row inside the tbody.
        $('#tbody').append(`<tr id=""R${++rowIdx}"">
             <td class=""row-index text-center"">
             <input id=""txtMedicineName"" class=""inputs form-control m-input""><input type=""hidden"" id=""hdnMedicineId"" class=""form-control m-input"">
             </td>
              <td class=""row-index text-center"">
               <select id=""txtDoses"" class=""form-control"">
               <option value=""0"">--Select--</option>
               </select>
             </td>
              <td class=""row-index text-center"">
              <input id=""txtDuration"" type=""text"" maxlength = ""100"" size = ""8""class=""form-control m-input"">
             </td>
              <td class=""text-center"">
                <button class=""btn btn-danger remove""
                  type=""button"">Remove</button>
  ");
            WriteLiteral(@"              </td>
              </tr>`
        );
    });

    //< !--=================================================== -->
    //Medicine Data Bind At The Time Of Edit

    function MedicineDataBindForEdit(data) {
        $.each(data, function (i, items) {
            $.ajax({
                url: ""/Dose/DoseGetByMedId?MedicineId="" + items.Id,
                type: ""GET"",
                success: function (result) {
                    data = JSON.parse(result);
                    var DosesElement = ""<select id='txtDoses' class='form-control'><select<option value='0'>--Select--</option>"";
                    $.each(data, function (i, item) {
                        if (item.DoseId == items.DoseId) {
                            DosesElement += ""<option value="" + item.DoseId + "" selected>"" + item.DoseName + ""</option>""; 
                        }
                        else {
                            DosesElement += ""<option value="" + item.DoseId + "">"" + item.DoseName + ""</option>");
            WriteLiteral(@""";
                        }
                    });
                    DosesElement += ""</select>"";
                    // Denotes total number of rows
                    var rowIdx = """";
                    // Adding a row inside the tbody.
                    $('#tbody').append(`<tr id=""${++rowIdx}"">
                     <td class=""row-index text-center"">
                     <input id=""txtMedicineName"" value=""${items.MedicineName}"" class=""inputs form-control m-input""><input type=""hidden"" value=""${items.Id}"" id=""hdnMedicineId"" class=""form-control m-input"">
                     </td>
                     <td class=""row-index text-center"">
                     ${DosesElement}
                     </td>
                     <td class=""row-index text-center"">
                     <input id=""txtDuration"" value=""${items.Duration}"" type=""text"" maxlength = ""100"" size = ""1""class=""form-control m-input"">
                     </td>
                     <td class=""text-center"">
                     ");
            WriteLiteral(@"<button class=""btn btn-danger remove"" type=""button"">Remove</button>
                     </td>
                     </tr>`
                    );
                },
                error: function (error) {
                    jsonValue = jQuery.parseJSON(error.responseText);
                    alert(""Error : "" + jsonValue);
                }
            });
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
                var id = $(this).attr('id');
                // Getting the <p> inside the .row-index class.
                var idx = $(this).children('.row-index').children('p');
             ");
            WriteLiteral(@"   // Gets the row number from <tr> id.
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

    //Create
    $(""#btnSubmit"").click(function () {
        var selected = [];
        $('#newinput option:selected').each(function () {
            selected.push($(this).attr('value'));
        });
        // Array of data we'll retu
        var Items = []; //array declaring to store the records to send it to controller
        var entity = {};
        var tbl = document.getElementById('tbody');
        for (var i = 0; i < tbl.rows.length; i++) {
            var item1 = {};
            item1.Id = tbl.rows[i].children[0].childr");
            WriteLiteral(@"en[1].value;
            item1.DoseId = tbl.rows[i].children[1].children[0].value;
            item1.Duration = tbl.rows[i].children[2].children[0].value;
            //item1.MorningAfterMeal = tbl.rows[i].children[1].children[0].value;
            //item1.MorningBeforeMeal = tbl.rows[i].children[2].children[0].value;
            //item1.AfternoonAfterMeal = tbl.rows[i].children[3].children[0].value;
            //item1.AfternoonBeforeMeal = tbl.rows[i].children[4].children[0].value;
            //item1.NightAfterMeal = tbl.rows[i].children[5].children[0].value;
            //item1.NightBeforeMeal = tbl.rows[i].children[6].children[0].value;
            Items.push(item1);
        }
        entity.Medicines = Items;
        entity.PatientID = $(""#hdnPatientID"").val();
        entity.PrescriptionId = $(""#hdnPrescriptionId"").val();
        entity.HospitalID = $(""#hdnHospitalId"").val();
        entity.GuardianName = $(""#txtHFMName"").val();
        entity.Height = $(""#txtHeight"").val();
        en");
            WriteLiteral(@"tity.Weight = $(""#txtWeight"").val();
        entity.BloodPressure = $(""#txtBloodPressure"").val();
        entity.OxygenLevel = $(""#txtOxygenLevel"").val();
        entity.Pulse = $(""#txtPulse"").val();
        entity.Temperature = $(""#txtTemperature"").val();
        entity.Symptoms = $(""#txtSymptoms"").val();
        entity.PatientHistory = $(""#txtHistory"").val();
        entity.OtherAdvice = $(""#txtOtherAdvice"").val();
       
        entity.DignosisCommaSepareted = selected.join("", "");
       
        if (confirm(""Are you sure you want to Submit ?"")) {
            $.ajax({
                url: ""/DoctorSchdule/CreatePrescription"",
                data: entity,
                type: ""POST"",
                success: function (result) {
                    if (getUrlVars()[""PatientID""] != undefined) {
                        alert(result);
                        window.location.href = ""/DoctorSchdule/ViewsPrescription"";
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
    //Medicine AutoFill
    $(document).on('keypress', '.inputs', function () {
        $('#tblMedicine tbody tr').each(function (index) {
            var row = this;
            $(this).find(""td"").eq(0).find(""#txtMedicineName"").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '/DoctorSchdule/AutoComplete/',
                        data: { ""prefix"": request.term },
                        type: ""POST"",
                        success: function (data) {
                            response($.map(data, function (item) {
                                return item;
                            }))
                        },
                        error: function (respon");
            WriteLiteral(@"se) {
                            alert(response.responseText);
                        },
                        failure: function (response) {
                            alert(response.responseText);
                        }
                    });
                },
                select: function (e, i) {
                    $(row).find('td').find(""#hdnMedicineId"").val(i.item.val);
                },
                minLength: 1
            });
        });
    });
    //Medicine On Change
    $(document).on('change', '.inputs', function () {
        $('#tblMedicine tbody tr').each(function (index) {
            var row = this;
            $(this).find(""td"").eq(0).find(""#txtMedicineName"").blur(function () {
                $.ajax({
                    url: ""/Dose/DoseGetByMedId?MedicineId="" + $(row).find('td').eq(0).find(""#hdnMedicineId"").val(),
                    type: ""GET"",
                    success: function (result) {
                        data = JSON.parse(result);
 ");
            WriteLiteral(@"                       var v = ""<option value='0'>--Select--</option>"";
                        $.each(data, function (i, item) {
                            v += ""<option value="" + item.DoseId + "">"" + item.DoseName + ""</option>"";
                        });
                        $(row).find('td').next('td').find(""#txtDoses"").html(v);
                        //$(this).find(""td"").eq(1).find(""#txtDoses"").html(v);
                    },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        alert(""Error : "" + jsonValue);
                    }
                });
            });
        });
    });
    //< !--=================================================== -->

    //Cancle
    $(""#btnCancel"").click(function () {
        reset();
        if (getUrlVars()[""PatientID""] != undefined) {
            window.location.href = ""/DoctorSchdule/CreatePrescription"";
        }
    })

    //Cancle
    $(""#bt");
            WriteLiteral("nReset\").click(function () {\r\n        reset();\r\n        if (getUrlVars()[\"AppointmentId\"] != undefined) {\r\n        }\r\n    })\r\n</script>   ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
