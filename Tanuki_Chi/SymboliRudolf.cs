﻿using System.Drawing;

namespace Tanuki_Chi
{
    public class SymboliRudolf : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SymboliRudolf() : base("シンボリルドルフ")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.SymboliRudolf_Front_Smiling;
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
