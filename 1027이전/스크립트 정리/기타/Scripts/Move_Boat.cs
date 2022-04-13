using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Boat : MonoBehaviour
{
    //  Vector3 target = new Vector3(265, 100, -385);
    Vector3 target = new Vector3(-2670, 100, -400);
    public void setTarget() {
        target.x = 265;
         //target = new Vector3(265, 100, -385);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Vector3 velo = Vector3.zero;
        transform.position = Vector3.MoveTowards(transform.position, target, 5f);
        if (transform.position == target)
        {
            //Debug.Log(transform.position.x);
        }


    }


}