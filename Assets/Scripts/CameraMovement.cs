using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] public Transform target;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(target.position.x, target.position.y, -10);
    }
}
