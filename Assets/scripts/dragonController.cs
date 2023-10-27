using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonController : MonoBehaviour
{

    [SerializeField]
    public int hp = 3;

    [SerializeField]
    List<GameObject> hearts;
    [SerializeField]
    List<GameObject> noHearts;

    // Start is called before the first frame update
    void Start()
    {
        print(hp);
    }

    // Update is called once per frame
    void Update()
    {
        hearts[hp].SetActive(false);
        noHearts[hp].SetActive(true);

    }

    // private void OnTriggerStay2D(Collider2D other)
    // {

    //     print(characterPlayController.swordSwung);
    //     if (characterPlayController.swordSwung == true)
    //     {
    //         hp--;
    //         print(hp);
    //     }

    // }

    public void Hurt()
    {
        print("ouch!");
        hp--;
    }
}
