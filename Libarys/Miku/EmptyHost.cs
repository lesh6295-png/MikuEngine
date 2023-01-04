using Miku.Types.Assets;
using Miku.Types.Base;
using Miku.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miku
{
    /// <summary>
    /// This class provide empry host, who need to calculate instruction count
    /// </summary>
    public class EmptyHost : global::Miku.Interfaces.IHost
    {
        public void Clear(int id)
        {
            return;
        }

        public void DeleteActorSprite(int id)
        {
            return;
        }

        public async Task InputWaitAsync()
        {
            return; 
        }

        public OsType OsInfo()
        {
            return OsType.Unknown;
        }

        public void Print(string text, int id)
        {
            return;
        }

        public int RenderActorSprite(ImageAsset asset, Vector2 position)
        {
            return 0;
        }

        public void SetBackground(ImageAsset asset)
        {
            return;
        }

        public void UpdateActorPosition(int actorId, Vector2 newPosition)
        {
            return;
        }

        public void UpdateActorSprite(ImageAsset asset, int id)
        {
            return;
        }
    }
}
