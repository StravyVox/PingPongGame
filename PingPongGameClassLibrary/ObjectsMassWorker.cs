using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    internal class ObjectsMassWorker
    {
        List<GameObject> _gameObjectsMass;
        public ObjectsMassWorker()
        {
            _gameObjectsMass = new List<GameObject>();
        }
        public ObjectsMassWorker(List<GameObject> objects):base()
        {
            foreach (GameObject obj in objects)
                _gameObjectsMass.Add(obj);
        }
        public GameObject this[int index]
        {
            get
            {
                return _gameObjectsMass[index];
            }
            set
            {
                _gameObjectsMass[index] = value;
            }
        }
        public void Add(GameObject objectToAdd) 
        {
            _gameObjectsMass.Add(objectToAdd);
        }
        public List<GameObject> ReturnAFullList()
        {
            List <GameObject> list = new List<GameObject>(_gameObjectsMass.Count);
            for (int i = 0; i < _gameObjectsMass.Count; i++)
            {
                list[i] = _gameObjectsMass[i];
            }
            return list;
        }
        public string[] ReturnSpritesMass()
        {
            string[] resultedMass = new string[_gameObjectsMass.Count];
            for(int i =0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i]._spriteFileName;
            }
            return resultedMass;
        }
        public float[] ReturnPositionX()
        {
            float[] resultedMass = new float[_gameObjectsMass.Count];
            for (int i = 0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i]._positionX;
            }
            return resultedMass;
        }
        public float[] ReturnPositionY()
        {
            float[] resultedMass = new float[_gameObjectsMass.Count];
            for (int i = 0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i]._positionY;
            }
            return resultedMass;
        }
    }
}
