using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseposition : MonoBehaviour
{
    void Update()
    {
        transform.position = Input.mousePosition;       
    }
}
