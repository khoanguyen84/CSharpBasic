namespace OOP
{
    class Dog : Anminal
    {
        public int Legs { get; set; }
        public Dog(int Legs, string Name)
        {
            this.Name = Name;
            this.Legs = Legs;
        }
        public override string Move()
        {
            return $"Dog moves by {this.Legs} legs";
        }
    }
}