namespace OOP
{
    class Cat : Anminal
    {
        public int Legs { get; set; }
        public Cat(int Legs, string Name)
        {
            this.Name = Name;
            this.Legs = Legs;
        }

        public override string Move()
        {
            return $"Cat moves by {this.Legs} legs";
        }
    }
}