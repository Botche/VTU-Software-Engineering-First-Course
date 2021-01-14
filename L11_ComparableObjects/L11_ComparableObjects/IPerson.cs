namespace L11_ComparableObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IPerson
    {
        int Age { get; set; }

        string Name { get; set; }

        void PrintName();
    }
}
