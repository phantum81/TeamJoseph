using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector3 inputDir;
    public Vector3 InputDir => inputDir;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInputDir();
    }

    private void GetInputDir()
    {

        float x = 0f;
        float z = 0f;

        x = (Input.GetKey(KeyCode.LeftArrow) ? 1f : 0f) - (Input.GetKey(KeyCode.RightArrow) ? 1f : 0f);
        z = (Input.GetKey(KeyCode.UpArrow) ? 1f : 0f) - (Input.GetKey(KeyCode.DownArrow) ? 1f : 0f);

        inputDir = new Vector3(x, 0, z);

    }
}
