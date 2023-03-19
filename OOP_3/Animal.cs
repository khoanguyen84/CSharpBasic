namespace OOP_3
{
    abstract class Animal
    {
        public int legs { get; set; }
        public abstract string Speak();
        public abstract string Move(); 
    }
}