using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject[] fruits;
    private static int fruitCount;
    
    // Start is called before the first frame update
    void Start()
    {
        fruitCount = fruits.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        var mousePos = Input.mousePosition;
        Debug.Log(mousePos.x);
        Debug.Log(mousePos.y);
        //for (int i = 0; i < fruits.Length; i++)
        //{
        //    if (fruits[] == fruits[i])

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            
        }
        else if (collision.gameObject.CompareTag("Fruit"))
        {
            Destroy(collision.gameObject);
            collision.gameObject.transform.position = Vector3.zero;
        }
        
    }
}
