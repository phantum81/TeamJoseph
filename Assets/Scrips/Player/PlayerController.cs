using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("�÷��̾�"),SerializeField]
    private Transform player;
    private InputManager inputMgr;
    private Rigidbody rigd;
    private Animator animator;
    public Animator Anim => animator;


    [Header("�ȱ� �ӷ�"), SerializeField]
    private float walkSpeed;
    public float WalkSpeed => walkSpeed;
    [Header("�ٱ� �ӷ�"), SerializeField]
    private float runSpeed;
    public float RunSpeed => runSpeed;
    [Header("���� ��"), SerializeField]
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

    #region �÷��̾� ������
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

        _inputDir.y = fallSpeed; // �������� �ӵ� �ʱ�ȭ
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
