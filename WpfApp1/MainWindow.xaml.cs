using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
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
using SharpDX.Windows;
using SharpDX.Direct3D;
using SharpDX.Direct2D1;
using SharpDX;
using WICBitmap = SharpDX.WIC.Bitmap;
using D2D1PixelFormat = SharpDX.Direct2D1.PixelFormat;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            ClsSharpDXSampleBase form = new ClsSharpDXSampleBase();
            form.Run();
        }
        public class ClsSharpDXSampleBase
        {
            RenderForm _window;
            MainEngine Engine;
            public ClsSharpDXSampleBase()  
            {
                _window = new RenderForm("Pong");
                _window.Width = 800;
                _window.Height = 600;
                _window.AllowUserResizing = false;
                Engine = new MainEngine(_window);
            }
            
                
            public void RenderCallback()
            {
                Engine.Logic();
                Engine.FrameDraw();
             
            }
            public void Run(){
                RenderLoop.Run(_window, RenderCallback);
            }
        }
          
    }
}
