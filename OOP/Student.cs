namespace OOP {
    // class Student
    // {
    //     public int StudentId { get; set; }
    //     public string Fullname { get; set; }
    //     public int Age { get; set; }
    //     public bool Gender { get; set; }
    //     public double AverageScore { get; set; }

    //     public Student(int StudentId, string Fullname,int Age,bool Gender,double AverageScore)
    //     {
    //         this.StudentId = StudentId;
    //         this.Fullname = Fullname;
    //         this.Age = Age;
    //         this.Gender = Gender;
    //         this.AverageScore = AverageScore;
    //     }

    //     public string Greeting(){
    //         return $"{StudentId}, {Fullname}, {Age}, {Gender}, {AverageScore}";
    //     }
    // }
    class Student : Person {
        public double AverageScore { get; set; }
        public Student (int StudentId, string Fullname, int Age, bool Gender, double AverageScore) : base (StudentId, Fullname, Age, Gender) 
        {
            this.AverageScore = AverageScore;
        }
        public override string Greeting(){
            return $"{base.Greeting()}, {this.AverageScore}";
        }
    }
}