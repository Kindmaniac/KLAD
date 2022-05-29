using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cMalteMover : MonoBehaviour
{
    public float strength = 1000;
    public bool isPressed = false;
    //public GameObject target;

    Rigidbody rb;
    public Vector3 lineStart;
    public Vector3 lineEnd;
    public Vector3 force;
    public float forceMulti = 10000;
    public Vector3 lineOffset;
    public Vector3 reduceDirections = new Vector3(1, 1, 1);
    LineRenderer line;

    void Start()
    {
        //rb = target.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        line = GetComponent<LineRenderer>();
        line.positionCount = 2;

        line.startWidth = 0.5f;
        line.endWidth = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = target.transform.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * strength/10);
        }


        if (isPressed)
        {
            // Vector2 tempCoord = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // lineEnd = new Vector3(tempCoord.x, -6f, tempCoord.y);
            lineEnd = GetHit();
            line.SetPosition(0, lineStart + lineOffset);
            line.SetPosition(1, lineEnd + lineOffset);
        }

        else
        {
            line.SetPosition(0, Vector3.right * 10000);
            line.SetPosition(1, Vector3.right * 10000);
        }

    }


    private void OnMouseDown()
    {
        isPressed = true;

        //Vector2 tempCoord = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //lineStart = new Vector3(tempCoord.x, -6f, tempCoord.y);
        lineStart = GetHit();
    }

    private void OnMouseUp()
    {
        force =  lineEnd - lineStart;
        rb.AddForce(forceMulti * VectorMult(reduceDirections, force));
        //rb.AddForce(forceMulti * force);
        isPressed = false;


    }

    private Vector3 GetHit()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);

        
            
            return hit.point; ;
        

    }



    private static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    Vector3 VectorMult(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
    }

}
