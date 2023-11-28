using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Detta script skriver ut vilka kläder och hår som valdes i den sista scenen i spelet
public class displayController : MonoBehaviour
{
    [SerializeField]
    public TMP_Text girlText;
    [SerializeField]
    public TMP_Text boyText;

    
    void Start()
    {
        girlText.text = "1: " + sceneController.girlSelected + ":" + sceneController.girlHairNumber;
        boyText.text = "2: " + sceneController.boySelected + ":" + sceneController.boyHairNumber;
    }

}
