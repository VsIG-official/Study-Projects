using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        string firstName = "";
        string middleName = "";
        string lastName = "";
        string streetAddress = "";
        string city = "";
        string state = "";
        string postalCode = "";
        string country = "";
        string phoneNumber = "";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get { return middleName; }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get { return streetAddress; }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get { return city; }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get { return state; }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get { return country; }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains empty strings for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // read and save personal data from file
            StreamReader input = null;
            try
            {
                // create stream reader object
                input = File.OpenText(fileName);

                // read in csv string of data
                string data = input.ReadLine();

                // set personal data fields
                SetPersonalDataFields(data);
            }
            catch (Exception e)
            {
            }
            finally
            {
                // always close input file
                if (input != null)
                {
                    input.Close();
                }
            }
        }

        /// <summary>
        /// Sets the personal data fields from the provided
        /// csv string
        /// </summary>
        /// <param name="csvValues">csv string of values</param>
        void SetPersonalDataFields(string csvValues)
        {
            // the code below assumes we know the order in which the
            // values appear in the string. We could do something more
            // complicated with the names and values, but that's not
            // necessary here

            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data

            // extract first name
            int commaLocation = csvValues.IndexOf(',');
            firstName = csvValues.Substring(0, commaLocation);

            // move along string and extract middle name
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            middleName = csvValues.Substring(0, commaLocation);

            // move along string and extract last name
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            lastName = csvValues.Substring(0, commaLocation);

            // move along string and extract street address
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            streetAddress = csvValues.Substring(0, commaLocation);

            // move along string and extract city
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            city = csvValues.Substring(0, commaLocation);

            // move along string and extract state
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            state = csvValues.Substring(0, commaLocation);

            // move along string and extract postal code
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            postalCode = csvValues.Substring(0, commaLocation);

            // move along string and extract country
            csvValues = csvValues.Substring(commaLocation + 1);
            commaLocation = csvValues.IndexOf(',');
            country = csvValues.Substring(0, commaLocation);

            // move along string and extract phoneNumber
            phoneNumber = csvValues.Substring(commaLocation + 1); 
        }

        #endregion
    }
}
