using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenBlock : MonoBehaviour
{

    void Update()
    {

        if (transform.position.x <= -10.0f)
        {
            transform.position = new Vector4(-10.0f, transform.position.y);
        }
        else if (transform.position.x >= 10.0f)
        {
            transform.position = new Vector4(10.0f, transform.position.y);
        }

    }
}
