using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        private bool AsleepStatus;

        public string Setting = "domestic";
        public int AverageHeight = 23;

        public abstract string Eat();

        public bool IsAsleep
        {
            get { return AsleepStatus; }
            set { AsleepStatus = value; }
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }
    }
    public class DomesticCat : Cat
    {
        public override string Eat()
        {
            return "Purrrrrrr";
            //return "It will do I suppose";
        }
    }
    public class LionCat : Cat
    {
        public new int AverageHeight = 1100;
        public new string Setting = "wild";
        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
    public class CheetahCat : Cat
    {
        public new string Setting = "wild";
        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
