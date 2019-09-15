using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanJump : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bean;
    void Start()
    {
        bean = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bean.position.y < 0.2) {
            bean.AddForce(0, 30 * Random.Range(1,2), 0);
        }
        
    }
}
