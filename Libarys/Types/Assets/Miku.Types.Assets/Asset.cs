using System;

using System.IO;
namespace Miku.Types.Assets
{
    public abstract class Asset
    {
        public Miku.Types.Base.Id Guid;
        public Asset()
        {
            Guid = new();
        }
    }
}
