namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class GameObject.
    /// </summary>
    public abstract class GameObject
    {
        /// <summary>
        /// The xposition
        /// </summary>
        private float Xposition;
        /// <summary>
        /// The yposition
        /// </summary>
        private float Yposition;
        /// <summary>
        /// The sprite file name
        /// </summary>
        private string _spriteFileName;
        /// <summary>
        /// The scale of sprite
        /// </summary>
        private float _scaleOfSprite;
        /// <summary>
        /// Initializes a new instance of the <see cref="GameObject"/> class.
        /// </summary>
        /// <param name="positionX">The position x.</param>
        /// <param name="positionY">The position y.</param>
        /// <param name="sprite">The sprite.</param>
        /// <param name="scale">The scale.</param>
        public GameObject(float positionX, float positionY, string sprite,float scale = 5)
        {
            Xposition = positionX;
            Yposition = positionY;
            _spriteFileName = sprite;
            _scaleOfSprite = scale;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameObject"/> class.
        /// </summary>
        public GameObject()
        {
            
        }
        /// <summary>
        /// Gets or sets the xpos.
        /// </summary>
        /// <value>The xpos.</value>
        public float Xpos
        {
            get
            {
                return Xposition;
            }
            set
            {
                Xposition = value;
            }
        }
        /// <summary>
        /// Gets or sets the ypos.
        /// </summary>
        /// <value>The ypos.</value>
        public float Ypos
        {
            get
            {
                return Yposition;
            }
            set
            {
                Yposition = value;
            }
        }
        /// <summary>
        /// Gets or sets the sprite.
        /// </summary>
        /// <value>The sprite.</value>
        public string Sprite
        {
            get
            {
                return _spriteFileName;
            }
            set
            {
                _spriteFileName = value;
            }
        }
        /// <summary>
        /// Gets or sets the scale.
        /// </summary>
        /// <value>The scale.</value>
        public float Scale
        {
            get
            {
                return _scaleOfSprite;
            }
            set
            {
                _scaleOfSprite = value;
            }
        }

        /// <summary>
        /// Gets or sets the main game objects worker.
        /// </summary>
        /// <value>The main game objects worker.</value>
        internal MainGameObjectsWorker MainGameObjectsWorker
        {
            get => default;
            set
            {
            }
        }
    }
}
