using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Paddle
    {
		public float positionX;
		public float positionY;
		int resolutionY = 800;
		int score;
		public int PaddleWidth = 20;
		public int PaddleHeight = 100;
		public Paddle(float xPos, float yPos)
		{
			// Initializes the position of the paddle with a fixed X position and Y being at the middle of the screen
			positionX = xPos;
			positionY = yPos;

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
