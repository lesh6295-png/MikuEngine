using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Miku;
using Miku.Interfaces;
using Miku.Types.Assets;
using Miku.Types.Base;
using Miku.Types.Enums;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IHost
    {
        Miku.Miku core;
        public MainWindow()
        {
            Miku.Examples.Testing q = new (this,this);
            core = new(this);
            InitializeComponent();
            core.EnableScenario("testing");
        }

        public void Clear(int id)
        {
            text.Text = "";
        }

        public void DeleteActorSprite(int id)
        {
            throw new NotImplementedException();
        }

        public Task InputWaitAsync()
        {
            throw new NotImplementedException();
        }

        public OsType OsInfo()
        {
            return OsType.Windows;
        }

        public void Print(string text, int id)
        {
            this.text.Text = text;
        }

        public int RenderActorSprite(ImageAsset asset, Vector2 position)
        {
            throw new NotImplementedException();
        }

        public void SetBackground(ImageAsset asset)
        {
            throw new NotImplementedException();
        }

        public void UpdateActorPosition(int actorId, Vector2 newPosition)
        {
            throw new NotImplementedException();
        }

        public void UpdateActorSprite(ImageAsset asset, int id)
        {
            throw new NotImplementedException();
        }
    }
}
