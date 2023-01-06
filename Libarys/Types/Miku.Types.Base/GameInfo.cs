using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miku.Types.Base
{
    /// <summary>
    /// Provide information about type, who can be attached to <c>Miku</c>
    /// </summary>
    public class GameInfo
    {
        /// <summary>
        /// Type version
        /// </summary>
        public Version Version { get; set; }
        /// <summary>
        /// Name to render
        /// </summary>
        public string RenderName { get; set; } = "game";
    }
}
