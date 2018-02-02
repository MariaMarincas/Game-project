﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_stack_game : MonoBehaviour {

    void Start()
    {

    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            Application.LoadLevel("Stack_Game");
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Construction")
                {
                    Application.LoadLevel("Stack_Game");
                }
            }
        }


    }
}
