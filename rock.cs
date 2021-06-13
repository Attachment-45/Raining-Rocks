using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{   
   [SerializeField]
  private GameObject gameObject;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 2.3f * Time.deltaTime);

        if (transform.position.y <= -3.25f) 
        {
            Destroy(gameObject);
        }

    }
}
