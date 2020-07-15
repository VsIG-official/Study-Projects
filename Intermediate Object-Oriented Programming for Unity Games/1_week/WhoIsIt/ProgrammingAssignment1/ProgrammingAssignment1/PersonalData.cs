using System;
using System.IO;

namespace ProgrammingAssignment1
{
	/// <summary>
	/// A class holding personal data for a person
	/// </summary>
	public class PersonalData
	{
		#region Properties

		/// <summary>
		/// Gets the person's first name
		/// </summary>
		public string FirstName { get; } = "";

		/// <summary>
		/// Gets the person's middle name
		/// </summary>
		public string MiddleName { get; } = "";

		/// <summary>
		/// Gets the person's last name
		/// </summary>
		public string LastName { get; } = "";

		/// <summary>
		/// Gets the person's street address
		/// </summary>
		public string StreetAddress { get; } = "";

		/// <summary>
		/// Gets the person's city or town
		/// </summary>
		public string City { get; } = "";

		/// <summary>
		/// Gets the person's state or province
		/// </summary>
		public string State { get; } = "";

		/// <summary>
		/// Gets the person's postal code
		/// </summary>
		public string PostalCode { get; } = "";

		/// <summary>
		/// Gets the person's country
		/// </summary>
		public string Country { get; } = "";

		/// <summary>
		/// Gets the person's phone number (digits only, no
		/// parentheses, spaces, or dashes)
		/// </summary>
		public string PhoneNumber { get; } = "";

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// Reads personal data from a file. If the file
		/// read fails, the object contains an empty string for all
		/// the personal data
		/// </summary>
		/// <param name="fileName">name of file holding personal data</param>
		public PersonalData(string fileName)
		{
			StreamReader input = null;
			string line = null;
			try
			{
				input = File.OpenText(fileName);

				line = input.ReadLine();
			}
			catch (Exception e)
			{
				if (input == null)
				{
					Console.WriteLine(e.Message);
				}
			}
			finally
			{
				if (input != null)
				{
					input.Close();
				}
			}

			string[] CSVvalues = line.Split(',');
			FirstName = CSVvalues[0];
			MiddleName = CSVvalues[1];
			LastName = CSVvalues[2];
			StreetAddress = CSVvalues[3];
			City = CSVvalues[4];
			State = CSVvalues[5];
			PostalCode = CSVvalues[6];
			Country = CSVvalues[7];
			PhoneNumber = CSVvalues[8];
		}

		#endregion
	}
}
