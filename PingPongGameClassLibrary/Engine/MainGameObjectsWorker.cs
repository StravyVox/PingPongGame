using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class MainGameObjectsWorker.
    /// Implements the <see cref="PingPongGameClassLibrary.ObjectsMassWorker" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.ObjectsMassWorker" />
   public class MainGameObjectsWorker :ObjectsMassWorker
    {
        /// <summary>
        /// The main ball
        /// </summary>
        private Ball _mainBall;
        /// <summary>
        /// The FRST paddle
        /// </summary>
        private FirstPlayer _frstPaddle;
        /// <summary>
        /// The SCND paddle
        /// </summary>
        private SecondPlayer _scndPaddle;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainGameObjectsWorker"/> class.
        /// </summary>
        public MainGameObjectsWorker():base()
        {
            Add(new Background());
            Add(new Ball());
            Add(new FirstPlayer(765, 300));
            Add(new SecondPlayer(0, 300));
            _mainBall = (Ball)this[1];
            _frstPaddle = (FirstPlayer)this[2];
            _scndPaddle = (SecondPlayer)this[3];  
        }
        /// <summary>
        /// Restarts the players.
        /// </summary>
        public void RestartPlayers()
        {
            this[2] = new FirstPlayer(765, 300);
            this[3] = new SecondPlayer(0, 300);
            _frstPaddle = (FirstPlayer)this[2];
            _scndPaddle = (SecondPlayer)this[3];
        }

        /// <summary>
        /// Resets the boxes.
        /// </summary>
        public void ResetBoxes()
        {
            for (int i = Length(); i != 4; i--)
            {
                RemoveAt(i);
            }
        }
        /// <summary>
        /// Adds the boxes.
        /// </summary>
        /// <param name="boxesToAdd">The boxes to add.</param>
        public void AddBoxes(List<BonusBox> boxesToAdd)
        {
            for (int i = Length(); i != 4; i--)
            {
                RemoveAt(i);
            }
            foreach (BonusBox boxToAdd in boxesToAdd)
                Add(boxToAdd);
        }
        /// <summary>
        /// Gets or sets the current ball.
        /// </summary>
        /// <value>The current ball.</value>
        public Ball CurrentBall
        {
            get
            {
                return _mainBall;
            }
            set
            {
                _mainBall = value;
            }
        }
        /// <summary>
        /// Gets or sets the first player get.
        /// </summary>
        /// <value>The first player get.</value>
        public FirstPlayer FirstPlayerGet
        {
            get
            {
                return _frstPaddle;
            }
            set
            {
                _frstPaddle = value;
            }
        }
        /// <summary>
        /// Gets or sets the second player get.
        /// </summary>
        /// <value>The second player get.</value>
        public SecondPlayer SecondPlayerGet
        {
            get
            {
                return _scndPaddle;
            }
            set
            {
                _scndPaddle = value;
            }
        }
        /// <summary>
        /// Gets the bonus box.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>BonusBox.</returns>
        public BonusBox GetBonusBox(int index)
        {
            return (BonusBox) this[4 + index];
        }

        /// <summary>
        /// Gets or sets the main engine.
        /// </summary>
        /// <value>The main engine.</value>
      
    }
}
