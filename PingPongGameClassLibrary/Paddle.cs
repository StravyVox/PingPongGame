using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    public class Paddle:GameObject
    {
		int score;
		public int PaddleWidth;
		public int PaddleHeight;
		public Paddle(float positionX, float positionY, string texturefile = @"D:\Downloads\platform.png", int Paddlewidth = 20, int Paddleheight = 100) : base(positionX, positionY, texturefile)
		{
			score = 0;
			PaddleWidth = Paddlewidth;
			PaddleHeight = Paddleheight;
		}
		public void MoveToPosition(int speedY, int resolutionY)
		{
			// Moves the paddle to a specified position, also making sure it doesn't go outside the screen
			_positionY += speedY;
			if (_positionY < PaddleWidth / 2)
			{
				_positionY = PaddleWidth / 2;
			}
			if (_positionY+PaddleHeight >= resolutionY)
			{
				_positionY = resolutionY - PaddleHeight;
			}
		}
		public void IncreaseScore()
		{
			score++;
		}
	}
}
