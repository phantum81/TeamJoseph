using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("플레이어"),SerializeField]
    private Transform player;
    private InputManager inputMgr;
    private Rigidbody rigd;
    private Animator animator;
    public Animator Anim => animator;


    [Header("걷기 속력"), SerializeField]
    private float walkSpeed;
    public float WalkSpeed => walkSpeed;
    [Header("뛰기 속력"), SerializeField]
    private float runSpeed;
    public float RunSpeed => runSpeed;
    [Header("점프 힘"), SerializeField]
    private float jumpForce;
    public float JumpForce => jumpForce;
    



    private Vector3 inputDir;
    public Vector3 InputDir => inputDir;
    


    private void Awake()
    {
        Init();
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        inputDir = inputMgr.InputDir;
    }

    #region 플레이어 움직임
    public void Move(Vector3 _inputDir, float _speed)
    {
        //Vector3 move = _inputDir * _speed * Time.fixedDeltaTime;
        //Vector3 newPosition = rigd.position + move;

        //rigd.MovePosition(newPosition);

        float fallSpeed = rigd.velocity.y;
        if (_inputDir != Vector3.zero)
        {
            _inputDir *= _speed;
        }
        else
            _inputDir = Vector3.zero;

        _inputDir.y = fallSpeed; // 떨어지는 속도 초기화
        rigd.velocity = _inputDir;

    }


    public void Jump (float _jumpForce)
    {
        rigd.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

    }

    public void Rotate()
    {

    }
    #endregion



    private void Init()
    {
        inputMgr = GameManager.Instance.InputMgr;        
        rigd = player.GetComponent<Rigidbody>();
        animator = player.GetComponent<Animator>();
    }
}
