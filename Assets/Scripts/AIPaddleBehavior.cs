using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


/**
 * Behavior for the AI paddle on its update it will seek the ball so that it prevents the player from scoring
 */
public class AIPaddleBehavior : MonoBehaviour
{

    public float speed = 1.0f;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private Rigidbody rigidbody;

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


        Vector3 force = direction * speed * 50;

        force = force - rigidbody.velocity;

        rigidbody.AddForce(force);



    }


}
