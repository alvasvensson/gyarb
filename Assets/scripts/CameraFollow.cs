using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detta script används inte i den slutliga versionen, men det användes för att kameran skulle följa spelaren. 

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform followTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);

    }
}
