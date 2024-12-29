﻿using Hexa.NET.ImGui;
using System;
using System.Numerics;

namespace EasyModern.SDK
{

    public static class ImGuiDrawingUtils
    {
        /// <summary>
        /// Dibuja un rectángulo sin relleno.
        /// </summary>
        public static void DrawRect(ImDrawListPtr drawList, int x, int y, int w, int h, Vector4 color, float stroke = 1.0f)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            Vector2 min = new Vector2(x, y);
            Vector2 max = new Vector2(x + w, y + h);
            drawList.AddRect(min, max, colU32, 0.0f, ImDrawFlags.None, stroke);
        }

        /// <summary>
        /// Dibuja un rectángulo relleno.
        /// </summary>
        public static void DrawFillRect(ImDrawListPtr drawList, int x, int y, int w, int h, Vector4 color)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            Vector2 min = new Vector2(x, y);
            Vector2 max = new Vector2(x + w, y + h);
            drawList.AddRectFilled(min, max, colU32);
        }

        /// <summary>
        /// Dibuja un rectángulo sin relleno, mostrando solo las esquinas.
        /// </summary>
        /// <param name="drawList">El ImDrawListPtr en el que dibujamos.</param>
        /// <param name="x">Posición X inicial.</param>
        /// <param name="y">Posición Y inicial.</param>
        /// <param name="w">Ancho del rectángulo.</param>
        /// <param name="h">Alto del rectángulo.</param>
        /// <param name="color">Color en formato Vector4(R,G,B,A).</param>
        /// <param name="stroke">Grosor de las líneas.</param>
        /// <param name="cornerSize">Longitud de cada esquina.</param>
        public static void DrawCornerRect(
            ImDrawListPtr drawList,
            int x, int y,
            int w, int h,
            Vector4 color,
            float stroke = 1.0f,
            int cornerSize = 10)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);

            // Calculamos las coordenadas mínimas y máximas.
            int x2 = x + w;
            int y2 = y + h;

            // Asegurar que cornerSize no exceda el ancho/alto
            cornerSize = Math.Min(cornerSize, w / 2);
            cornerSize = Math.Min(cornerSize, h / 2);

            // Esquinas: Dibujamos 8 líneas en total (2 por esquina).

            // Esquina superior izquierda
            // ┌
            drawList.AddLine(new Vector2(x, y), new Vector2(x + cornerSize, y), colU32, stroke);
            drawList.AddLine(new Vector2(x, y), new Vector2(x, y + cornerSize), colU32, stroke);

            // Esquina superior derecha
            // ┐
            drawList.AddLine(new Vector2(x2, y), new Vector2(x2 - cornerSize, y), colU32, stroke);
            drawList.AddLine(new Vector2(x2, y), new Vector2(x2, y + cornerSize), colU32, stroke);

            // Esquina inferior izquierda
            // └
            drawList.AddLine(new Vector2(x, y2), new Vector2(x + cornerSize, y2), colU32, stroke);
            drawList.AddLine(new Vector2(x, y2), new Vector2(x, y2 - cornerSize), colU32, stroke);

            // Esquina inferior derecha
            // ┘
            drawList.AddLine(new Vector2(x2, y2), new Vector2(x2 - cornerSize, y2), colU32, stroke);
            drawList.AddLine(new Vector2(x2, y2), new Vector2(x2, y2 - cornerSize), colU32, stroke);
        }


        ///// <summary>
        ///// Dibuja un rectángulo (sobrecarga) con trazo distinto.
        ///// </summary>
        //public static void DrawRect(ImDrawListPtr drawList, int x, int y, int w, int h, Vector4 color, float stroke)
        //{
        //    DrawRect(drawList, x, y, w, h, color, stroke);
        //}

        /// <summary>
        /// Dibuja un triángulo relleno.
        /// </summary>
        public static void DrawTriangle(ImDrawListPtr drawList, Vector2[] pts, Vector4 color)
        {
            if (pts.Length < 3) return;
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            drawList.AddTriangleFilled(pts[0], pts[1], pts[2], colU32);
        }

        /// <summary>
        /// Dibuja texto en la posición especificada (sin outline).
        /// </summary>
        public static void DrawText(ImDrawListPtr drawList, int x, int y, string text, Vector4 color)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            Vector2 pos = new Vector2(x, y);
            drawList.AddText(pos, colU32, text);
        }

        /// <summary>
        /// Dibuja texto con outline opcional (outline = true => dibuja contorno negro).
        /// </summary>
        public static void DrawText(ImDrawListPtr drawList, int x, int y, string text, Vector4 color, bool outline)
        {
            if (outline)
            {
                // Offset manual en 4 direcciones o diagonal, según preferencia
                Vector4 black = new Vector4(0, 0, 0, 1);
                uint blackU32 = ImGui.ColorConvertFloat4ToU32(black);
                Vector2 pos = new Vector2(x, y);
                drawList.AddText(new Vector2(pos.X + 1, pos.Y + 1), blackU32, text);
            }
            // Texto principal
            DrawText(drawList, x, y, text, color);
        }

        /// <summary>
        /// Dibuja texto centrado dentro de un rectángulo.
        /// </summary>
        public static void DrawTextCenter(ImDrawListPtr drawList, int x, int y, int w, int h, string text, Vector4 color, bool outline = false)
        {
            // Calculamos el tamaño del texto
            var size = ImGui.CalcTextSize(text);
            // Centramos el texto
            float textX = x + (w - size.X) / 2.0f;
            float textY = y + (h - size.Y) / 2.0f;
            if (outline)
            {
                Vector4 black = new Vector4(0, 0, 0, 1);
                uint blackU32 = ImGui.ColorConvertFloat4ToU32(black);
                drawList.AddText(new Vector2(textX + 1, textY + 1), blackU32, text);
            }
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            drawList.AddText(new Vector2(textX, textY), colU32, text);
        }

        /// <summary>
        /// Dibuja una línea entre dos puntos.
        /// </summary>
        public static void DrawLine(ImDrawListPtr drawList, int x1, int y1, int x2, int y2, Vector4 color, float thickness = 1.0f)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            drawList.AddLine(new Vector2(x1, y1), new Vector2(x2, y2), colU32, thickness);
        }

        /// <summary>
        /// Dibuja un círculo.
        /// </summary>
        public static void DrawCircle(ImDrawListPtr drawList, int x, int y, float radius, Vector4 color, float thickness = 1.0f, int segments = 12)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            drawList.AddCircle(new Vector2(x, y), radius, colU32, segments, thickness);
        }

        /// <summary>
        /// Dibuja una línea en la posición indicada, usando Dear ImGui.
        /// </summary>
        /// <param name="drawList">El ImDrawListPtr de la ventana (generalmente obtenido con ImGui.GetWindowDrawList()).</param>
        /// <param name="start">Inicio de la línea (Vector3, pero solo se usarán X e Y).</param>
        /// <param name="end">Fin de la línea (Vector3, pero solo se usarán X e Y).</param>
        /// <param name="color">Color de SharpDX a convertir en Vector4 para Dear ImGui.</param>
        /// <param name="thickness">Grosor de la línea.</param>
        public static void DrawLine(ImDrawListPtr drawList, Vector3 start, Vector3 end, Vector4 imguiColor, float thickness = 1.0f)
        {
            // Convertir SharpDX.Color a Vector4
            uint colU32 = ImGui.ColorConvertFloat4ToU32(imguiColor);

            // Dibujar la línea en ImGui
            drawList.AddLine(
                new Vector2(start.X, start.Y),
                new Vector2(end.X, end.Y),
                colU32,
                thickness
            );
        }

        /// <summary>
        /// Dibuja un círculo relleno.
        /// </summary>
        public static void DrawFillCircle(ImDrawListPtr drawList, int x, int y, float radius, Vector4 color, int segments = 12)
        {
            uint colU32 = ImGui.ColorConvertFloat4ToU32(color);
            drawList.AddCircleFilled(new Vector2(x, y), radius, colU32, segments);
        }

        /// <summary>
        /// Dibuja una imagen (sin rotación).
        /// NOTA: En ImGui, la imagen se representa con ImTextureID.
        /// </summary>
        public static void DrawImage(ImDrawListPtr drawList, ImTextureID textureId, int x, int y, int w, int h)
        {
            if (textureId.IsNull) return;
            drawList.AddImage(textureId, new Vector2(x, y), new Vector2(x + w, y + h));
        }

        /// <summary>
        /// Dibuja una imagen con rotación manual (requiere cálculo de vértices).
        /// EJEMPLO simple: rotar alrededor del centro. 
        /// Para un soporte completo, habría que usar AddImageQuad con transformaciones.
        /// </summary>
        public static void DrawImageRotated(ImDrawListPtr drawList, ImTextureID textureId, int x, int y, int w, int h, float angleRadians)
        {
            if (textureId.IsNull) return;

            // Centro del rectángulo
            float cx = x + w * 0.5f;
            float cy = y + h * 0.5f;

            // Calcular vértices rotados (AddImageQuad)
            Vector2[] points = new Vector2[4];
            points[0] = Rotate(new Vector2(x, y), new Vector2(cx, cy), angleRadians);
            points[1] = Rotate(new Vector2(x + w, y), new Vector2(cx, cy), angleRadians);
            points[2] = Rotate(new Vector2(x + w, y + h), new Vector2(cx, cy), angleRadians);
            points[3] = Rotate(new Vector2(x, y + h), new Vector2(cx, cy), angleRadians);

            Vector2 uv0 = new Vector2(0, 0);
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);

            drawList.AddImageQuad(textureId,
                                  points[0], points[1], points[2], points[3],
                                  uv0, uv1, uv2, uv3);
        }

        /// <summary>
        /// Dibuja un sprite (subsección de la textura) sin rotación.
        /// </summary>
        public static void DrawSprite(ImDrawListPtr drawList, ImTextureID textureId,
                                      float x, float y, float w, float h,
                                      float u, float v, float u2, float v2)
        {
            // (u,v) => top-left, (u2, v2) => bottom-right en UV coords
            if (textureId.IsNull) return;

            drawList.AddImage(textureId,
                              new Vector2(x, y),
                              new Vector2(x + w, y + h),
                              new Vector2(u, v),
                              new Vector2(u2, v2));
        }

        /// <summary>
        /// Aplica una rotación a un punto p alrededor de un punto center con ángulo angleRadians.
        /// </summary>
        private static Vector2 Rotate(Vector2 p, Vector2 center, float angleRadians)
        {
            float s = (float)Math.Sin(angleRadians);
            float c = (float)Math.Cos(angleRadians);

            // Trasladar al origen
            p.X -= center.X;
            p.Y -= center.Y;

            // Aplicar la rotación
            float xnew = p.X * c - p.Y * s;
            float ynew = p.X * s + p.Y * c;

            // Regresar al punto original
            p.X = xnew + center.X;
            p.Y = ynew + center.Y;
            return p;
        }
    }

}
