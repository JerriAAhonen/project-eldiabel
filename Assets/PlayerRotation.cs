using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public void LateUpdate()
    {
        var dir = PlayerMovement.Instance.MovementDirection;
        if (dir.sqrMagnitude > 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 0.15F);
    }
}
