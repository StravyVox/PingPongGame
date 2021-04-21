using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Windows;
using System.Windows.Input;
using PingPongGraphicsClassLibrary;
namespace PingPongGameClassLibrary
{
    class MainEngine:IDisposable
    {
        ObjectsMassWorker ObjectsList;
        RenderForm _mainWindowGame;
        Logic _GameLogic;
        FrameDrawer _FrameDrawer;
        public MainEngine(RenderForm mainForm)
        {
            ObjectsList = new ObjectsMassWorker();
            _mainWindowGame = mainForm;
            _FrameDrawer = new FrameDrawer(_mainWindowGame);
            _GameLogic = new Logic(_mainWindowGame, ObjectsList);
            _mainWindowGame = mainForm;
        }
        private void Restart()
        {
            ObjectsList = new ObjectsMassWorker();
            _FrameDrawer = new FrameDrawer(_mainWindowGame);
            _GameLogic = new Logic(_mainWindowGame,ObjectsList);
        }
        public void Logic()
        {
            if (_GameLogic._GameIsPlaying == true)
            {
                _GameLogic.GameLogic();
            }
            else Restart();
        }
        public void FrameDraw()
        {
            _FrameDrawer.FrameDraw(ObjectsList.ReturnSpritesMass(), ObjectsList.ReturnPositionX(), ObjectsList.ReturnPositionY());
        }
        public void Dispose()
        {
            _FrameDrawer.Dispose();
        }
    }

}
