using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    //��O�ɏo���I�u�W�F�N�g������
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Candy")
        {
            Destroy(other.gameObject);

        }  
    }
}
