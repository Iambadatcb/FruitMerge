using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    public Rigidbody2D rb;
    private GameObject spawner;
    
    void Start()
    {
        fruit = fruit.GetComponent<GameObject>();
        spawner = GetComponent<GameObject>();
        rb = rb.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //var x = Input.GetAxisRaw("MouseX");
        //var y = Input.GetAxisRaw("MouseY");
        var mousePos = Input.mousePosition;

        spawner.transform.position = new Vector3(Input.mousePosition.normalized.x*10,Input.mousePosition.normalized.y*10,Input.mousePosition.normalized.z*10);
        fruit.transform.position = spawner.transform.position;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {   
            rb.gravityScale = 1;
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);

        }
    }
    
}
