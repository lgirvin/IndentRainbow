﻿using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace IndentRainbow.Logic.Colors
{
    public static class ColorParser
    {
        /// <summary>
        /// Converts a given string to a brush array.
        /// Colors must be separated using "," and colors must be in ARGB Hexadecimal format
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public static Brush[] ConvertStringToBrushArray(string colors)
        {
            string[] splitColors = colors.Split(',');
            int colorCount = splitColors.Length;
            List<Brush> brushes = new List<Brush>();

            for (int i = 0; i < colorCount; i++)
            {
                try
                {
                    var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(splitColors[i]));
                    brushes.Add(brush);
                } catch (FormatException) { }
            }

            return brushes.ToArray();
        }
    }
}
