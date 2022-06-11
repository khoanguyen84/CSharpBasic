namespace AnimalApp {
    class Cat : IAnimal, ITerrestAnimal {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public string Move(){
            return "Run";
        }
    }
}