#pragma checksum "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "268129b813635df50afba6f47b33b02a61287aec"
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
#line 1 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using lab_1_Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using lab_1_Interface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
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
            __builder.AddMarkupContent(1, "<style>\r\n    .name_r, .input_vn_r {\r\n        width: 40px;\r\n        text-align: center;\r\n    }\r\n\r\n    .reg {\r\n        width: 100px;\r\n        text-align: center;\r\n    }\r\n</style>\r\n\r\n");
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
#line 26 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
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
#line 27 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
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
#line 32 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
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
#line 33 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
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
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.AddMarkupContent(36, "<label>Терминальный список</label>\r\n");
            __builder.OpenElement(37, "ul");
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 38 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
     foreach (string list in grammatic.VT) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "        ");
            __builder.OpenElement(40, "li");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddContent(42, 
#nullable restore
#line 40 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
             list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 42 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.AddMarkupContent(46, "<label>Нетерминальный список</label>\r\n");
            __builder.OpenElement(47, "ul");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 47 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
     foreach (string list in grammatic.VN) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.OpenElement(50, "li");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddContent(52, 
#nullable restore
#line 49 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
             list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 51 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n<br>");
            __builder.OpenElement(56, "h4");
            __builder.AddMarkupContent(57, "Всего правил: (");
            __builder.AddContent(58, 
#nullable restore
#line 54 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                        grammatic.Regulation.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "ul");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 57 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
     foreach (var regular in grammatic.Regulation) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "    ");
            __builder.OpenElement(64, "li");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "form");
            __builder.AddAttribute(67, "style", "float: left; ");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "list", "swap");
            __builder.AddAttribute(71, "style", "width: 50px;");
            __builder.AddAttribute(72, "placeholder", "Выберите элемент");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                            regular.left

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => regular.left = __value, regular.left));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "datalist");
            __builder.AddAttribute(77, "id", "swap");
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 62 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                 foreach (string list in grammatic.VN) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                    ");
            __builder.OpenElement(80, "option");
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.AddContent(82, 
#nullable restore
#line 64 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                         list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 66 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n        ");
            __builder.OpenElement(88, "span");
            __builder.AddAttribute(89, "style", "margin-left: 10px; ");
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 71 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
            foreach (var regularRight in regular.right) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "               ");
            __builder.AddMarkupContent(92, "<span> -> </span>\r\n");
#nullable restore
#line 73 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                foreach (var element in regularRight) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                   ");
            __builder.OpenElement(94, "span");
            __builder.AddContent(95, 
#nullable restore
#line 74 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                          element

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 75 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
               }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "               ");
            __builder.AddMarkupContent(98, "<span> | </span>\r\n");
