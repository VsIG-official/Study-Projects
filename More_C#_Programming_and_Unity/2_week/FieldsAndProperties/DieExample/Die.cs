using System;
using System.Resources;

namespace DieExample
{
    /// <summary>
    /// A die
    /// </summary>
    public class Die
    {
        #region Fields

        int numSides;
        int topSide;
        Random rand = new Random();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor for 6-sided die
        /// </summary>
        public Die() : this(6)
		{
		}

        /// <summary>
        /// Constructor for numSided-sided die
        /// </summary>
        /// <param name="numSides">number of sides</param>
        public Die(int numSides)
		{
          //field           parameter
            this.numSides = numSides;
            //this is for object where we are now(public Die(int numSides))
            topSide = 1;
        }

        #endregion Constructors

        #region Properties
        //properties=the way that we let external classes access information about
        //the state of this particular object

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        /// <value>number of sides</value>
        public int NumSides
        {
            //good
            get { return numSides; }

            /*
            bad, because we can read and CHANGE value
            get { return numSides; }
            set { numSides = value; }
            */
        }

        /// <summary>
        /// Gets the top side
        /// </summary>
        /// <value>top side</value>
        public int TopSide
        {
            get { return topSide; }
        }

		#endregion

		#region Methods

		/// <summary>
		/// Rolls the die.
		/// </summary>
		public void Roll()
		{
            //if we will use it like this,then we will have the same result each time
            //Random rand = new Random();
            topSide = rand.Next(1, numSides + 1);
		}

		#endregion Methods
	}
}
