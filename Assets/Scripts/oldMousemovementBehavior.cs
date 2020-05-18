using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * the old behavior for letting the player move using the mouse
 */
public class oldMousemovementBehavior : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;


    public float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);

        Plane playerPlane = new Plane(Vector3.up, transform.position);    
        float rayDistance = 0.0f;

        playerPlane.Raycast(mouseRay, out rayDistance);

        Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

        Vector3 moveDirection = targetPoint - transform.position;

        moveDirection.Normalize();


        moveDirection.z = 0;

        moveDirection.y = 0;

        moveDirection *= speed;

        Vector3 paddle = new Vector3(Mathf.Clamp(10f, 0f, 0f),0f,0f);
;
        transform.position = paddle;
        
        controller.SimpleMove(moveDirection);



    }

}
