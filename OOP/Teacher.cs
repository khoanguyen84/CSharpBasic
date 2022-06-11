namespace OOP {
    // class Teacher
    // {
    //     public int TearchId { get; set; }
    //     public string Fullname { get; set; }
    //     public int Age { get; set; }
    //     public bool Gender { get; set; }
    //     public int Salary { get; set; }

    //     public Teacher(int TearchId, string Fullname,int Age,bool Gender,int Salary)
    //     {
    //         this.TearchId = TearchId;
    //         this.Fullname = Fullname;
    //         this.Age = Age;
    //         this.Gender = Gender;
    //         this.Salary = Salary;
    //     }
    //     public string Greeting(){
    //         return $"{this.TearchId}, {this.Fullname}, {this.Age}, {this.Gender}, {this.Salary}";
    //     }
    // }
    class Teacher : Person {
        public int Salary { get; set; }
        public Teacher (int TeacherId, string Fullname, int Age, bool Gender, int Salary) : base (TeacherId, Fullname, Age, Gender) {
            this.Salary = Salary;
        }
        public override string Greeting(){
            return $"{base.Greeting()}, {this.Salary}, {this.Gender}";
        }
    }
}