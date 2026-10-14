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
        int goblinAttack = 10;
        int defense = 10;
        // (PART B) TODO B1: declare your stats here, at the very top of Start,
        //          once you have had the Variables lecture. You will need:
        //            playerName (string), health (int), attack (int),
        //            agility (int), gold (int), hasKey (bool),
        //            goblinHealth (int), goblinAttack (int).

        // ===== ALREADY BUILT IN CLASS (Intro lecture): the opening + two rooms =====
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins."); // replace Hero with the name of your player.

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        Debug.Log("A goblin wakes up enraged. You take " + (goblinAttack - defense) + " damage.");
        health = health - (goblinAttack - defense);
        Debug.Log("You now have " + health + " health.");
        Debug.Log("You attack the goblin. The goblin takes " + attack + " damage.");
        goblinHealth = goblinHealth - attack;
        Debug.Log("The goblin now has " + goblinHealth + " health.");
        Debug.Log("The goblin is undefeated");
        Debug.Log("You move into the next room.");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        Debug.Log("");
        Debug.Log("The Flooded Passage");
        // there was a missing semicolon
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        Debug.Log("You move into the next room.");

        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
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


        // ======================================================================
        // PART B  -  after the VARIABLES lecture (variables & operators)
        // ======================================================================

        // TODO B2: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        gold = 15;
        // "gold" has already been declared at the top of start
        Debug.Log("");
        Debug.Log("The Treasure Room");
        //Missing ""
        Debug.Log("It seems this room has been raided. You find " + 5000 + " gold.");
        Debug.Log("You move into the next room.");
        //Missing " at the end, and missing semicolon

        // TODO B3: Go back through your rooms above and add an event/item to each
        //          one that changes a stat/variable, printing the new value right
        //          after the event. Like with the gold in the treasure room, keep
        //          each event inside the room where it happens. Possible events:
        //            pick up a sword to increase attack      
        //            step on a trap        
        //            grab the rusty key    
        //            (your own event)

        // TODO B4: In the appropriate room, add a goblin. The goblin attacks the
        //          player and the player attacks the goblin. Use the variables
        //          you've created in PART A to simulate this with code. After the
        //          simulation is done, Print both healths, then print whether or 
        //          not the goblin is defeated. 

        // TODO B5: Add a new room somewhere before the exit that has a merchant. 
        //          The merchant sells potions for 5 gold each. Print how many
        //          potions you can afford and how much gold you will have left over. 

        // TODO B6: Add a defense stat (declare it up top with the others). Use it
        //          in your combat so the goblin's hit damage is reduced by your
        //          defense and your hit damage is reduced by the goblin's defense
        //          Then, add an item that raises defense in a room. 
    }
}
