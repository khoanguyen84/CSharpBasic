namespace OOP_2
{
    class Chicken : AAnimal, IEdiable
    {
        public override string MakeSound(){
            return "OOOO";
        }
        public string HowToEat(){
            return "Throw fire";
        }
    }
}