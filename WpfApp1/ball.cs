using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.Direct2D1;
namespace WpfApp1
{
    class Ball
    {
		public int PaddleWidth = 100;
		public float RecoilYMax = 0.5f;
		public float RecoilXMin = -0.2f;
		public float RecoilXMax = 0.1f;
		public float positionX;
		public float positionY;
		public float speedX;
		public float speedY;
		public Ball() 
		{
			// Initial ball position and speed
			this.Reset();
		}


		void Reset()
		{
			// Sets an initial ball position and speed. X is fixed, Y is random
			Random randomY = new Random();

			positionX = 100;
			positionY = randomY.Next(1, 600);// Find resilution 

			speedX = 300;
			speedY = 200;
		}

		void Initialize(RenderTarget RenderTarget)
		{
			SolidColorBrush ballBrush = new SolidColorBrush(RenderTarget, Color.Yellow);
			// Initializes Direct2D red brush for drawing
			
		}

		void Advance(float elapsedTime)
		{
			// Logic of the ball movement. If it hits the upper or lower walls it bounces back
			positionX += speedX * elapsedTime;
			positionY += speedY * elapsedTime;

			if (positionY >  - 10)
				speedY = -Math.Abs(speedY);
			if (positionY < 10)
				speedY = Math.Abs(speedY);
		}

		void CheckHitLeftPaddle(float paddleY)
		{
			// Checks if the ball hits the left paddle. If it does, it bounces back
			if (positionX < 20 && speedX < 0)
			{
				if (positionY > paddleY - PaddleWidth / 2 && positionY < paddleY + PaddleWidth/ 2)
				{
					// We don't simply want to reverse the x speed. In order to make the game more interesting, we change the X and Y speeds based on where on the paddle the ball hita
					float paddleHitPos = (positionY - paddleY) / (PaddleWidth / 2);
					speedX =  Math.Abs(speedX + speedX * (1 - Math.Abs(paddleHitPos)) * RecoilXMax - Math.Abs(speedX * paddleHitPos * RecoilXMin));
					speedY = speedY + Math.Abs(speedY) * paddleHitPos * RecoilYMax;
					return;
				}
			}
		}

		void CheckHitRightPaddle(float paddleY)
		{
			// Checks if the ball hits the right paddle. If it does, it bounces back
			if (positionX > 800 - 20 && speedX > 0)
			{
				if (positionY > paddleY - PaddleWidth / 2 && positionY < paddleY + PaddleWidth / 2)
				{
					// We don't simply want to reverse the x speed. In order to make the game more interesting, we change the X and Y speeds based on where on the paddle the ball hita
					float paddleHitPos = (positionY - paddleY) / (PaddleWidth / 2);
					speedX = -Math.Abs(speedX + speedX * (1 - Math.Abs(paddleHitPos)) * RecoilXMax - Math.Abs(speedX * paddleHitPos * RecoilXMin));
					speedY = speedY + Math.Abs(speedY) * paddleHitPos * RecoilYMax;
					return;
				}
			}
		}

		bool IsOutsideLeft()
		{
			// Returns true if the ball is outside the play area on the left side
			return positionX < 0;
		}

		bool IsOutsideRight()
		{
			// Returns true if the ball is outside the play area on the right side
			return positionX > 800;
		}

		public void Draw(RenderTarget RenderTarget)
		{
			// Draws the ball using Direct2D
			SharpDX.Mathematics.Interop.RawVector2 mainPos = new SharpDX.Mathematics.Interop.RawVector2(positionX, positionY);
			SharpDX.Direct2D1.Ellipse ellipseBall = new Ellipse(mainPos, 10, 10);
			SolidColorBrush yellowBrush = new SolidColorBrush(RenderTarget, Color.Yellow);
			RenderTarget.FillEllipse(ellipseBall, yellowBrush);
		}
	}
}
