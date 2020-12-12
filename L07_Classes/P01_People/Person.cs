namespace P01_People
{
    using System;
    using System.Text;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int? age;

        public Person(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.Age = age;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            this.LastName = lastName;
        }

        public Person(string firstName)
            : this()
        {
            this.FirstName = firstName;
        }

        public Person()
        {
            this.FirstName = "Unset";
            this.LastName = "Unset";
            this.Age = null;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(FirstName), "First name can not be empty!");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("First name lenght is shorter than 3 symbols.");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(FirstName), "Last name can not be empty!");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Last name lenght is shorter than 3 symbols.");
                }

                lastName = value;
            }
        }

        public int? Age 
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age must be in range [0, 120].");
                }

                age = value;
            }
        }

        public string ChangeFirstName(string name)
        {
            this.FirstName = name;

            return this.FirstName;
        }

        public string HappyBirthDay()
        {
            this.Age++;

            return "Happy BirthDay!!!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hi, my name is {this.FirstName} {this.LastName}.");

            if (this.Age != null)
            {
                sb.AppendLine($"I am {this.Age} yo.");
            }

            return sb.ToString();
        }
    }
}
