using System;
using Miku;
using Miku.Types.Base;
using Miku.Interfaces;
namespace Miku.Examples
{
    public class Testing : Game
    {
        public Testing(IGraphics graphics, IText text) : base (graphics,text)
        {

        }
        public override void Info(GameInfo info)
        {
            info.Version = new Types.Base.Version("0.0.1.0");
            info.RenderName = "testing";
        }
        public override void Play()
        {
            Text.Print("Testing");

        }
    }
}
