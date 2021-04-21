namespace PingPongGameClassLibrary
{
    public abstract class GameObject
    {
        public float _positionX;
        public float _positionY;
        public string _spriteFileName;
        public GameObject(float positionX, float positionY, string sprite)
        {
            this._positionX = positionX;
            this._positionY = positionY;
            _spriteFileName = sprite;
        }
        public GameObject()
        {
            
        }

    }
}
