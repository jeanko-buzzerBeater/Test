using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Collor : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            rend.material.color = Color.grey;
        }

        if (Input.GetKey(KeyCode.R))
        {
            rend.material.color = Color.red;
        }
    }
}

