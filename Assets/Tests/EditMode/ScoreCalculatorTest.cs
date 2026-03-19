using NUnit.Framework;
using SpaceDefender.Core;

public class ScoreCalculatorTest
{

    ScoreCalculator _scoreCalculator;
    Player _player;

    [SetUp]
    public void SetUp()
    { 
        _scoreCalculator = new ScoreCalculator();
        _player = new Player();
    }

    [Test]
    public void Calculate_WithZeroKills_ReturnsZero()
    {
        _scoreCalculator.Calculate();
    
        // Assert.Multiple(() =>
        // {
        //     Assert.That(_player.NumberOfKills, Is.EqualTo(0));
        //     Assert.That(_player.Score, Is.EqualTo(0));
        // });
    }

    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {

        _player.NumberOfKills = 3;

        _scoreCalculator.ApplyCombo();

        Assert.AreEqual(3, _scoreCalculator.Multiplier);
    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {

        _player.NumberOfKills = 4;

        _scoreCalculator.ApplyCombo();

        _scoreCalculator.ResetMultipler();

        Assert.AreEqual(1, _scoreCalculator.Multiplier);
    }

    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    { }



}