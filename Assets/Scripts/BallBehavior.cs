using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/**
 * the behavior for the ball on start it will add a force to make the ball move
 */
public class BallBehavior : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity.z = -700f;
        velocity.x = -700f;

        rigidbody.AddForce(velocity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
