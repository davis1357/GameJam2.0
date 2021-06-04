using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField] Stats stats;
    [SerializeField] int secrecyModifier;
    [SerializeField] int teamMoraleModifier;
    [SerializeField] int budgetModifier;

    [SerializeField] Text textComponent;
    [SerializeField] NPCsInfo info;
    [SerializeField] Canvas canvas;
    [SerializeField] Image image;
    [SerializeField] Text recruitText;

    [SerializeField] StartAndEndTexts startAndEndText;

    bool isColliding = false;
    [SerializeField] bool recruited = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (isColliding == true && FindObjectOfType<Movement>().isMoving == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CheckingNPC();
            }
        }
        if (isColliding == true)
        {
            WaitingForAnswer();
        }
    }

    private void CheckingNPC()
    {
        FindObjectOfType<Movement>().isMoving = false;
        canvas.gameObject.SetActive(true);
        image.sprite = GetComponent<SpriteRenderer>().sprite;
        //TOdO: disable movement until exit out of info
        if (recruited == false)
        {
            recruitText.text = "Recruit? \n Y-Yes N-No";
            textComponent.text = info.GetInfo();
        }
        else
        {
            recruitText.text = "Press N to go Back";
            textComponent.text = "You already made this one join your cause";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isColliding = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isColliding = false;
    }

    private void WaitingForAnswer()
    {
        if (Input.GetKeyDown(KeyCode.Y) && recruited == false)
        {
            RecruitNPC();
            return;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            NotRecruit();
            return;
        }
    }

    private void NotRecruit()
    {
        canvas.gameObject.SetActive(false);
        FindObjectOfType<Movement>().isMoving = true;
    }

    private void RecruitNPC()
    {
        FindObjectOfType<RecruitCounter>().counter++;
        recruited = true;
        canvas.gameObject.SetActive(false);
        stats.ModifySecrecy(secrecyModifier);
        stats.ModifyTeamMorale(teamMoraleModifier);
        stats.ModifyBudget(budgetModifier);
        startAndEndText.TextAfterRecruit(info.GetAfterRecruitInfo());

       // FindObjectOfType<Movement>().isMoving = true;
    }
}
