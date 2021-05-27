using System;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class Ball.
    /// Implements the <see cref="PingPongGameClassLibrary.GameObject" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.GameObject" />
    public class Ball: GameObject
    {
        /// <summary>
        /// The recoil y maximum
        /// </summary>
        private float RecoilYMax = 0.2f;
        /// <summary>
        /// The recoil x minimum
        /// </summary>
        private float RecoilXMin = -0.1f;
        /// <summary>
        /// The recoil x maximum
        /// </summary>
        private float _RecoilXMax = 0.1f;
        /// <summary>
        /// The speed buster
        /// </summary>
        private float _speedBuster = 0.03f;
        /// <summary>
        /// The speed x
        /// </summary>
        private float _speedX;
        /// <summary>
        /// The speed y
        /// </summary>
        private float _speedY;

        /// <summary>
        /// Gets or sets the speed x.
        /// </summary>
        /// <value>The speed x.</value>
        public float SpeedX
        {
            get
            {
                return _speedX;
            }
            set
            {
                _speedX = value;
            }
        }
        /// <summary>
        /// Gets or sets the speed y.
        /// </summary>
        /// <value>The speed y.</value>
        public float SpeedY
        {
            get
            {
                return _speedY;
            }
            set
            {
                _speedY = value;
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ball"/> class.
        /// </summary>
        public Ball() : base()
        {
            this.Reset();
        }
        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset() 
        {
            Random randomY = new Random();
            Scale = 18;
            Sprite = @"Textures\ball.png";
            Xpos = 100;
            Ypos = randomY.Next(1, 600);
            SpeedX = 400;
            _speedY = randomY.Next(1, 300);
        }
        /// <summary>
        /// Resets the specified person start.
        /// </summary>
        /// <param name="personStart">The person start.</param>
        public void Reset(int personStart)
        {
            switch (personStart)
            {
                case 1:
                    Reset();
                    break;
                case 2:
                    Reset();
                    Random randomY = new Random();
                    Xpos = 700;
                    _speedY = randomY.Next(1, 300);
                    SpeedX = -400;
                    break;
                default:
                    Reset();
                    break;
            }
        }
        /// <summary>
        /// Frames the logic.
        /// </summary>
        /// <param name="resolutionY">The resolution y.</param>
        public void FrameLogic(int resolutionY)
        {
            Xpos += SpeedX * _speedBuster;
            Ypos += _speedY * _speedBuster;

            if (Ypos + 60 >= resolutionY)
            {
                _speedY = -Math.Abs(_speedY);
            }

            if (Ypos + 20 <= 10)
            {

                _speedY = Math.Abs(_speedY);
            }

        }
        /// <summary>
        /// Checks the hit left paddle.
        /// </summary>
        /// <param name="paddleToCheck">The paddle to check.</param>
        public void CheckHitLeftPaddle(Paddle paddleToCheck)
        {
            if (Xpos + 10 < 30 && SpeedX < 0)
            {

                if (Ypos + 20 > paddleToCheck.Ypos - 10 && Ypos + 20 < paddleToCheck.Ypos + paddleToCheck.Height)
                {

                    float paddleHitPos = (Ypos - paddleToCheck.Ypos) / 50;
                    SpeedX = Math.Abs(SpeedX + SpeedX * (1 - Math.Abs(paddleHitPos)) * _RecoilXMax - Math.Abs(SpeedX * paddleHitPos * RecoilXMin));
                    _speedY = _speedY + Math.Abs(_speedY) * paddleHitPos * RecoilYMax;

                }
            }
        }
        /// <summary>
        /// Checks the hit right paddle.
        /// </summary>
        /// <param name="paddleToCheck">The paddle to check.</param>
        /// <param name="resolutionX">The resolution x.</param>
        public void CheckHitRightPaddle(Paddle paddleToCheck, int resolutionX)
        {

            if (Xpos + 40 >= resolutionX - 30 && SpeedX > 0)
            {

                if (Ypos + 20 > paddleToCheck.Ypos - 10 && Ypos + 20 < paddleToCheck.Ypos + paddleToCheck.Height)
                {

                    float paddleHitPos = (Ypos - paddleToCheck.Ypos) / 50;
                    SpeedX = -Math.Abs(SpeedX + SpeedX * (1 - Math.Abs(paddleHitPos)) * _RecoilXMax - Math.Abs(SpeedX * paddleHitPos * RecoilXMin));
                    _speedY = _speedY + Math.Abs(_speedY) * paddleHitPos * RecoilYMax;
   
                }
            }
        }
        /// <summary>
        /// Checks the hit bonus box.
        /// </summary>
        /// <param name="BoxToCheck">The box to check.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool CheckHitBonusBox(BonusBox BoxToCheck)
        {
            if (Xpos + 20 >= BoxToCheck.Xpos - 15 && Xpos + 20 <= BoxToCheck.Xpos + 60)
            {
                if (Ypos + 20 >= BoxToCheck.Ypos - 15 && Ypos + 20 <= BoxToCheck.Ypos + 60)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Determines whether [is outside left].
        /// </summary>
        /// <returns><c>true</c> if [is outside left]; otherwise, <c>false</c>.</returns>
        public bool IsOutsideLeft()
        {
            return Xpos < 0;
        }
        /// <summary>
        /// Determines whether [is outside right] [the specified resolution x].
        /// </summary>
        /// <param name="resolutionX">The resolution x.</param>
        /// <returns><c>true</c> if [is outside right] [the specified resolution x]; otherwise, <c>false</c>.</returns>
        public bool IsOutsideRight(int resolutionX)
        {

            return Xpos > resolutionX;
        }
    }

}
