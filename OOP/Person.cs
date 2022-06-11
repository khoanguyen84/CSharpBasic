namespace OOP
{
    class Person
    {
        public int PersonId { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        protected bool Gender { get; set; }

        public Person(int PersonId, string Fullname,int Age,bool Gender)
        {
            this.PersonId = PersonId;
            this.Fullname = Fullname;
            this.Age = Age;
            this.Gender = Gender;
        }
        public virtual string Greeting(){
            return $"{this.PersonId}, {this.Fullname}, {this.Age}, {this.Gender}";
        }
    }
}