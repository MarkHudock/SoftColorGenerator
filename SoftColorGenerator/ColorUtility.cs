using System;
using System.Linq;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class ColorUtility
    {
        public static readonly char[] HEX_CHARACTERS = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        /// <summary>
        /// Returns a Color for the given foreground and background colors with a specified
        /// transparency of the foreground color.
        /// </summary>
        /// <param name="foreground">The Color that represents the foreground.</param>
        /// <param name="background">The Color that represents the background.</param>
        /// <param name="transparency">The amount of transparency as a percentage.</param>
        /// <returns></returns>
        public Color GetColorForTransparency(Color foreground, Color background, int transparency)
        {
            if (foreground != null && background != null)
            {
                int calculatedRed = (int)Math.Round(((float)Math.Abs(foreground.R - background.R) / 100) * transparency + foreground.R);
                int calculatedGreen = (int)Math.Round(((float)Math.Abs(foreground.G - background.G) / 100) * transparency + foreground.G);
                int calculatedBlue = (int)Math.Round(((float)Math.Abs(foreground.B - background.B) / 100) * transparency + foreground.B);
                return Color.FromArgb(calculatedRed, calculatedGreen, calculatedBlue);
            }
            return new Color();
        }

        public Color FromHex(string hexColor)
        {
            if (hexColor.Length != 6 || hexColor.ToUpper().Count(x => !HEX_CHARACTERS.Contains(x)) > 0)
                throw new Exception("Invalid Hex color. The Hex color must be 6 characters and contain only valid Hexadecimal characters.");
            string[] rgb = { hexColor.Substring(0, 2), hexColor.Substring(2, 2), hexColor.Substring(4, 2) };
            return Color.FromArgb(
                int.Parse(rgb[0], System.Globalization.NumberStyles.HexNumber),
                int.Parse(rgb[1], System.Globalization.NumberStyles.HexNumber),
                int.Parse(rgb[2], System.Globalization.NumberStyles.HexNumber));
        }

        /// <summary>
        /// Translates a Color's Hexadecimal representation.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The Hexadecimal representation of the color specified.</returns>
        public string ToHex(Color color)
        {
            if (color != null)
            {
                string redHex = string.Format("{0}{1}", HEX_CHARACTERS[(int)color.R / 16], HEX_CHARACTERS[(int)color.R % 16]);
                string greenHex = string.Format("{0}{1}", HEX_CHARACTERS[(int)color.G / 16], HEX_CHARACTERS[(int)color.G % 16]);
                string blueHex = string.Format("{0}{1}", HEX_CHARACTERS[(int)color.B / 16], HEX_CHARACTERS[(int)color.B % 16]);
                return string.Format("{0}{1}{2}", redHex, greenHex, blueHex);
            }
            return "Invalid Color";
        }

    }
}
