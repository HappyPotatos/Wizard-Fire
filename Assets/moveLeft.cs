using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
