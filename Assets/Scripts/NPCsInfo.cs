using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="NPCInfo")]
public class NPCsInfo : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string info;
    [TextArea(10, 14)] [SerializeField] string afterRecruitInfo;

    // Start is called before the first frame update
    public string GetInfo()
    {
        return info;
    }

    public string GetAfterRecruitInfo()
    {
        return afterRecruitInfo;
    }
}
