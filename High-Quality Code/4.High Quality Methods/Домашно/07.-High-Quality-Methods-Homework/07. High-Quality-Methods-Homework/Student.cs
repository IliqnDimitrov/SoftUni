//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="ilqkaCompany">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Methods
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// The class create students.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The field first name of the student.
        /// </summary>
        private string firstName;

        /// <summary>
        /// The field last name of the student.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="firstName">
        /// The First name
        /// </param>
        /// <param name="lastName">
        /// The Last Name
        /// </param>
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Gets or sets first name of the student.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets last name of the student.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets Additional info of the student.
        /// </summary>
        public string AditionalInfo { get; set; }

        /// <summary>
        /// The boolean method check one student is older than other student.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>
        /// </returns>
        public bool IsOlderThan(Student other)
        {
            try
            {
                DateTime thisStudentDateOfBirth = this.GetDateOfBirth(this.AditionalInfo);
                DateTime otherStudentDateOfBirth = other.GetDateOfBirth(other.AditionalInfo);
                return thisStudentDateOfBirth < otherStudentDateOfBirth;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentException("one or both students do not have valid date of birth information provided.");
            }
        }

        /// <summary>
        /// The method get date of birth of the student.
        /// </summary>
        /// <param name="info">
        /// The info.
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>
        /// </returns>
        public DateTime GetDateOfBirth(string info)
        {
            string[] paramArgs = info.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string dateinfo = paramArgs.Last().Substring(8).Trim();

            if (!IsValidBulgarianFormatDate(dateinfo))
            {
                throw new FormatException("Invalid date format.");
            }

            DateTime date = DateTime.Parse(dateinfo);

            return date;
        }

        /// <summary>
        /// The method check is valid Bulgarian format date.
        /// </summary>
        /// <param name="dateinfo">
        /// The date info.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>
        /// </returns>
        private static bool IsValidBulgarianFormatDate(string dateinfo)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            DateTime date;

            bool isValidDate = DateTime.TryParse(dateinfo, out date);

            return isValidDate;
        }
    }
}