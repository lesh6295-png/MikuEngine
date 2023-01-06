using System;

using System.IO;
namespace Miku.Types.Assets
{
    public abstract class Asset
    {
        public Miku.Types.Base.Id Guid;
        public string path;
        public Asset()
        {
            Guid = new();
            path = "";
        }
    }
}
