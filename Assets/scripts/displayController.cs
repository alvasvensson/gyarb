using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class displayController : MonoBehaviour
{
    [SerializeField]
    public TMP_Text girlText;
    [SerializeField]
    public TMP_Text boyText;


    // [SerializeField]
    // GameObject tjejSelector;
    // Start is called before the first frame update
    void Start()
    {
        girlText.text = "1: " + sceneController.girlSelected + ":" + sceneController.girlHairNumber;
        boyText.text = "2: " + sceneController.boySelected + ":" + sceneController.boyHairNumber;

        // print(sceneController.girlSelected);
        // print(sceneController.girlHair);
        // print(sceneController.boySelected);
        // print(sceneController.boyHair);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
