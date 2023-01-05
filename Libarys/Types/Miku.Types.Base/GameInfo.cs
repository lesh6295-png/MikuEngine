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
        /// Name to render, it`s need only to modding. You don`t need to change this if type is main
        /// </summary>
        public string RenderName { get; set; } = "game";
    }
}
