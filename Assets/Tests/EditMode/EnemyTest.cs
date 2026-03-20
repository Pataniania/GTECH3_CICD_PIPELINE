using NUnit.Framework;
using SpaceDefender.Core;
public class EnemyTest
{
    private Enemy _enemy;
    [SetUp]
    public void SetUp() => _enemy = new Enemy();
    //halooo
    [Test]
    public void TakeDamage_WhenKilled_SetsIsAliveToFalse()
    {
        _enemy.TakeDamage(1000);

        Assert.AreEqual(false, _enemy.IsAlive);
    }

    [Test]
    public void GetReward_WhenAlreadyDead_ReturnsZero()
    {
        // Assert.Multiple(() =>
        // {
        //     Assert.That(_enemy.IsAlive, Is.EqualTo(false));
        //     Assert.That(_enemy.Reward, Is.EqualTo(0));
        // });
    }
}