using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionsController : MonoBehaviour
{

    [SerializeField]
    GameObject instructionsPanel;


    public void instructionsToggle()
    {
        if (instructionsPanel != null)
        {
            bool isActive = instructionsPanel.activeSelf;

            instructionsPanel.SetActive(!isActive);
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
