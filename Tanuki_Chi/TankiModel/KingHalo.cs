﻿using System.Drawing;

namespace Tanuki_Chi
{
    public class KingHalo : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public KingHalo() : base("キングヘイロー")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.KingHalo_Dance_Smiling;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override Image Command(string command)
        {
            Image image = null;

            if (command == "MouseDown")
            {

            }

            if (image == null)
            {
                CurrentImage = "";
                image = InitImage();
            }

            return image;
        }
    }
}