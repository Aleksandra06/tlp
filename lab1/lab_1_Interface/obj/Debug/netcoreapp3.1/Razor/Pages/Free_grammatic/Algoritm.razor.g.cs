#pragma checksum "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e12a4bd9ecc941acac8dd73ff518a165f7a8751d"
// <auto-generated/>
#pragma warning disable 1591
namespace lab_1_Interface.Pages.Free_grammatic
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using lab_1_Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using lab_1_Interface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
using lab_1_Interface.Models;

#line default
#line hidden
#nullable disable
    public partial class Algoritm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Выполнение</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    .name_r {\r\n        width: 3px;\r\n        text-align: center;\r\n    }\r\n    .reg {\r\n        width: 100px;\r\n        text-align: center;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<label class=\"pr-2\" style=\"width: 110px\">Терминалы</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "input_vt");
            __builder.AddAttribute(8, "placeholder", "Введите символы через запятую");
            __builder.AddAttribute(9, "style", "width: 270px");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                                                                                                   input_vt_text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => input_vt_text = __value, input_vt_text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                       inputVT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddMarkupContent(16, "Записать");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<br>\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, "<label class=\"pr-2\" style=\"width: 110px\">Нетерминалы</label>\r\n    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "id", "input_vn");
            __builder.AddAttribute(25, "placeholder", "Введите символы через запятую");
            __builder.AddAttribute(26, "style", "width: 270px");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                                                                                                   input_vn_text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => input_vn_text = __value, input_vn_text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                       inputVN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddMarkupContent(33, "Записать");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 37 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
 if (split_vt_text?.Length > 0) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.AddMarkupContent(37, "<label>Терминальный список</label>\r\n    ");
            __builder.OpenElement(38, "lu");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 40 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
         foreach (string list in split_vt_text) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.OpenElement(41, "li");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.AddContent(43, 
#nullable restore
#line 42 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                 list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 44 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 46 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 48 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
 if (split_vn_text?.Length > 0) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.AddMarkupContent(50, "<label>Нетерминальный список</label>\r\n    ");
            __builder.OpenElement(51, "lu");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 51 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
         foreach (string list in split_vn_text) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.OpenElement(54, "li");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.AddContent(56, 
#nullable restore
#line 53 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                 list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 55 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.AddContent(61, "    ");
            __builder.OpenElement(62, "div");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.AddMarkupContent(64, "<label class=\"pr-2\">Начальный нетерминал</label>\r\n        ");
            __builder.OpenElement(65, "form");
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "list", "nt");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                          grammatic.S

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => grammatic.S = __value, grammatic.S));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "datalist");
            __builder.AddAttribute(73, "id", "nt");
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 63 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                 foreach (string list in grammatic.VN) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                    ");
            __builder.OpenElement(76, "option");
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.AddContent(78, 
#nullable restore
#line 65 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                         list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 67 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.AddContent(85, "    ");
            __builder.OpenElement(86, "div");
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.AddMarkupContent(88, "<label class=\"pr-2\" style=\"width: 110px\">Начальный [</label>\r\n        ");
            __builder.OpenElement(89, "label");
            __builder.AddAttribute(90, "class", "pr-2");
            __builder.AddContent(91, 
#nullable restore
#line 74 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                             grammatic.S

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.AddMarkupContent(94, "<label class=\"pr-2\"> ] </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.AddContent(96, "    ");
            __builder.OpenElement(97, "div");
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.AddMarkupContent(99, "<label class=\"pr-2\" style=\"width: 110px\">Правила</label>\r\n        ");
            __builder.OpenElement(100, "div");
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "table");
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.AddMarkupContent(104, @"<thead>
                    <tr>
                        <td>
                            Нетерминал
                        </td>
                        <td></td>
                        <td>
                           Правило
                        </td>
                        <td></td>
                    </tr>
                </thead>
                
                ");
            __builder.OpenElement(105, "tr");
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "class", "name_r");
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.AddContent(110, 
#nullable restore
#line 97 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                         grammatic.S

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.AddMarkupContent(113, "<td class=\"name_r\">\r\n                        ->\r\n                    </td>\r\n                    ");
            __builder.AddMarkupContent(114, "<td class=\"reg\">\r\n                        <input type=\"text\" id=\"input_vt\" placeholder=\"Введите правило\">\r\n                    </td>\r\n                    ");
            __builder.AddMarkupContent(115, "<td class=\"reg\">\r\n                        <button class=\"btn btn-primary\" @*onclick=\"@save_regular\"*@>Записать</button>\r\n                    </td>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
            __builder.AddContent(120, "    ");
            __builder.AddMarkupContent(121, "<button class=\"btn btn-primary\">Записать</button>\r\n");
#nullable restore
#line 116 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\voen1\Desktop\-\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
       
    Grammatic grammatic = new Grammatic();
    string input_vt_text, input_vn_text;
    string[] split_vt_text, split_vn_text;
    int num_regulars = 0;

    void save_regulars()
    {
        num_regulars++;
    }

    void inputVT()
    {
        if (input_vt_text?.Length > 0) {
            split_vt_text = input_vt_text.Split(",");
            grammatic.VT?.Clear();
            grammatic.VT = new List<string>();
            foreach (string list in split_vt_text) {
                grammatic.VT.Add(list);
            }
        }
    }

    void inputVN()
    {
        if (input_vn_text?.Length > 0) {
            split_vn_text = input_vn_text.Split(",");
            grammatic.VN?.Clear();
            grammatic.VN = new List<string>();
            foreach (string list in split_vn_text) {
                grammatic.VN.Add(list);
            }
        }
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591