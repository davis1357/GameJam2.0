using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitCounter : MonoBehaviour
{
    public int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if(counter>=5)
        {
            FindObjectOfType<Movement>().isMoving = false;
            FindObjectOfType<StartAndEndTexts>().WinText();
        }
    }
}
