using System;
namespace PingPongGameClassLibrary
{
    public class Ball:GameObject, IDisposable
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
			this.Reset();
		}
		public void Reset()
		{

			Random randomY = new Random();
			_spriteFileName = @"Textures\ball.png";
			_positionX = 100;
			_positionY = randomY.Next(1, 600);// Find resilution 

			speedX = 200;
			speedY = randomY.Next(1, 300);
		}
		public void Reset(int personStart)
        {
			switch (personStart)
            {
				case 1: Reset();
					    break;
				case 2:Reset();
					Random randomY = new Random();
					_positionX = 700;
					speedY = randomY.Next(-300, -1);
					break;
				default:
					Reset();
					break;
            }
        }		
		public void Advance(int resolutionY)
		{
			_positionX += speedX * speedBuster;
			_positionY += speedY * speedBuster;

			if (_positionY+60 >= resolutionY)
			{
				speedY = -Math.Abs(speedY);
			}

			if (_positionY+20 <= 10)
			{

				speedY = Math.Abs(speedY);
			}

		}

		public void CheckHitLeftPaddle(float paddleY)
		{
			if (_positionX+20 < 30 && speedX < 0)
			{

				if (_positionY+20 > paddleY - 10 && _positionY+20 < paddleY + 110)
				{
					
					float paddleHitPos = (_positionY - paddleY) / 50;
					speedX = Math.Abs(speedX + speedX * (1 - Math.Abs(paddleHitPos)) * RecoilXMax - Math.Abs(speedX * paddleHitPos * RecoilXMin));
					speedY = speedY + Math.Abs(speedY) * paddleHitPos * RecoilYMax;
					return;
				}
			}
		}

		public void CheckHitRightPaddle(float paddleY, int resolutionX)
		{
			
			if (_positionX+40 >= resolutionX-30 && speedX > 0)
			{
				
				if (_positionY+20 > paddleY-10 && _positionY+20 < paddleY + 110)
				{
					
					float paddleHitPos = (_positionY - paddleY) / 50;
					speedX = -Math.Abs(speedX + speedX * (1 - Math.Abs(paddleHitPos)) * RecoilXMax - Math.Abs(speedX * paddleHitPos * RecoilXMin));
					speedY = speedY + Math.Abs(speedY) * paddleHitPos * RecoilYMax;
					return;
				}
			}
		}

		public bool IsOutsideLeft()
		{
			return _positionX < 0;
		}

		public bool IsOutsideRight(int resolutionX)
		{
		
			return _positionX > resolutionX;
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
