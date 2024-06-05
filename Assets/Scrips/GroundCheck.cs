using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    private int groundLayer = 1 << 3;
    private bool isGround = false;
    public bool IsGround => isGround;


    
    void Update()
    {
        isGround = CheckIsGrounded();
    }

    private bool CheckIsGrounded()
    {
        Vector3 boxSize = new Vector3(transform.lossyScale.x, 0.2f, transform.lossyScale.z);
        return Physics.CheckBox(transform.position, boxSize, Quaternion.identity, groundLayer);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 boxSize = new Vector3(transform.lossyScale.x, 0.2f, transform.lossyScale.z);
        Gizmos.DrawWireCube(transform.position, boxSize);
    }

}
