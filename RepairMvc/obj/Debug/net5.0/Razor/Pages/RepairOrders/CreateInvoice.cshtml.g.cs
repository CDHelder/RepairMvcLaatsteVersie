#pragma checksum "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e50cd85ae5d231d0fb71f6ae9193bc5c1607d188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RepairMvc.Pages.RepairOrders.Pages_RepairOrders_CreateInvoice), @"mvc.1.0.razor-page", @"/Pages/RepairOrders/CreateInvoice.cshtml")]
namespace RepairMvc.Pages.RepairOrders
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
#line 1 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\_ViewImports.cshtml"
using RepairMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\_ViewImports.cshtml"
using RepairMvc.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50cd85ae5d231d0fb71f6ae9193bc5c1607d188", @"/Pages/RepairOrders/CreateInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14434d34d2a38496f09da1635f8ac95fb9a0957f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RepairOrders_CreateInvoice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
  
    double TotalCost = 0;
    double TaxesTotalCost = 0;
    int CostEachHour = 15;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e50cd85ae5d231d0fb71f6ae9193bc5c1607d1883786", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>HTML Invoice Template</title>

    <style>
        .invoice-box {
            max-width: 800px;
            margin: auto;
            padding: 30px;
            border: 1px solid #eee;
            box-shadow: 0 0 10px rgba(0, 0, 0, .15);
            font-size: 16px;
            line-height: 24px;
            font-family: 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif;
            color: #555;
        }

            .invoice-box table {
                width: 100%;
                line-height: inherit;
                text-align: left;
            }

                .invoice-box table td {
                    padding: 5px;
                    vertical-align: top;
                }

                .invoice-box table tr td:nth-child(2) {
                    text-align: right;
                }

                .invoice-box table tr.top table td {
                    padding-bottom: 20px;
                }

                    .invoice-box table tr.top table td");
                WriteLiteral(@".title {
                        font-size: 45px;
                        line-height: 45px;
                        color: #333;
                    }

                .invoice-box table tr.information table td {
                    padding-bottom: 40px;
                }

                .invoice-box table tr.heading td {
                    background: #eee;
                    border-bottom: 1px solid #ddd;
                    font-weight: bold;
                }

                .invoice-box table tr.details td {
                    padding-bottom: 20px;
                }

                .invoice-box table tr.item td {
                    border-bottom: 1px solid #eee;
                }

                .invoice-box table tr.item.last td {
                    border-bottom: none;
                }

                .invoice-box table tr.total td:nth-child(2) {
                    border-top: 2px solid #eee;
                    font-weight: bold;
                }

                .invoice-box table tr.in");
                WriteLiteral(@"formation table td {
                    width: 100%;
                    display: block;
                    text-align: center;
                }

        /** RTL **/
        .rtl {
            direction: rtl;
            font-family: Tahoma, 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif;
        }

            .rtl table {
                text-align: right;
            }

                .rtl table tr td:nth-child(2) {
                    text-align: left;
                }

        .nowrap {
            white-space: nowrap;
            color: grey;
        }
    </style>
    
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.2.6/jquery.min.js""></script>
");
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
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e50cd85ae5d231d0fb71f6ae9193bc5c1607d1887569", async() => {
                WriteLiteral(@"
    <div class=""invoice-box"">
        <table cellpadding=""0"" cellspacing=""0"">
            <tr class=""top"">
                <td colspan=""2"">
                    <table>
                        <tr>
                            <td class=""title"">
                                <img src=""https://images.assetsdelivery.com/compings_v2/bestvectorstock/bestvectorstock1808/bestvectorstock180810483.jpg"" style=""width:25%; max-width:300px;"">
                            </td>

                            <td>
                                Invoice #: ");
#nullable restore
#line 120 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                      Write(Model.Order.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n                                Created: ");
#nullable restore
#line 121 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                    Write(DateTime.Now.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n                                Due: ");
#nullable restore
#line 122 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                Write(DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

            <tr class=""information"">
                <td colspan=""2"">
                    <table>
                        <tr>
                            <td>
                                Computer RepairShop, Inc.<br>
                                Daam Fockemalaan 22<br>
                                Amersfoort, 3818 KG<br>
                                Computer");
                WriteLiteral("@Repairshop.com<br>\n                                +31 0612345678\n                            </td>\n                            <td>\n                                <strong>Bill to:</strong><br>\n                                Client ID: ");
#nullable restore
#line 142 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                      Write(ViewBag.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n                                ");
#nullable restore
#line 143 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                           Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n                                ");
#nullable restore
#line 144 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                           Write(ViewBag.UserEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n                                ");
#nullable restore
#line 145 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                           Write(ViewBag.UserPhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

            <tr class=""heading"">
                <td>
                    Description
                </td>

                <td>
                    Price
                </td>
            </tr>

            <tr class=""item"">
                <td>
                    <u>Parts</u>
                </td>
            </tr>
            
");
#nullable restore
#line 168 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part1Quantity > 0 && ViewBag.PartID1Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part1Tr\">\n                <td>\n                    ");
#nullable restore
#line 172 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 177 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part1Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 177 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID1Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 178 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part1Quantity * ViewBag.PartID1Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 179 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID1Price * Model.Order.Part1Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 183 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part2Quantity > 0 && ViewBag.PartID2Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part2Tr\">\n                <td>\n                    ");
#nullable restore
#line 188 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 193 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part2Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 193 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID2Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 194 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part2Quantity * ViewBag.PartID2Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 195 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID2Price * Model.Order.Part2Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 199 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part3Quantity > 0 && ViewBag.PartID3Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part3Tr\">\n                <td>\n                    ");
#nullable restore
#line 204 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID3);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 209 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part3Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 209 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID3Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 210 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part3Quantity * ViewBag.PartID3Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 211 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID3Price * Model.Order.Part3Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 215 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 216 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part4Quantity > 0 && ViewBag.PartID4Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part4Tr\">\n                <td>\n                    ");
#nullable restore
#line 220 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID4);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 225 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part4Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 225 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID4Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 226 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part4Quantity * ViewBag.PartID4Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 227 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID4Price * Model.Order.Part4Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 231 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 232 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part5Quantity > 0 && ViewBag.PartID5Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part5Tr\">\n                <td>\n                    ");
#nullable restore
#line 236 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID5);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 241 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part5Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 241 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID5Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 242 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part5Quantity * ViewBag.PartID5Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 243 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID5Price * Model.Order.Part5Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 247 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 248 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part6Quantity > 0 && ViewBag.PartID6Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part6Tr\">\n                <td>\n                    ");
#nullable restore
#line 252 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID6);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 257 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part6Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 257 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID6Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 258 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part6Quantity * ViewBag.PartID6Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 259 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID6Price * Model.Order.Part6Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 263 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 264 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part7Quantity > 0 && ViewBag.PartID7Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part7Tr\">\n                <td>\n                    ");
#nullable restore
#line 268 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID7);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 273 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part7Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 273 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID7Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 274 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part7Quantity * ViewBag.PartID7Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 275 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID7Price * Model.Order.Part7Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 279 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 280 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
             if (Model.Order.Part8Quantity > 0 && ViewBag.PartID8Price > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\" id=\"part8Tr\">\n                <td>\n                    ");
#nullable restore
#line 284 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
               Write(ViewBag.PartID8);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n\n                <td>\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 289 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.Part8Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X € ");
#nullable restore
#line 289 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                  Write(ViewBag.PartID8Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 290 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(Model.Order.Part8Quantity * ViewBag.PartID8Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span style=\"display:none;\"> ");
#nullable restore
#line 291 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                 Write(TotalCost = TotalCost + Convert.ToDouble(ViewBag.PartID8Price * Model.Order.Part8Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 295 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"item\">\n                <td>\n                    <u><br><br />Repair Labor</u>\n                </td>\n\n                <td>\n                    <br><br />\n                    <span class=\"nowrap\">\n                        ");
#nullable restore
#line 304 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                   Write(Model.Order.HoursWorked);

#line default
#line hidden
#nullable disable
                WriteLiteral(" hours  X € ");
#nullable restore
#line 304 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                       Write(CostEachHour);

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\n                        <span style=\"color:black\"> € ");
#nullable restore
#line 305 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                                Write(String.Format("{0:0.00}", (Model.Order.HoursWorked * CostEachHour)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    </span>\n\n                    <span style=\"display:none;\"> ");
#nullable restore
#line 308 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                             Write(TotalCost = TotalCost + (Model.Order.HoursWorked * CostEachHour));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n                </td>\n            </tr>\n\n            <tr class=\"item last\">\n                <td>\n                    Work Report: <br>\n                    <span style=\"color:grey\">");
#nullable restore
#line 315 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                        Write(Model.Order.WorkReport);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                </td>\n            </tr>\n\n            <tr class=\"total\">\n                <td></td>\n\n                <td>\n                    Subtotal: € &nbsp; ");
#nullable restore
#line 323 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                  Write(String.Format("{0:0.00}", TotalCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\n                    Taxes (21%): € &nbsp; ");
#nullable restore
#line 324 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                                     Write(Math.Round((TaxesTotalCost = TotalCost * 0.21), 2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n            </tr>\n\n            <tr class=\"total\">\n                <td></td>\n\n                <td>\n                    Total: € ");
#nullable restore
#line 332 "C:\Users\CDHel\Desktop\RepairShop_Final-main\RepairMvc\Pages\RepairOrders\CreateInvoice.cshtml"
                        Write(Math.Round((TotalCost + TaxesTotalCost), 2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n            </tr>\n        </table>\n    </div>\n\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RepairShop_Razor.Pages.RepairOrders.CreateInvoice> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RepairShop_Razor.Pages.RepairOrders.CreateInvoice> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RepairShop_Razor.Pages.RepairOrders.CreateInvoice>)PageContext?.ViewData;
        public RepairShop_Razor.Pages.RepairOrders.CreateInvoice Model => ViewData.Model;
    }
}
#pragma warning restore 1591
