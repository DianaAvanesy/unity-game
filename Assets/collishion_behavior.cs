using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collishion_behavior : MonoBehaviour
{
    // this will run when colision occurs with a trigder
    private void OnTriggerEnter(Collider other)
    {
        Vector3 scale = new Vector3(3, 3, 3);
        other.gameObject.transform.localScale = scale;
    }
}
