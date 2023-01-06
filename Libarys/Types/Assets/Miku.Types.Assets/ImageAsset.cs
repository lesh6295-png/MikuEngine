using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miku.Types.Assets
{
    public abstract class ImageAsset : Asset
    {
        public abstract object Load();

    }
}
