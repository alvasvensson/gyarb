using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterPlayController : MonoBehaviour
{


    [SerializeField]
    float speed = 1;

    [SerializeField]
    Transform transform;

    [SerializeField]
    public int timeBetweenHits = 1;

    [SerializeField]
    float timer = 0;

    public static bool swordSwung = false;


    List<GameObject> currentEnemiesInRange = new();

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
        timer += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && timer > timeBetweenHits)
        {
            // swordSwung = true;
            // print(swordSwung);

            foreach (GameObject e in currentEnemiesInRange)
            {
                dragonController d = e.GetComponent<dragonController>();
                if (d)
                {
                    d.Hurt();
                }
            }

            timer = 0;
        }
        else
        {
            // swordSwung = false;
            // print(swordSwung);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        currentEnemiesInRange.Add(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        currentEnemiesInRange.Remove(other.gameObject);
    }
}
