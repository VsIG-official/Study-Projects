using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleExercise
{
    /// <summary>
    /// An apple
    /// </summary>
    class Apple
    {
        #region Fields

        bool organic;
        float amountLeft;

        #endregion Fields

        #region Constructors

        #region Methods

        public void TakeBite()
        {
            if (size <= amountLeft)
            {
                amountLeft -= size;
            }
            else
            {
                amountLeft = 0;
            }
        }

        #endregion Methods

        public Apple(bool organic, float size)
        {
            this.organic = organic;
            amountLeft = size;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets whether or not the apple is organic
        /// </summary>
        public bool Organic
        {
            get { return organic; }
        }

        /// <summary>
        /// Gets how much apple is left to eat
        /// </summary>
        public float AmountLeft
        {
            get { return amountLeft; }
        }

        #endregion Properties
    }
}
