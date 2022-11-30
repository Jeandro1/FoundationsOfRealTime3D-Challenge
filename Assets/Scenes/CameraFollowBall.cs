using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offset.x = 0;
        offset.y = 2;
        offset.z = 0;
        transform.position = Ball.transform.position + offset;
    }
}
