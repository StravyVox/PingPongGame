using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class BonusBox.
    /// Implements the <see cref="PingPongGameClassLibrary.GameObject" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.GameObject" />
    public abstract class BonusBox:GameObject
    {
        /// <summary>
        /// The type of bonus
        /// </summary>
        string _typeOfBonus;
        /// <summary>
        /// Initializes a new instance of the <see cref="BonusBox"/> class.
        /// </summary>
        /// <param name="posX">The position x.</param>
        /// <param name="posY">The position y.</param>
        /// <param name="typeOfBonus">The type of bonus.</param>
        public BonusBox(float posX, float posY,string typeOfBonus) : base(posX, posY, @"Textures\box.png") {
            _typeOfBonus = typeOfBonus;
        }
        /// <summary>
        /// Gets the type of the bonus.
        /// </summary>
        /// <value>The type of the bonus.</value>
        public string BonusType
        {
            get
            {
                return _typeOfBonus;
            } 
        }
        
    }
}
