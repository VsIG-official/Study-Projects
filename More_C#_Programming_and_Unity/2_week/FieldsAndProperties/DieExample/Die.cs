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

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        /// <value>number of sides</value>
        public int NumSides
        {
            get { return numSides; }
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

    }
}
