namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class Background.
    /// Implements the <see cref="PingPongGameClassLibrary.GameObject" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.GameObject" />
    class Background :GameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Background"/> class.
        /// </summary>
        public Background():base(0.0f,0.0f, @"Textures\background.jpg")
        {
            Scale = 1;
        }
    }
}
