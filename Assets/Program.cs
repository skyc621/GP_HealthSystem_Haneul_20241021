using System;
public class HealthSystem
{
    // Variables
    public int health;
    public string healthStatus;
    public int shield;
    public string shieldStatus;
    public int lives;

    

    // Optional XP system variables
    public int xp;
    public int level;

    public HealthSystem()
    {
        ResetGame();
    }

    public string ShowHUD()
    {
        // Implement HUD display
        healthStatus = health.ToString();
        shieldStatus = shield.ToString();
        return "HP- " + healthStatus + "  " + "Def- " + shieldStatus + " Lives- "+ lives.ToString();
    }

    public void TakeDamage(int damage)
    {
        // Implement damage logic
        shield = shield - damage;
        
        if(shield <= 0)
        {
            health = health + shield;
        }
        
        
        if (shield < 0)
        {
            shield = 0;
        }

        if ( health <= 0 && lives > 0) 
        {
            lives -= 1;
            Revive();
        }

    }

    public void Heal(int hp)
    {
        // Implement healing logic
        
        health += hp;
        if(health > 100)
        {
            health = 100;
        }
    }

    public void RegenerateShield(int def)
    {
        // Implement shield regeneration logic
        shield += def;
    }

    public void Revive()
    {
        // Implement revive logic
        health = 100;
    }

    public void ResetGame()
    {
        // Reset all variables to default values
        health = 100;
        lives = 3;
    }

    // Optional XP system methods
    public void IncreaseXP(int exp)
    {
        // Implement XP increase and level-up logic
        xp += exp;
    }
}