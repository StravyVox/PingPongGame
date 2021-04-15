using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Paddle:GameObject
    {
		int resolutionY = 800;
		int score;
		public int PaddleWidth = 20;
		public int PaddleHeight = 100;
		public Paddle(float positionX, float positionY) : base(positionX, positionY)
		{
			score = 0;
		}
		public void MoveToPosition(int yPos)
		{
			// Moves the paddle to a specified position, also making sure it doesn't go outside the screen
			positionY = yPos;
			if (positionY < PaddleWidth / 2)
			{
				positionY = PaddleWidth / 2;
			}
			if (positionY > resolutionY - PaddleWidth / 2)
			{
				positionY = resolutionY - PaddleWidth / 2;
			}
		}

		public void IncreaseScore()
		{
			score++;
		}
	}
}
