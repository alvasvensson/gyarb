using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject[] girls;
    [SerializeField]
    GameObject[] boys;


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
            if (i != sceneController.girlSelected)
            {
                boys[i].SetActive(false);
            }
            else
            {
                boys[i].SetActive(true);
            }
        }
    }

    // hairController pickedHair = new();


    // // Start is called before the first frame update

    // // Update is called once per frame
    void Update()
    {


    }
}
