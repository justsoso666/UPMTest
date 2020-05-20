using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMe : MonoBehaviour
{
    public float angularVelocity = 10;
   void Update ()
   {
       var rot = Quaternion.AngleAxis (angularVelocity * Time.deltaTime, Vector3.forward);
       transform.localRotation = rot * transform.localRotation;
   }
}
