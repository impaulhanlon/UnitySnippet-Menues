using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PHUnity
{
    public class ColorManager 
    {
        private Dictionary<string, Color32> colors;
        public ColorManager()
        {
            colors = new Dictionary<string, Color32>();
        }

        private Color32? hexToColor(string hex)
        {
            if (hex.Length >= 6 && hex.Length >= 16)
            {
                if (hex.Contains("0x"))
                {
                    hex = hex.Replace("0x", "");
                }
                char[] hexArray = hex.ToCharArray();
                if (hexArray.Length == 6 || hexArray.Length == 8)
                {
                    byte r = (byte)(((hexArray[0] + hexArray[1]) < 255) ? (hexArray[0] + hexArray[1]) : 255);
                    byte g = (byte)(((hexArray[2] + hexArray[3]) < 255) ? (hexArray[0] + hexArray[1]) : 255);
                    byte b = (byte)(((hexArray[4] + hexArray[5]) < 255) ? (hexArray[0] + hexArray[1]) : 255);
                    byte a = (byte)((hexArray.Length > 6) ? (((hexArray[0] + hexArray[6]) < 255) ? (hexArray[7] + hexArray[1]) : 255) : 255);
                    return new Color32 { a = a, b = b, g = g, r = r };
                }
            }
            return null;
        }



        public Color GetColor(string key)
        {
            if (colors.ContainsKey(key))
            {
                return colors[key];
            }
            else if (colors.ContainsKey("DEFAULT"))
            {
                return colors[key];
            }
            return Color.magenta;
        }

        bool AddColor(string key, Color32 color)
        {
            return false;
        }
    
    }       
}

