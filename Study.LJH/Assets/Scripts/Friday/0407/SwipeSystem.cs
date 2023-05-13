using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    public Vector2 initialPos;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }

    void Calculate(Vector3 finalPos)
    {
        float disx = Mathf.Abs(initialPos.x - finalPos.x);
        float disy = Mathf.Abs(initialPos.y - finalPos.y);
        if(disx > disy)
        {
            if(initialPos.x > finalPos.x)
            {
                character.transform.position += new Vector3(-1f, 0, 0);
            }
            else
            {
                character.transform.position += new Vector3(1f, 0, 0);
            }
        }
        else
        {
            if(initialPos.y > finalPos.y)
            {
                character.transform.position += new Vector3(0f, 0f, -1f);
            }
            else
            {
                character.transform.position += new Vector3(0f, 0f, 1f);
            }
        }
    }
}
