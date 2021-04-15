using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class GameObject
    {
        public float positionX;
        public float positionY;
        public GameObject(float positionX, float positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }
        public GameObject()
        {
            
        }

    }
}
