using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public string GetHairOfCurrentPerson()
    {
        return panels[currentSelection].transform.parent.GetComponent<CharacterHandler>().myHairName;
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
