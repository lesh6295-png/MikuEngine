using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miku.Interfaces
{
    public interface IText
    {
        /// <summary>
        /// Clear a text filed
        /// </summary>
        void Clear()
        {
            Clear(1);
        }
        /// <summary>
        /// Clear a text filed.
        /// </summary>
        /// <param name="id">Filed id</param>
        void Clear(int id);
        /// <summary>
        /// Print text to default text box
        /// </summary>
        /// <param name="text">Text to printing</param>
        void Print(string text)
        {
            Print(text, 1);
        }
        /// <summary>
        /// Print text to specefic text box 
        /// </summary>
        /// <param name="text">Text to printing</param>
        /// <param name="id">Text box id</param>
        void Print(string text, int id);
    }
}
