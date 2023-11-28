using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detta script spawnar karaktärerna som valdes och deras hår i speldelen av projektet
public class characterSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject[] girls;
    [SerializeField]
    GameObject[] boys;

    [SerializeField]
    GameObject[] gameHair;


    void Start()
    {
        for (int i = 0; i < girls.Length; i++)
        {
            if (i != sceneController.girlSelected)
            {
                girls[i].SetActive(false);
            }
            else
            {
                girls[i].SetActive(true);
            }
        }
        for (int i = 0; i < boys.Length; i++)
        {
            if (i != sceneController.boySelected)
            {
                boys[i].SetActive(false);
            }
            else
            {
                boys[i].SetActive(true);
            }
        }

        gameHair[sceneController.girlHairNumber].SetActive(true);
        gameHair[sceneController.boyHairNumber].SetActive(true);

    }

    void Update()
    {


    }
}
