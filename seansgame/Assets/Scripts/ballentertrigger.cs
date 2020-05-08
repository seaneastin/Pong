using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * this behavior makes it to where whenever the ball enters the trigger is will reposition the ball back to the start and add to the players score
 */
public class ballentertrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject ballspawner;

    [SerializeField]
    private scoreBehavior scorekeeper;

    /**
 * used to specify if this is the left trigger
 */
    public bool isthislefttrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = ballspawner.transform.position;

        Rigidbody ballrb = ball.GetComponent<Rigidbody>();

        ballrb.velocity = new Vector3(0f, 0f, 0f);

        ballrb.AddForce(new Vector3(700f, 0f, 700f));

        if (isthislefttrigger)
        {
            scorekeeper.rightscore++;
        }
        else
        {
            scorekeeper.leftscore++;
        }
    }
}
