using System;
using System.Diagnostics;
public class HealthSystem
{
    // Variables
    public int health;
    public string healthStatus;
    public int shield = 100;
    //public string shieldStatus;
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
        switch (health)
        {
            case <= 10:
                healthStatus = "Imminent Danger";
                break;

            case <= 50:
                healthStatus = "Badly Hurt";
                break;

            case <= 75:
                healthStatus = "Hurt";
                break;

            case <= 90:
                healthStatus = "Heathy";
                break;

            case <= 100:
                healthStatus = "Perfect Health";
                break;

            default:

                break;
        }
        return "HP " + health.ToString() + " -> " + healthStatus + "  " + "   Def " + shield.ToString() + " Lives " + lives.ToString();
    }

    public void TakeDamage(int damage)
    {
        // Implement damage logic
        Debug.Assert(damage == 30);

        shield = shield - damage;

        if (shield <= 0)
        {
            health = health + shield;
            
            if (shield < 0)
            {
                shield = 0;
            }
        }


        if (health <= 0 && lives > 0)
        {
            Revive();
        }

        if (health < 0)
        {
            health = 0;
        }

    }

    public void Heal(int hp)
    {
        // Implement healing logic
        Debug.Assert(hp < 0);
        
        health += hp;

        if (health > 100)
        {
            health = 100;
        }
    }

    public void RegenerateShield(int def)
    {
        // Implement shield regeneration logic
        Debug.Assert(def < 0);
        
        shield += def;
        
        if (shield > 100)
        {
            shield = 100;
        }
    }

    public void Revive()
    {
        // Implement revive logic
        lives -= 1;
        health = 100;
        shield = 100;

        Debug.Assert(0 <= health);
        Debug.Assert(0 <= shield);
        Debug.Assert(0 < lives);
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