using System;
namespace OOP_2
{
    class Staff : Object
    {
        public int StaffId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public Staff(int staffId, string fullname, int age)
        {
            this.StaffId = staffId;
            this.FullName = fullname;
            this.Age = age;
        }
        public override string ToString(){
            return  $"{this.StaffId},{this.FullName},{this.Age}";
        }
    }
}