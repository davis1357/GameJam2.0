using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    Text statsText;
    //LoseTexts loseTexts;

    [SerializeField] public int secrecy = 50;
    [SerializeField] public int teamMorale = 50;
    [SerializeField] public int budget = 50;

    [SerializeField] Canvas loseCanvas;

    private void Start()
    {
        statsText = GetComponent<Text>();
        UpdateStats();
    }

    private void UpdateStats()
    {
        statsText.text = secrecy.ToString() + "\n" + teamMorale.ToString() + "\n" + budget.ToString();
    }

    public void ModifySecrecy(int modifier)
    {
        secrecy += modifier;
        UpdateStats();
        if (secrecy >= 100)
        {
            loseCanvas.gameObject.SetActive(true);
            FindObjectOfType<LoseTexts>().HighSecrecy();
            FindObjectOfType<Movement>().isMoving = false;
        }
        if (secrecy <= 0)
        {
            loseCanvas.gameObject.SetActive(true);
            FindObjectOfType<LoseTexts>().LowSecrecy();
            FindObjectOfType<Movement>().isMoving = false;
        }
    }

    public void ModifyTeamMorale(int modifier)
    {
        teamMorale += modifier;
        UpdateStats();
        if (teamMorale >= 100)
        {
            loseCanvas.gameObject.SetActive(true);
            FindObjectOfType<LoseTexts>().HighMorale();
            FindObjectOfType<Movement>().isMoving = false;
        }
        if (teamMorale <= 0)
        {
            loseCanvas.gameObject.SetActive(true);
            FindObjectOfType<LoseTexts>().LowMorale();
            FindObjectOfType<Movement>().isMoving = false;
        }
    }

    public void ModifyBudget(int modifier)
    {
        budget += modifier;
        UpdateStats();
        if (budget >= 100)
        {
            loseCanvas.gameObject.SetActive(true);
            FindObjectOfType<LoseTexts>().HighBudget();
            FindObjectOfType<Movement>().isMoving = false;
        }
        if (budget <= 0)
        {
            loseCanvas.gameObject.SetActive(true);
            FindObjectOfType<LoseTexts>().LowBudget();
            FindObjectOfType<Movement>().isMoving = false;
        }
    }
}
