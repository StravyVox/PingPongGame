using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class ObjectsMassWorker.
    /// </summary>
    public class ObjectsMassWorker
    {
        /// <summary>
        /// The game objects mass
        /// </summary>
        List<GameObject> _gameObjectsMass;
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsMassWorker"/> class.
        /// </summary>
        public ObjectsMassWorker()
        {
            _gameObjectsMass = new List<GameObject>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsMassWorker"/> class.
        /// </summary>
        /// <param name="objects">The objects.</param>
        public ObjectsMassWorker(List<GameObject> objects)
        {
            _gameObjectsMass = new List<GameObject>();
            AddList(objects);
        }
        /// <summary>
        /// Gets or sets the <see cref="GameObject"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>GameObject.</returns>
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

        /// <summary>
        /// Adds the specified object to add.
        /// </summary>
        /// <param name="objectToAdd">The object to add.</param>
        public void Add(GameObject objectToAdd) 
        {
            _gameObjectsMass.Add(objectToAdd);
        }

        /// <summary>
        /// Adds the list.
        /// </summary>
        /// <param name="listToAdd">The list to add.</param>
        public void AddList(List<GameObject> listToAdd)
        {
            foreach(GameObject objectToAdd in listToAdd)
            {
                _gameObjectsMass.Add(objectToAdd);
            }
        }
        /// <summary>
        /// Removes at.
        /// </summary>
        /// <param name="index">The index.</param>
        public void RemoveAt(int index)
        {
            _gameObjectsMass.RemoveAt(index-1);
        }
        /// <summary>
        /// Returns a full list.
        /// </summary>
        /// <returns>List&lt;GameObject&gt;.</returns>
        public List<GameObject> ReturnAFullList()
        {
            List <GameObject> list = new List<GameObject>();
            for (int i = 0; i < _gameObjectsMass.Count; i++)
            {
                list.Add(_gameObjectsMass[i]);
            }
            return list;
        }
        /// <summary>
        /// Lengthes this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int Length()
        {
            return _gameObjectsMass.Count;
        }
        /// <summary>
        /// Returns the sprites mass.
        /// </summary>
        /// <returns>System.String[].</returns>
        public string[] ReturnSpritesMass()
        {
            string[] resultedMass = new string[_gameObjectsMass.Count];
            for(int i =0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i].Sprite;
            }
            return resultedMass;
        }
        /// <summary>
        /// Returns the position x.
        /// </summary>
        /// <returns>System.Single[].</returns>
        public float[] ReturnPositionX()
        {
            float[] resultedMass = new float[_gameObjectsMass.Count];
            for (int i = 0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i].Xpos;
            }
            return resultedMass;
        }
        /// <summary>
        /// Returns the position y.
        /// </summary>
        /// <returns>System.Single[].</returns>
        public float[] ReturnPositionY()
        {
            float[] resultedMass = new float[_gameObjectsMass.Count];
            for (int i = 0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i].Ypos;
            }
            return resultedMass;
        }
        /// <summary>
        /// Returns the scales.
        /// </summary>
        /// <returns>System.Single[].</returns>
        public float[] ReturnScales() {
            float[] resultedMass = new float[_gameObjectsMass.Count];
            for (int i = 0; i < resultedMass.Length; i++)
            {
                resultedMass[i] = _gameObjectsMass[i].Scale;
            }
            return resultedMass;
        }
     }
}
