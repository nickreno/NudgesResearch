using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCollision : MonoBehaviour
{

    public static int planeCollisionCounterReno = 0;

    public Rigidbody rigb;

    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {

        GameObject otherObj = collider.gameObject;
        if (otherObj.name.Contains("Checkpoint-"))
        {
            //Debug.Log("Triggered with: " + otherObj.name + "---" + planeCollisionCounterReno++);
            //Debug.Log(otherObj.name + " speed: " + currSpeed + "******************************************************************");
            //Debug.Log(otherObj.name + " speed: " + currSpeed.ToString("n0"));
        }

    }
}
