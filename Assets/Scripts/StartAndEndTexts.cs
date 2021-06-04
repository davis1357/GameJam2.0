using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAndEndTexts : MonoBehaviour
{
    [SerializeField] Text outcomeText;
    [SerializeField] Canvas outcomeCanvas;

    private void Start()
    {
        FindObjectOfType<Movement>().isMoving = false;
    }

    private void Update()
    {
        if (FindObjectOfType<Movement>().isMoving == false && Input.GetKeyDown(KeyCode.Space))
        {
            outcomeCanvas.gameObject.SetActive(false);
            FindObjectOfType<Movement>().isMoving = true;
        }
    }

    public void WinText()
    {
        outcomeCanvas.gameObject.SetActive(true);
        outcomeText.text = "You were able to overthrow the mayor! per the rules before his changes, you decide to take him to court tommorow. The day comes and you realize your mistake. The mayor is the only judge. thus, he is deemed inoccent and you all go to jail. At least you are with mom XD press R if you wish to restart";
    }

    public void TextAfterRecruit(string infoAfterRecruit)
    {
        outcomeCanvas.gameObject.SetActive(true);
        outcomeText.text = infoAfterRecruit;
    }
}
