namespace L11_ComparableObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person, IPerson, IComparable
    {
        public Teacher(int age, string name)
            : base(age, name)
        {

        }

        public int CompareTo(object obj)
        {
            Teacher teacherToCompare = (Teacher)obj;

            int difference = this.Name.CompareTo(teacherToCompare.Name);

            return difference;
        }
    }
}
