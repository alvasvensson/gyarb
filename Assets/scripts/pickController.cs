using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detta script sköter vilken karaktär spelaren har valt och aktiverar en ram
// på den valda så användaren kan se vilken som är vald just nu
public class pickController : MonoBehaviour
{

    [SerializeField]
    GameObject[] panels;

    public int currentSelection = -1;

    public void SetSelected(int selection)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i != selection)
            {
                panels[i].SetActive(false);
            }
            else
            {
                panels[i].SetActive(true);
            }
            currentSelection = selection;
        }
    }

    public int GetHairOfCurrentPerson()
    {
        return panels[currentSelection].transform.parent.GetComponent<CharacterHandler>().myHairNumber;
    }
}
