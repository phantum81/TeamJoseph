using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector3 inputDir;
    public Vector3 InputDir => inputDir;

    bool isShift = false;
    public bool IsShift => isShift;

    bool isCtrl = false;
    public bool IsCtrl => isCtrl;

    bool isSpace = false;
    public bool IsSpace => isSpace;

    bool isClick = false;
    public bool IsClick => isClick;



    // Update is called once per frame
    void Update()
    {
        GetInputDir();
        CheckKey();
    }

    private void GetInputDir()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(x, 0, z).normalized;
        inputDir = dir;

    }

    private void CheckKey()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            isShift= true;
        else
            isShift= false;

        if(Input.GetKey(KeyCode.LeftControl))
            isCtrl= true;
        else
            isCtrl= false;
        if(Input.GetKeyDown(KeyCode.Space))
            isSpace= true;
        else
            isSpace= false;
        if (Input.GetMouseButtonDown(0))
            isClick= true;
        else
            isClick= false;

    }
}
