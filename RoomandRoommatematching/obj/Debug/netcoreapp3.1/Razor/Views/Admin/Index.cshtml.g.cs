#pragma checksum "C:\Users\Wanida\Desktop\RoomandRoommate\RoomandRoommatematching\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6897cc416c4e5d1fdcf0528d89ca5c972089cccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Wanida\Desktop\RoomandRoommate\RoomandRoommatematching\Views\_ViewImports.cshtml"
using RoomandRoommatematching;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wanida\Desktop\RoomandRoommate\RoomandRoommatematching\Views\_ViewImports.cshtml"
using RoomandRoommatematching.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6897cc416c4e5d1fdcf0528d89ca5c972089cccc", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8dd9ce15e636f87fb7f598386fc93145d8d9178", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Wanida\Desktop\RoomandRoommate\RoomandRoommatematching\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "AdminIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Admin</h1>\r\n\r\n<div>\r\n");
#nullable restore
#line 8 "C:\Users\Wanida\Desktop\RoomandRoommate\RoomandRoommatematching\Views\Admin\Index.cshtml"
     using (Html.BeginForm("SignIn", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <label for=""uname"">ชื่อหอพัก: </label>
        <input name=""nameDormitory"" type=""text"" />
        <br />
        <label for=""uname"">ราคาห้องพัก: </label>
        <input name=""priceDormitory"" type=""text"" />
        <br />
        <label for=""uname"">ค่าประกันหอพัก: </label>
        <input name=""InsurancefeeDormitory"" type=""text"" />
        <br />
        <label for=""uname"">สามารถอยู่ได้(จำนวนคน): </label>
        <input name=""people"" type=""text"" />
        <br />
        <label for=""uname"">ค่าน้ำ: </label>
        <input name=""Waterbill"" type=""text"" />
        <br />
        <label for=""uname"">ค่าไฟ: </label>
        <input name=""Electricitybill"" type=""text"" />
        <br />
        <label for=""uname"">ที่อยู่: </label>
        <input name=""address"" type=""text"" />
        <br />
        <label for=""uname"">เบอร์โทร: </label>
        <input name=""phoneNumber"" type=""text"" />
        <br />
        <label for=""uname"">Facebook: </label>
        <input name=""facebook"" type=""text"" />
");
            WriteLiteral("        <br />\r\n        <label for=\"uname\">Email: </label>\r\n        <input name=\"email\" type=\"text\" />\r\n        <br />\r\n        <p>กรุณาอัพโหลดรูปภาพหอพักของคุณ :</p>\r\n        <input type=\"file\" id=\"myFile\" name=\"filename\">\r\n        <br />\r\n");
            WriteLiteral("        <br />\r\n        <button name=\"btnSave\" type=\"submit\">บันทึก</button>\r\n        <button name=\"btnClear\" type=\"reset\">ยกเลิก</button>\r\n");
#nullable restore
#line 49 "C:\Users\Wanida\Desktop\RoomandRoommate\RoomandRoommatematching\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
