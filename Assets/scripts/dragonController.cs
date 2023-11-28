using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Detta script kontrollerar draken i speldelen av projektet
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

    [SerializeField]
    Animator anim;


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

    public void Hurt()
    {
        hp--;
        anim.gameObject.SetActive(true);
        anim.SetTrigger("hit");
    }
}
