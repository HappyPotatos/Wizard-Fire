using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch(transform.position.y) { 
            case >3:
                transform.position = new Vector3(transform.position.x, 3, transform.position.z);
                break;
            case < -3:
                transform.position = new Vector3(transform.position.x, -3, transform.position.z);
                break;
            default:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                break;
        }

        switch(transform.position.x) { 
            case > 7:
                transform.position = new Vector3(7, transform.position.y, transform.position.z);
                break;
            case < -7:
                transform.position = new Vector3(-7, transform.position.y, transform.position.z);
                break;
            default:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                break;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * 5);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * 5);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * 5);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * 5);
        }
    }
}
