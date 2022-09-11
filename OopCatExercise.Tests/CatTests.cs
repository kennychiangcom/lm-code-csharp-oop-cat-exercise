using NUnit.Framework;
using FluentAssertions;

namespace OopCatExercise.Tests;

public class CatTests
{
    [Test]
    public void DomesticCat_Should_Be_Awake_By_Default()
    {
        DomesticCat domesticCat = new();
        domesticCat.IsAsleep.Should().Be(false);
    }

    [Test]
    public void DomesticCat_Should_Be_Asleep_When_GoToSleep_Is_Called()
    {
        DomesticCat domesticCat = new();
        domesticCat.GoToSleep();
        domesticCat.IsAsleep.Should().Be(true);
    }

    [Test]
    public void DomesticCat_Should_Be_Awake_When_WakeUp_Is_Called()
    {
        DomesticCat domesticCat = new();
        domesticCat.GoToSleep();
        domesticCat.WakeUp();
        domesticCat.IsAsleep.Should().Be(false);
    }

    [Test]
    public void DomesticCat_Setting_Should_Be_Domestic()
    {
        DomesticCat domesticCat = new();
        domesticCat.Setting.Should().Be("domestic");
    }

    [Test]
    public void DomesticCat_AverageHeight_Should_Be_Correct()
    {
        DomesticCat domesticCat = new();
        domesticCat.AverageHeight.Should().Be(23);
    }

    [Test]
    public void LionCat_AverageHeight_Should_Be_Correct()
    {
        LionCat lionCat = new();
        lionCat.AverageHeight.Should().Be(1100);
    }

    [Test]
    public void LionCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        LionCat lionCat = new();
        lionCat.Eat().Should().Be("Roar!!!!");
    }

    [Test]
    public void CheetahCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        CheetahCat cheetahCat = new();
        cheetahCat.Eat().Should().Be("Zzzzzzz");
    }

    [Test]
    public void DomesticCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        DomesticCat domesticCat = new();
        domesticCat.Eat().Should().BeOneOf("Purrrrrrr", "Purrrrrrr ~ It will do I suppose");
    }
}
