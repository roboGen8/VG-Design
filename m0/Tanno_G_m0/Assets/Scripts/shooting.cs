﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward;
        }
    }
}
