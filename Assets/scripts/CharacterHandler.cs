using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHandler : MonoBehaviour
{
    public Transform hairPosition;
    public string myHairName;


    private void Awake()
    {
        hairPosition = transform.Find("HairPosition");
    }

    public void SetHair(GameObject hair)
    {
        hair.transform.position = hairPosition.position;
        myHairName = hair.name;
    }

}
