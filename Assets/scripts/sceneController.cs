using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{

    [SerializeField]
    pickController tjejSelector;

    [SerializeField]
    pickController killSelector;

    public static string girlHair;
    public static int girlHairNumber;
    public static int girlSelected;

    public static string boyHair;
    public static int boyHairNumber;
    public static int boySelected;

    public void goToScene(int target)
    {
        if (tjejSelector != null)
        {
            girlHairNumber = tjejSelector.GetHairOfCurrentPerson();
            girlSelected = tjejSelector.currentSelection;
        }
        if (killSelector != null)
        {
            boyHairNumber = killSelector.GetHairOfCurrentPerson();
            boySelected = killSelector.currentSelection;
        }


        SceneManager.LoadScene(target);
    }
    public void goToStart(int target)
    {
        SceneManager.LoadScene(target);
    }

    void Start()
    {

    }
    void Update()
    {

    }
}
