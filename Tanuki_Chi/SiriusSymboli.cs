﻿using System.Drawing;

namespace Tanuki_Chi
{
    public class SiriusSymboli : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SiriusSymboli() : base("シリウスシンボリ", Properties.Resources.シリウスシンボリ立ちにっこり)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override Image Command(string command)
        {
            Image image = InitImage;

            if (command == "MouseDown")
            {

            }

            return image;
        }
    }
}
