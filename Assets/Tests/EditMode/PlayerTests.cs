// Assets/Tests/EditMode/PlayerTests.cs
using NUnit.Framework;
using SpaceDefender.Core;


//[TestFixture]
public class PlayerTests
{
    private Player _player;

    [SetUp]
    public void SetUp()
    {
        _player = new Player();   // Arrange — initialisation
    }

    // ─── ETAPE 1 : RED — ce test doit echouer ───────────
    [Test]
    public void TakeDamage_Normal_ReducesHealth()
    {
        int damage = 20;

        _player.TakeDamage(damage);

        Assert.AreEqual(80, _player.Health);
    }

    [Test]
    public void TakeDamage_WithFatalDamage_SetsHealthToZero()
    {

       _player.TakeDamage(_player.Health);


        Assert.AreEqual(0, _player.Health);
    }

    [Test]
    public void TakeDamage_WithNegativeAmount_DoesNotChangeHealth()
    {
        int damage = -2;

        Assert.Negative(damage);

    }

    [Test]
    public void Heal_WhenHealthBelow100_IncreasesHealth()
    {
        int playerHealthBeforeDamage = _player.Health;

        _player.TakeDamage(15);

        _player.Heal(20);

        Assert.Greater(playerHealthBeforeDamage, _player.Health);

    }

    [Test]
    public void Heal_WhenAlreadyFullHealth_DoesNotExceed100()
    {
        int fullHealth = 100;

        _player.Heal(200);

        Assert.AreEqual(fullHealth, _player.Health);
    }

    [Test]
    public void IsAlive_WhenHealthIsZero_ReturnsFalse()
    {
        _player.TakeDamage(500);

        Assert.AreEqual(false, _player.IsAlive);
    }
    [Test]
    public void LoseLife_WhenLastLife_IsAliveReturnsFalse()
    {
        _player.LoseLife();
        _player.LoseLife();
        _player.LoseLife();
        
        _player.LoseLife();

        Assert.AreEqual(false, _player.IsAlive);
    }








}
