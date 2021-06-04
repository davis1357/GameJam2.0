using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseTexts : MonoBehaviour
{
    [SerializeField] Text loseText;

    public void HighSecrecy()
    {
        loseText.text = "You were acting in top secrecy. So secret in fact that you never left your base to start the operation. Press R to restart the game.";
    }

    public void LowSecrecy()
    {
        loseText.text = "All of you go around recruiting everyone in sight. Even the police. And by the police, it's the mayor dressed as a cop. He arrests you and throw you all to jail. Press R to restart the game.";
    }

    public void HighMorale()
    {
        loseText.text = "In the excitment you charged inside the city hall withouh a plan in sight.You got caught.Press R to restart the game.";
    }

    public void LowMorale()
    {
        loseText.text = "Everyone suddenly realizes that you can't do anything against the mayor. all of you start to accept your fate as homeless people, disbanding the revolution. Some even go as far as submiting to the mayor entirely. Press R to restart the game.";
    }

    public void HighBudget()
    {
        loseText.text = "The revolution is swimming with money. almost like a certain old bitter duck rich. You all decide to abandon the city and buy an island, leaving your mothers in jail while you drink from coconuts. You mosnters. Press R to restart the game";
    }

    public void LowBudget()
    {
        loseText.text = "You have no money. You even used your lucky coin. The others are revolting and demand payment. when they had enough they decide to give you over to the mayor in hopes of money. Sadly, he puts you in jail and execute them. After all, you can't trust a man who will sell out his Friends, right? Press R to restart the game";
    }

}
