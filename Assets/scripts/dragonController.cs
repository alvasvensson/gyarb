using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dragonController : MonoBehaviour
{

    [SerializeField]
    public static int hp = 3;

    [SerializeField]
    List<GameObject> hearts;
    [SerializeField]
    List<GameObject> noHearts;

    [SerializeField]
    public TMP_Text resultText;

    [SerializeField]
    GameObject gameOver;

    [SerializeField]
    GameObject dragon;

    [SerializeField]
    GameObject deadDragon;


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

        if (hp <= 0)
        {
            gameOver.SetActive(true);
            deadDragon.SetActive(true);
            dragon.SetActive(false);
        }

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
        hp--;
    }
}
