using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    //場外に出たオブジェクトを消す
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Candy")
        {
            Destroy(other.gameObject);

        }  
    }
}
