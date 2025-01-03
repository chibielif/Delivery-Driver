using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //this thing's (camera) position should be the same as the car's position
    [SerializeField] GameObject thingToFollow;

    void LateUpdate() //we're using LateUpdate so that the camera and the car will move at the exact same time
    {
        transform.position = thingToFollow.transform.position + new Vector3 ( 0, 0, -1 );
    }
}
