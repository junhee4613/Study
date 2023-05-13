using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public float rotSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10000;
        }
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0);

        rotSpeed *= 0.98f;
    }
}
