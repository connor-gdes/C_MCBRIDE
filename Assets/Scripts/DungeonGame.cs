using UnityEngine;

// ==========================================================================
// THE DUNGEON - Homework (Intro to C#  +  Variables & Operators)
// --------------------------------------------------------------------------
// One growing program - keep building this SAME file.
//   PART A: do after the INTRO lecture (uses only Debug.Log).
//   PART B: finish after the VARIABLES lecture (variables & operators).
// Attach to an empty GameObject and press Play to test as you go.
// ==========================================================================
public class DungeonGame : MonoBehaviour
{
    void Start()
    {

        string playerName = "WorkInprogress";
        int health = 100;
        int attack = 30;
        int agility;
        int gold = 53;
        bool hasKey = false;
        int goblinHealth = 50;
        int goblinAttack = 15;
        int defense = 10;
        
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins.");

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        Debug.Log("A goblin wakes up enraged. You take " + (goblinAttack - defense) + " damage.");
        health = health - (goblinAttack - defense);

        if (health > 0)
        {
            Debug.Log("You have survived the attack!");
            Debug.Log("You now have " + health + " health.");
            Debug.Log("You attack the goblin. The goblin takes " + attack + " damage.");
            goblinHealth = goblinHealth - attack;
            if (goblinHealth > 0)
            {
                Debug.Log("The goblin is undefeated.");
                Debug.Log("The goblin now has " + goblinHealth + " health.");
            }
            else if (goblinHealth <= 0)
            {
                Debug.Log("The goblin has been defeated!");
            }
        }
        else if (health <= 0)
        {
            Debug.Log("You have died!");
        }
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Flooded Passage");
        
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        Debug.Log("You move into the next room.");
        
        Debug.Log("");
        Debug.Log("The Dark Hallway");
        Debug.Log("A dark, empty hallway stretches into the distance.");
        Debug.Log("A key sits on the floor, you pick it up.");
        hasKey = true;
        Debug.Log("You exit through the door at the end.");

        Debug.Log("");
        Debug.Log("The Market");
        Debug.Log("A merchant stands at their booth advertizing potions for 5 gold each.");
        Debug.Log("You can afford " + (gold / 5) + " potions, with " + (gold % 5) + "left over.");
        Debug.Log("You pick up a shiny rock as you exit the room. The rock buffs your defense.");
        defense = defense + 5;
        Debug.Log("Your defense is now " + defense + ". You exit the room.");

        Debug.Log("");
        Debug.Log("The Vault");
        Debug.Log("A heavy metal door stands between you and the outside world.");
        Debug.Log("You use the key to unlock the door.");
        hasKey = false;
        Debug.Log("You exit through the door and leave the dungeon.");

        gold = 15;
        
        Debug.Log("");
        Debug.Log("The Treasure Room");
        Debug.Log("It seems this room has been raided. You find " + 5000 + " gold.");
        Debug.Log("You move into the next room.");

        // ================= PART A - CONDITIONALS (do after L7) =================
        // A1: After the goblin fight, report whether the goblin was defeated or
        //     the hero was the one who fell.

        // A2: At a vault door, the hero may pass only if they are carrying the
        //     key and are still alive. If they cannot pass, report which of the
        //     two requirements they are missing.

        // A3: The passage forks in two. Send the hero down one of the routes and
        //     describe each one - the two routes may even rejoin at the same
        //     place further on.

        // A4: As the hero explores, every third room they enter has a red glow.
        //     Given the number of the room the hero is standing in, report
        //     whether this room has the red glow.

        // A5: Whenever the hero takes damage, report their condition: collapsed
        //     if no health remains, badly wounded if their health has dropped
        //     dangerously low, or otherwise hurt but steady. This is a snippet
        //     you will reuse a lot - go back through everything you have already
        //     written (INCLUDING your previous assignment) and drop it in right
        //     after every place the hero loses health (the spike trap, and
        //     anywhere else). You will add it again in Part B after each hit the
        //     hero takes in a fight.



        // ================= PART B - LOOPS (do after L8) =================

        // Place the following combat encounters in different rooms of your choice.

        // B1: A goblin blocks the way - fight it round by round until one of you
        //     runs out of health. Give the hero and the goblin each an armor
        //     class. On every swing, roll a die (Random.Range works well) and
        //     compare it to the target's armor class: the blow only lands if the
        //     roll meets or beats that armor class. On top of that, any of the
        //     hero's landed hits can be a critical hit that deals extra damage.
        //     Report each roll and its result, and after any round in which the
        //     hero takes damage, run your A5 condition check.

        // B2: Beyond the goblin waits an ogre - slow, but brutal. Fight it the
        //     same way (armor classes, dice rolls to hit, and the hero's chance
        //     to crit), except the ogre is so sluggish it only swings every
        //     other round. Fight until one of them falls, and keep running your
        //     A5 check whenever the hero takes damage.

        // B3: Then a giant spider drops from the ceiling. Fight it just like the
        //     ogre - dice-and-armor-class swings, the hero's crits, and it too
        //     only strikes every other round - but its bite is venomous: any
        //     time it lands a hit, the hero is poisoned and loses 2 health at
        //     the start of each of the next three rounds, on top of the bite
        //     itself. Fight until one of them falls, running your A5 check after
        //     any damage (including the poison ticks).

        // B4: With the fights behind them, the hero rests at a campfire,
        //     recovering a little health each turn until fully healed or the
        //     fire dies after a set number of turns. Report their health as it
        //     climbs, and never let it rise above the maximum.

    }
}
