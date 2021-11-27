using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void Update()
    {
       if(transform.position.y <1f)
        {
            Destroy(gameObject);
        }
    }
}
