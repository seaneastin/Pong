using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAIPaddleBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //rigidbody.velocity = new Vector3(0f, 0f, 0f);

        Vector3 pos = transform.position;

        Vector3 targetpos = ball.transform.position;

        Vector3 direction = targetpos - pos;

        direction.Normalize();




        direction.y = 0;
        direction.z = 0;
        direction *= speed;
        controller.SimpleMove(direction);



    }
}
