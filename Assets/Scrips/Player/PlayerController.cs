using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputManager inputMgr;
    private Transform player;

    [Header("걷기 속력"), SerializeField]
    private float walkSpeed;
    [Header("뛰기 속력"), SerializeField]
    private float runSpeed;


    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region 플레이어 움직임
    public void Move(Vector3 _inputDir, float _speed)
    {
        

    }

    public void Rotate()
    {

    }
    #endregion

    private void Init()
    {
        inputMgr = GameManager.Instance.InputMgr;
        player = transform;
    }
}
