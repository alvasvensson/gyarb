using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterPlayController : MonoBehaviour
{


    [SerializeField]
    float speed = 1;

    [SerializeField]
    Transform transform;


    void Start()
    {

    }

    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(xMovement, yMovement);
        movement = movement.normalized * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
