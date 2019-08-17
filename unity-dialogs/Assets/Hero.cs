using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wbx.Dialogs;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    Talker t;
    void Start()
    {
        t = GetComponent<Talker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            t.Say("OUCH!");
        }
    }
}