#nullable restore
#line 77 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
           }

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 80 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n");
            __builder.OpenElement(103, "div");
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.OpenElement(105, "form");
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "list", "regular");
            __builder.AddAttribute(109, "style", "width: 185px;  margin-top: 10px; float: left; ");
            __builder.AddAttribute(110, "placeholder", "Выберите элемент");
            __builder.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                          newRegularLeft

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newRegularLeft = __value, newRegularLeft));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.OpenElement(114, "datalist");
            __builder.AddAttribute(115, "id", "regular");
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 87 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
             foreach (string list in grammatic.VN) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                ");
            __builder.OpenElement(118, "option");
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.AddContent(120, 
#nullable restore
#line 89 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                     list

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(121, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 91 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "type", "text");
            __builder.AddAttribute(128, "placeholder", "Введите правило");
            __builder.AddAttribute(129, "style", "width: 185px;  margin-top: 10px; margin-left: 10px; ");
            __builder.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                    newRegularRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newRegularRight = __value, newRegularRight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n    ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "class", "btn btn-primary");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
                                              onClickNewRegular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(136, "Записать");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\r\n");
            __builder.OpenElement(139, "div");
            __builder.AddMarkupContent(140, "\r\n    ");
            __builder.OpenElement(141, "span");
            __builder.AddContent(142, 
#nullable restore
#line 99 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
           debug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\voen1\Documents\Course_4\[ТЯП] Теория языков программирования\lab1\lab1\lab_1_Interface\Pages\Free_grammatic\Algoritm.razor"
       
    Grammatic grammatic = new Grammatic();

    string input_vt_text, input_vn_text;
    string[] split_vt_text, split_vn_text;

    string newRegularLeft, newRegularRight;

    static string debug;

    protected override void OnInitialized()
    {
        grammatic.VT = new List<string>();
        grammatic.VN = new List<string>();
        grammatic.Regulation = new List<Regular>();
        grammatic.lamb = new string("lamb");
    }

    void onClickNewRegular()
    {
        if (!string.IsNullOrWhiteSpace(newRegularLeft) && !(string.IsNullOrWhiteSpace(newRegularRight))) {

            grammatic.Regulation = ConvertStringToRegular(newRegularLeft + "->" + newRegularRight + "\r\n", grammatic);

        }
    }


    public static List<Regular> ConvertStringToRegular(string str, Grammatic grammatic)
    {
        List<Regular> list = new List<Regular>();
        while (str.Length > 1) {
            Regular regular = new Regular();
            regular.right = new List<List<string>>();
            var index = str.IndexOf("-");
            regular.left = str.Substring(0, index);

            str = str.Substring(index + 2);
            debug = ""; // DEBUG

            foreach (char iterator in str) {
                debug += (int)iterator;
            }

            index = str.IndexOf("\n");

            if (index < 0) {
                var tmp1 = ConvertStringToStringList(str.Substring(0), "|", grammatic);
                foreach (var tmp in tmp1) {
                    regular.right.Add(ConvertStringToStringList(tmp, grammatic));
                }
                list.Add(regular);
                break;
            }

            var tmp2 = ConvertStringToStringList(str.Substring(0, index), "|", grammatic);
            foreach (var tmp in tmp2) {
                regular.right.Add(ConvertStringToStringList(tmp, grammatic));
            }


            str = str.Substring(index + 1);
            list.Add(regular);
        }

        return list;
    }

    public static List<string> ConvertStringToStringList(string str, Grammatic grammatic)
    {
        List<string> list = new List<string>();
        // str = aaT | lamd
        int i = 0;
        int start = 0;

        if (grammatic.lamb.Equals(str)) {
            list.Add(grammatic.lamb);
            return list;
        }

        while (i < str.Length && grammatic.VT.FindIndex(t => t == str.Substring(i, 1)) > -1) {
            i++;
        }
        if (i > 0) {
            list.Add(str.Substring(start, i));
        }
        start = i;
        int j = 0;
        while (i < str.Length && grammatic.VN.FindIndex(t => t == str.Substring(i, 1)) > -1) {
            list.Add(str.Substring(start, 1));
            i++;
            start = i;
        }
        if (i > start) {
            list.Add(str.Substring(start, j));
        }

        start = i;
        j = 0;
        while (i < str.Length && grammatic.VT.FindIndex(t => t == str.Substring(i, 1)) > -1) {
            i++;
            j++;
        }

        if (i > start) {
            list.Add(str.Substring(start, j));
        }

        // list = aa, T
        return list;
    }

    private static List<string> ConvertStringToStringList(string str, string border, Grammatic grammatic)
    {
        List<string> list = new List<string>();
        while (str.Length > 0) {
            var index = str.IndexOf(border);
            if (index == -1) {
                break;
            }
            list.Add(str.Substring(0, index));
            str = str.Substring(index + 1);
        }

        var index1 = str.IndexOf("\n");
        if (index1 < 0) {
            list.Add(str.Substring(0));
        } else {
            list.Add(str.Substring(0, index1));
        }
        return list;
    }

    void inputVT()
    {
        if (!string.IsNullOrWhiteSpace(input_vt_text)) {
            split_vt_text = input_vt_text.Split(",");
            grammatic.VT = new List<string>();
            foreach (string list in split_vt_text) {
                grammatic.VT.Add(list);
            }
        }
    }

    void inputVN()
    {
        if (!string.IsNullOrWhiteSpace(input_vn_text)) {
            split_vn_text = input_vn_text.Split(",");
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
