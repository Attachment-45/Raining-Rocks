using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;

    public float horizontal;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
       void movement()
       {
            float horizontal = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right *horizontal* _speed * Time.deltaTime);

        if (transform.position.x >= 5)
        {
            transform.position = new Vector3(-4.9f, transform.position.y, 0);
        }
          else if (transform.position.x <= -5)
        {  
          transform.position = new Vector3(4.9f, transform.position.y, 0);
        }
       }
        
        
    
}
