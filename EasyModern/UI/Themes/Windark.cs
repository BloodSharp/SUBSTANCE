﻿using EasyModern.Core.Model;
using Hexa.NET.ImGui;
using System.Numerics;

namespace EasyModern.UI.Themes
{
    internal class Windark : ITheme
    {
        public string ID { get; set; } = "theme.windark";

        public bool Apply()
        {
            var style = ImGui.GetStyle();
            var colors = style.Colors;

            style.Alpha = 1.0f;
            style.DisabledAlpha = 0.6000000238418579f;
            style.WindowPadding = new Vector2(8.0f, 8.0f);
            style.WindowRounding = 8.399999618530273f;
            style.WindowBorderSize = 1.0f;
            style.WindowMinSize = new Vector2(32.0f, 32.0f);
            style.WindowTitleAlign = new Vector2(0.0f, 0.5f);
            style.WindowMenuButtonPosition = ImGuiDir.Right;
            style.ChildRounding = 3.0f;
            style.ChildBorderSize = 1.0f;
            style.PopupRounding = 3.0f;
            style.PopupBorderSize = 1.0f;
            style.FramePadding = new Vector2(4.0f, 3.0f);
            style.FrameRounding = 3.0f;
            style.FrameBorderSize = 1.0f;
            style.ItemSpacing = new Vector2(8.0f, 4.0f);
            style.ItemInnerSpacing = new Vector2(4.0f, 4.0f);
            style.CellPadding = new Vector2(4.0f, 2.0f);
            style.IndentSpacing = 21.0f;
            style.ColumnsMinSpacing = 6.0f;
            style.ScrollbarSize = 5.599999904632568f;
            style.ScrollbarRounding = 18.0f;
            style.GrabMinSize = 10.0f;
            style.GrabRounding = 3.0f;
            style.TabRounding = 3.0f;
            style.TabBorderSize = 0.0f;
            style.TabMinWidthForCloseButton = 0.0f;
            style.ColorButtonPosition = ImGuiDir.Right;
            style.ButtonTextAlign = new Vector2(0.5f, 0.5f);
            style.SelectableTextAlign = new Vector2(0.0f, 0.0f);

            style.Colors[(int)ImGuiCol.Text] = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            style.Colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.6000000238418579f, 0.6000000238418579f, 0.6000000238418579f, 1.0f);
            style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.125490203499794f, 0.125490203499794f, 0.125490203499794f, 1.0f);
            style.Colors[(int)ImGuiCol.ChildBg] = new Vector4(0.125490203499794f, 0.125490203499794f, 0.125490203499794f, 1.0f);
            style.Colors[(int)ImGuiCol.PopupBg] = new Vector4(0.168627455830574f, 0.168627455830574f, 0.168627455830574f, 1.0f);
            if (!Core.Instances.Settings.RGB_Color) style.Colors[(int)ImGuiCol.Border] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.168627455830574f, 0.168627455830574f, 0.168627455830574f, 1.0f);
            style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.2156862765550613f, 0.2156862765550613f, 0.2156862765550613f, 1.0f);
            style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.125490203499794f, 0.125490203499794f, 0.125490203499794f, 1.0f);
            style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.168627455830574f, 0.168627455830574f, 0.168627455830574f, 1.0f);
            style.Colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.125490203499794f, 0.125490203499794f, 0.125490203499794f, 1.0f);
            style.Colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.168627455830574f, 0.168627455830574f, 0.168627455830574f, 1.0f);
            style.Colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.125490203499794f, 0.125490203499794f, 0.125490203499794f, 1.0f);
            style.Colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.3019607961177826f, 0.3019607961177826f, 0.3019607961177826f, 1.0f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.3490196168422699f, 0.3490196168422699f, 0.3490196168422699f, 1.0f);
            style.Colors[(int)ImGuiCol.CheckMark] = new Vector4(0.0f, 0.4705882370471954f, 0.843137264251709f, 1.0f);
            style.Colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.0f, 0.4705882370471954f, 0.843137264251709f, 1.0f);
            style.Colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.0f, 0.3294117748737335f, 0.6000000238418579f, 1.0f);
            style.Colors[(int)ImGuiCol.Button] = new Vector4(0.168627455830574f, 0.168627455830574f, 0.168627455830574f, 1.0f);
            style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.2156862765550613f, 0.2156862765550613f, 0.2156862765550613f, 1.0f);
            style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.Header] = new Vector4(0.2156862765550613f, 0.2156862765550613f, 0.2156862765550613f, 1.0f);
            style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.3019607961177826f, 0.3019607961177826f, 0.3019607961177826f, 1.0f);
            style.Colors[(int)ImGuiCol.Separator] = new Vector4(0.2156862765550613f, 0.2156862765550613f, 0.2156862765550613f, 1.0f);
            style.Colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.3019607961177826f, 0.3019607961177826f, 0.3019607961177826f, 1.0f);
            style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.2156862765550613f, 0.2156862765550613f, 0.2156862765550613f, 1.0f);
            style.Colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.250980406999588f, 0.250980406999588f, 0.250980406999588f, 1.0f);
            style.Colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.3019607961177826f, 0.3019607961177826f, 0.3019607961177826f, 1.0f);
            style.Colors[(int)ImGuiCol.Tab] = new Vector4(0.168627455830574f, 0.168627455830574f, 0.168627455830574f, 1.0f);
            style.Colors[(int)ImGuiCol.TabHovered] = new Vector4(0.2156862765550613f, 0.2156862765550613f, 0.2156862765550613f, 1.0f);

            style.Colors[(int)ImGuiCol.PlotLines] = new Vector4(0.0f, 0.4705882370471954f, 0.843137264251709f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(0.0f, 0.3294117748737335f, 0.6000000238418579f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.0f, 0.4705882370471954f, 0.843137264251709f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(0.0f, 0.3294117748737335f, 0.6000000238418579f, 1.0f);
            style.Colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(0.1882352977991104f, 0.1882352977991104f, 0.2000000029802322f, 1.0f);
            style.Colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(0.3098039329051971f, 0.3098039329051971f, 0.3490196168422699f, 1.0f);
            style.Colors[(int)ImGuiCol.TableBorderLight] = new Vector4(0.2274509817361832f, 0.2274509817361832f, 0.2470588237047195f, 1.0f);
            style.Colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            style.Colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(1.0f, 1.0f, 1.0f, 0.05999999865889549f);
            style.Colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.0f, 0.4705882370471954f, 0.843137264251709f, 1.0f);
            style.Colors[(int)ImGuiCol.DragDropTarget] = new Vector4(1.0f, 1.0f, 0.0f, 0.8999999761581421f);
            style.Colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(1.0f, 1.0f, 1.0f, 0.699999988079071f);
            style.Colors[(int)ImGuiCol.NavWindowingDimBg] = new Vector4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.2000000029802322f);
            style.Colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.3499999940395355f);
            return true;
        }
    }
}
