﻿using System.Drawing;

namespace Tanuki_Chi
{
    public class SpecialWeek : TanukiModel
    {
        Image initImage = Properties.Resources.スペシャルウィークにっこり;

        public Image InitImage
        {
            get { return initImage; }
        }

        public Image Command(string command)
        {
            return initImage;
        }
    }
}
