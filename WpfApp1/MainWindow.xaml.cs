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
            RenderForm window;
           
            public void Render()
            {
               
            }
            public ClsSharpDXSampleBase()  
            {
                window = new RenderForm("Ping Pong");
                
            }
            public void RenderCallback()
            {
                Graphics renderGraphics = new Graphics();
                renderGraphics.Initialize(window);
                while (true)
                {

                }
            }
            public void Run(){
                RenderLoop.Run(window, RenderCallback);
            }
        }
          
    }
}
