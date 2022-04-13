using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{public bool state;

    // Use this for initialization
   

    // Update is called once per frame
    public  void setactive () {
        gameObject.SetActive(false);
    }


}
