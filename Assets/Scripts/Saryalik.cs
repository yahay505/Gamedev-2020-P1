using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Saryalik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        yon = Random.Range(0, 2) == 1 ? Vector3.left : Vector3.right;
        TimeLeft = 1;
    }

    private float TimeLeft;
    private Vector3 yon;
    private void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft<0)
        {
            yon = Random.Range(0, 2) == 1 ? Vector3.left : Vector3.right;
            TimeLeft = 1;
        }

        GetComponent<Rigidbody2D>().velocity = yon;
    }
}
