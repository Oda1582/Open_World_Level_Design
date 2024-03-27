using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegManager : MonoBehaviour
{

    public bool IsLeft;
    public GameObject Hip, Knee;
    float Rotation, smooth = 50;

    void Update()
    {
        if (IsLeft)
        {
            Rotation = Input.GetAxis("LeftTrigger");
            Quaternion HipTarget = Quaternion.Euler(Rotation * -90, 0, 0);
            Hip.transform.rotation = Quaternion.Slerp(Hip.transform.rotation, HipTarget, Time.deltaTime * smooth);
            Quaternion KneeTarget = Quaternion.Euler(0, 0, 0);
            Knee.transform.rotation = Quaternion.Slerp(Knee.transform.rotation, Quaternion.identity, Time.deltaTime * smooth);
        }
        else
        {
            Rotation = Input.GetAxis("RightTrigger");
            Quaternion HipTarget = Quaternion.Euler(Rotation * -90, 0, 0);
            Hip.transform.rotation = Quaternion.Slerp(Hip.transform.rotation, HipTarget, Time.deltaTime * smooth);
            Quaternion KneeTarget = Quaternion.Euler(0, 0, 0);
            Knee.transform.rotation = Quaternion.Slerp(Knee.transform.rotation, Quaternion.identity, Time.deltaTime * smooth);
        }
    }
}
