using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterHandler : MonoBehaviour
{
    public Transform hairPosition;
    public string myHairName;
    public int myHairNumber;


    private void Awake()
    {
        hairPosition = transform.Find("HairPosition");
    }

    public void SetHair(GameObject hair)
    {
        hair.transform.position = hairPosition.position;
        myHairName = hair.name;
        // print(hair.name);
        int.TryParse(hair.name[4].ToString(), out myHairNumber);
    }

}
