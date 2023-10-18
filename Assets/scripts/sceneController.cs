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
    public static int girlSelected;

    public static string boyHair;
    public static int boySelected;

    public void goToScene(int target)
    {
        girlHair = tjejSelector.GetHairOfCurrentPerson();
        girlSelected = tjejSelector.currentSelection;
        boyHair = killSelector.GetHairOfCurrentPerson();
        boySelected = killSelector.currentSelection;

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
