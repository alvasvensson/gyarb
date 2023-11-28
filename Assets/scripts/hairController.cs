using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detta script spawnar håren på ett slumpmässigt ställe
public class hairController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> people;

    [SerializeField]
    public List<GameObject> hairs;

    [SerializeField]
    GameObject[] hairPlacements;

    public GameObject myHair;

    public void Start()
    {
        foreach (GameObject person in people)
        {
            myHair = GetRandom(hairs);
            GameObject newHair = Instantiate(myHair, person.transform);
            person.GetComponent<CharacterHandler>().SetHair(newHair);
            hairs.Remove(myHair);
        }

    }
    public GameObject GetRandom(List<GameObject> listToRandomize)
    {
        int randomNum = Random.Range(0, listToRandomize.Count);
        GameObject assignedHair = listToRandomize[randomNum];
        return assignedHair;
    }


}
