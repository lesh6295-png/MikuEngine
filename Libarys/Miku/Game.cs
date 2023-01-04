using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miku.Interfaces;
namespace Miku
{
    public class Game
    {
        /// <summary>
        /// This method contains all game code
        /// </summary>
        public virtual void Play()
        {
            Text.Say("Miku Engine Game Class.");
            Text.Clear();
            Text.Say("If you see this, that Miku class select as main Game class a delault.");
        }
        int instruction_count = 0;
        int active_instruction = 0;
        bool inGame = false;

        IGraphics hostGr, emulateGr;
        IText hostTxt, emulateTxt;

        EmptyHost empty;
        public IGraphics Graphics
        {
            get
            {
                if (inGame)
                {
                    instruction_count++;
                    return hostGr;
                }
                else
                {
                    active_instruction++;
                    return emulateGr;
                }
            }
        }
        public IText Text
        {
            get
            {
                if (inGame)
                {
                    instruction_count++;
                    return hostTxt;
                }
                else
                {
                    active_instruction++;
                    return emulateTxt;
                }
            }
        }
        public Game(IGraphics graphic, IText text)
        {
            empty = new();
            emulateGr = empty;
            emulateTxt = empty;
            hostGr = graphic;
            hostTxt = text;
            CalculateInstructionCount();
        }
        void CalculateInstructionCount()
        {
            Play();
            inGame = true;
        }
    }
}
