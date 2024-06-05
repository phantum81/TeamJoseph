using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private HFSM<EPlayerState, PlayerController> MoveHFSM;
    private PlayerController playerCtr;
    private PlayerHealth playerHealth;
    
    private InputManager inputMgr;

    [Header("그라운드 체커"),SerializeField]
    private GroundCheck groundCheck;
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.Hp <= 0f)
            ChangePlayerState(EPlayerState.Die);



        if(MoveHFSM.CurState != EPlayerState.Die)
        {
            if (inputMgr.IsSpace && groundCheck.IsGround)
            {
                ChangePlayerState(EPlayerState.Jump);
            }
            else if (inputMgr.InputDir != Vector3.zero && groundCheck.IsGround)
            {
                if (inputMgr.IsClick)
                    ChangePlayerState(EPlayerState.Attack);
                else if (inputMgr.IsShift)
                    ChangePlayerState(EPlayerState.Run);
                else if (inputMgr.IsCtrl)
                    ChangePlayerState(EPlayerState.Sit);
                else
                    ChangePlayerState(EPlayerState.Walk);


            }
            else if (inputMgr.InputDir == Vector3.zero)
            {
                ChangePlayerState(EPlayerState.Idle);
                if (inputMgr.IsClick)
                    ChangePlayerState(EPlayerState.Attack);
            }


        }

        MoveHFSM.Update(playerCtr);
    }

    private void Init()
    {
        MoveHFSM = HFSM<EPlayerState, PlayerController>.Instance;
        playerCtr = transform.GetComponent<PlayerController>();
        playerHealth = transform.GetComponent<PlayerHealth>();
        inputMgr = GameManager.Instance.InputMgr;
        MoveHFSM.ChangeState(EPlayerState.Idle, playerCtr);

    }
    private void ChangePlayerState(EPlayerState _state)
    {
        MoveHFSM.ChangeState(_state, playerCtr);
        
    }
}
