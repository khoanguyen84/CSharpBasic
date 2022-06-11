namespace OOP {
    class Duck : Anminal, IFlyable
    {
        public int Legs { get; set; }
        public Duck (int Legs, string Name) {
            this.Name = Name;
            this.Legs = Legs;
        }
        public override string Move () {
            return $"Dog moves by {this.Legs} legs";
        }
        public string Fly()
        {
            return $"{this.Name} can fly";
        }
    }
}