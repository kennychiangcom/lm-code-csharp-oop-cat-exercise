using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        private bool AsleepStatus;

        public string Setting;
        public int AverageHeight;

        public bool IsAsleep
        {
            get { return AsleepStatus; }
            set { AsleepStatus = value; }
        }

        public abstract string Eat();

        public virtual void GoToSleep()
        {
            IsAsleep = true;
        }

        public virtual void WakeUp()
        {
            IsAsleep = false;
        }
    }
    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            Setting = "domestic";
            AverageHeight = 23;
        }

        public override string Eat()
        {
            const double HALF_HALF_CHANCE = 0.5;
            string returnString = "Purrrrrrr";
            var random = new Random().NextDouble();
            if (random < HALF_HALF_CHANCE) returnString += " ~ It will do I suppose";
            return returnString;
        }
    }
    public class LionCat : Cat
    {
        public LionCat()
        {
            Setting = "wild"; 
            AverageHeight = 1100;
        }

        public override string Eat() => "Roar!!!!";
    }
    public class CheetahCat : Cat
    {
        public CheetahCat()
        {
            Setting = "wild";
            AverageHeight = 800;
        }

        public override string Eat() => "Zzzzzzz";
    }
}
