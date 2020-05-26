//new
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();

    private void LateUpdate()
    {
        if (targetTransform.position.y < 4.5)
        {
            tempVec3.y = 4.5f;
        }
        else
        {
            tempVec3.y = targetTransform.position.y;
        }
        if (targetTransform.position.x > 2.65f)
        {
            tempVec3.x = 2.65f;
        }
        else if (targetTransform.position.x < -2.3f)
        {
            tempVec3.x = -2.3f;
        }
        else
        {
            tempVec3.x = targetTransform.position.x;
        }
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}
