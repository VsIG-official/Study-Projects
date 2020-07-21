using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{

    /// <summary>
    /// An employer-sponsored account
    /// </summary>
    class EmployerSponsoredAccount : MutualFund
    {
        #region Contructor

        public EmployerSponsoredAccount(float deposit) : base(deposit)
        {
        }

        #endregion

        #region Public methods

        public override void AddMoney(float amount)
        {
	        amount *= 2;

	        base.AddMoney(amount);
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Employer-Sponsored Account Balance: " + balance;
        }

        #endregion
    }
}
