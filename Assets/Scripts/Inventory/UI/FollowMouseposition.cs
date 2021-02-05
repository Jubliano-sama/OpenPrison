using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseposition : MonoBehaviour
{
    void LateUpdate()
    {
        transform.position = Input.mousePosition;       
    }
}
