using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Detta scriptet hämtar och lagrar vilka kläder och hår som spelaren har valt 
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
        int.TryParse(hair.name[4].ToString(), out myHairNumber);
    }

}
