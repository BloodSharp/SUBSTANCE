﻿using EasyModern.Core.Model;
using Hexa.NET.ImGui;
using System.Numerics;

namespace EasyModern.UI.Themes
{
    internal class DUCKRED : ITheme
    {
        public string ID { get; set; } = "theme.duckred";

        public bool Apply()
        {
            var style = ImGui.GetStyle();
            var colors = style.Colors;

            style.Alpha = 1.0f;
            style.DisabledAlpha = 0.6000000238418579f;
            style.WindowPadding = new Vector2(8.0f, 8.0f);
            style.WindowRounding = 0.0f;
            style.WindowBorderSize = 1.0f;
            style.WindowMinSize = new Vector2(32.0f, 32.0f);
            style.WindowTitleAlign = new Vector2(0.5f, 0.5f);
            style.WindowMenuButtonPosition = ImGuiDir.Left;
            style.ChildRounding = 0.0f;
            style.ChildBorderSize = 1.0f;
            style.PopupRounding = 0.0f;
            style.PopupBorderSize = 1.0f;
            style.FramePadding = new Vector2(4.0f, 3.0f);
            style.FrameRounding = 0.0f;
            style.FrameBorderSize = 0.0f;
            style.ItemSpacing = new Vector2(8.0f, 4.0f);
            style.ItemInnerSpacing = new Vector2(4.0f, 4.0f);
            style.CellPadding = new Vector2(4.0f, 2.0f);
            style.IndentSpacing = 21.0f;
            style.ColumnsMinSpacing = 6.0f;
            style.ScrollbarSize = 14.0f;
            style.ScrollbarRounding = 0.0f;
            style.GrabMinSize = 10.0f;
            style.GrabRounding = 0.0f;
            style.TabRounding = 0.0f;
            style.TabBorderSize = 0.0f;
            style.TabMinWidthForCloseButton = 0.0f;
            style.ColorButtonPosition = ImGuiDir.Right;
            style.ButtonTextAlign = new Vector2(0.5f, 0.5f);
            style.SelectableTextAlign = new Vector2(0.0f, 0.0f);

            style.Colors[(int)ImGuiCol.Text] = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            style.Colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.4980392158031464f, 0.4980392158031464f, 0.4980392158031464f, 1.0f);
            style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.03921568766236305f, 0.03921568766236305f, 0.03921568766236305f, 1.0f);
            style.Colors[(int)ImGuiCol.ChildBg] = new Vector4(0.05490196123719215f, 0.05490196123719215f, 0.05490196123719215f, 1.0f);
            style.Colors[(int)ImGuiCol.PopupBg] = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
            if (!Core.Instances.Settings.RGB_Color) style.Colors[(int)ImGuiCol.Border] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.1176470592617989f, 0.1176470592617989f, 0.1176470592617989f, 1.0f);
            style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(1.0f, 0.0f, 0.0f, 0.5647059082984924f);
            style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(1.0f, 0.0f, 0.0f, 0.5647059082984924f);
            style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.03921568766236305f, 0.03921568766236305f, 0.03921568766236305f, 1.0f);
            style.Colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            style.Colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.0784313753247261f, 0.0784313753247261f, 0.0784313753247261f, 0.9411764740943909f);
            style.Colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(1.0f, 0.0f, 0.0f, 0.5647059082984924f);
            style.Colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(1.0f, 0.0f, 0.0f, 0.501960813999176f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.CheckMark] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.SliderGrab] = new Vector4(1.0f, 0.0f, 0.0f, 0.8154506683349609f);
            style.Colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(1.0f, 0.0f, 0.0f, 0.8156862854957581f);
            style.Colors[(int)ImGuiCol.Button] = new Vector4(1.0f, 0.0f, 0.0f, 0.501960813999176f);
            style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(1.0f, 0.0f, 0.0f, 0.7450980544090271f);
            style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.Header] = new Vector4(1.0f, 0.0f, 0.0f, 0.6566523313522339f);
            style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(1.0f, 0.0f, 0.0f, 0.8039215803146362f);
            style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.Separator] = new Vector4(0.0784313753247261f, 0.0784313753247261f, 0.0784313753247261f, 0.501960813999176f);
            style.Colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.0784313753247261f, 0.0784313753247261f, 0.0784313753247261f, 0.6695278882980347f);
            style.Colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.0784313753247261f, 0.0784313753247261f, 0.0784313753247261f, 0.9570815563201904f);
            style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.1019607856869698f, 0.1137254908680916f, 0.1294117718935013f, 0.2000000029802322f);
            style.Colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.2039215713739395f, 0.2078431397676468f, 0.2156862765550613f, 0.2000000029802322f);
            style.Colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.3019607961177826f, 0.3019607961177826f, 0.3019607961177826f, 0.2000000029802322f);
            style.Colors[(int)ImGuiCol.Tab] = new Vector4(1.0f, 0.0f, 0.0f, 0.4392156898975372f);
            style.Colors[(int)ImGuiCol.TabHovered] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotLines] = new Vector4(0.6078431606292725f, 0.6078431606292725f, 0.6078431606292725f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(0.9490196108818054f, 0.3450980484485626f, 0.3450980484485626f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.9490196108818054f, 0.3450980484485626f, 0.3450980484485626f, 1.0f);
            style.Colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(0.4274509847164154f, 0.3607843220233917f, 0.3607843220233917f, 1.0f);
            style.Colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(1.0f, 0.0f, 0.0f, 0.7124463319778442f);
            style.Colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.TableBorderLight] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(0.196078434586525f, 0.196078434586525f, 0.196078434586525f, 0.6274510025978088f);
            style.Colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            style.Colors[(int)ImGuiCol.DragDropTarget] = new Vector4(0.2588235437870026f, 0.2705882489681244f, 0.3803921639919281f, 1.0f);
            style.Colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(1.0f, 1.0f, 1.0f, 0.699999988079071f);
            style.Colors[(int)ImGuiCol.NavWindowingDimBg] = new Vector4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.2000000029802322f);
            style.Colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.3499999940395355f);

            return true;
        }
    }
}
