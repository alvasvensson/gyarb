using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Detta script kontrollerar insturktionspanelen som finns i speldelen av projektet
public class instructionsController : MonoBehaviour
{

    [SerializeField]
    GameObject instructionsPanel;

    [SerializeField]
    public TMP_Text buttonText;

    public void instructionsToggle()
    {
        if (instructionsPanel != null)
        {
            bool isActive = instructionsPanel.activeSelf;

            instructionsPanel.SetActive(!isActive);
            if (isActive == true)
            {
                buttonText.text = "I";
            }
            else if (isActive == false)
            {
                buttonText.text = "X";
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
