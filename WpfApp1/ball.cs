using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.Direct2D1;
namespace WpfApp1
{
    class Ball:GameObject, IDisposable
    {
		public int PaddleWidth = 10;
		public float RecoilYMax = 0.2f;
		public float RecoilXMin = -0.1f;
		public float RecoilXMax = 0.1f;
		float speedBuster = 0.03f;
		public float speedX;
		public float speedY;
		public Ball() :base()
		{
			// Initial ball position and speed
			this.Reset();
		}


		public void Reset()
		{
			// Sets an initial ball position and speed. X is fixed, Y is random
			Random randomY = new Random();

			positionX = 100;
			positionY = randomY.Next(1, 600);// Find resilution 

			speedX = 200;
			speedY = randomY.Next(1, 300);
		}
		
		
		public void Advance()
		{
			// Logic of the ball movement. If it hits the upper or lower walls it bounces back
			positionX += speedX * speedBuster;
			positionY += speedY * speedBuster;

			if (positionY >= 565)
			{
				speedY = -Math.Abs(speedY);

			}

			if (positionY <= 10)
			{

				speedY = Math.Abs(speedY);
			}

		}

		public void CheckHitLeftPaddle(float paddleY)
		{
			// Checks if the ball hits the left paddle. If it does, it bounces back
			if (positionX < 30 && speedX < 0)
			{

				if (positionY > paddleY - 10 && positionY < paddleY + 110)
				{
					// We don't simply want to reverse the x speed. In order to make the game more interesting, we change the X and Y speeds based on where on the paddle the ball hita
					float paddleHitPos = (positionY - paddleY) / 50;
					speedX = Math.Abs(speedX + speedX * (1 - Math.Abs(paddleHitPos)) * RecoilXMax - Math.Abs(speedX * paddleHitPos * RecoilXMin));
					speedY = speedY + Math.Abs(speedY) * paddleHitPos * RecoilYMax;
					return;
				}
			}
		}

		public void CheckHitRightPaddle(float paddleY)
		{
			// Checks if the ball hits the right paddle. If it does, it bounces back
			if (positionX >=  760 && speedX > 0)
			{
				
				if (positionY > paddleY-10 && positionY < paddleY + 110)
				{
					// We don't simply want to reverse the x speed. In order to make the game more interesting, we change the X and Y speeds based on where on the paddle the ball hita
					float paddleHitPos = (positionY - paddleY) / 50;
					speedX = -Math.Abs(speedX + speedX * (1 - Math.Abs(paddleHitPos)) * RecoilXMax - Math.Abs(speedX * paddleHitPos * RecoilXMin));
					speedY = speedY + Math.Abs(speedY) * paddleHitPos * RecoilYMax;
					return;
				}
			}
		}

		public bool IsOutsideLeft()
		{
			// Returns true if the ball is outside the play area on the left side
			return positionX < 0;
		}

		public bool IsOutsideRight()
		{
			// Returns true if the ball is outside the play area on the right side
			return positionX > 800;
		}
		public void Dispose()
        {
			this.Dispose();
        }
		public void Bust()
        {
			speedX *= 1.01f;
			speedY *= 1.01f;
		}

	}

}
