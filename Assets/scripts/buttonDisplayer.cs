using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonDisplayer : MonoBehaviour
{

    [SerializeField]
    pickController tjejSelector;

    [SerializeField]
    pickController killSelector;

    [SerializeField]
    GameObject button;

    public static int girlSelected;
    public static int boySelected;

    void Start()
    {

    }

    void Update()
    {
        girlSelected = tjejSelector.currentSelection;
        boySelected = killSelector.currentSelection;

        if (girlSelected >= 0 && boySelected >= 0)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
