using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
    }
    public class DomesticCat : Cat
    {
        public bool IsAsleep = false;
        public string Setting = "domestic";
        public int AverageHeight = 23;
        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }
        public string Eat()
        {
            return "Purrrrrrr";
        }
    }
    public class LionCat : Cat
    {
        public int AverageHeight = 1100;
        public string Eat()
        {
            return "Roar!!!!";
        }
    }
    public class CheetahCat : Cat
    {
        public string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
