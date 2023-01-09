using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowEyes : MonoBehaviour
{

    public float Force;
    [SerializeField] GameObject eye01;

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("throweo");
            Throw();
        }
        transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        /*
        FOLLOW THE CURSOR:
        transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        */

    }

    void Throw()
    {
        GameObject eyeThrown = Instantiate(eye01, transform);
        eyeThrown.GetComponent<Eye>().GetForce(Force);
    }
}
