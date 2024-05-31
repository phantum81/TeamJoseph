using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private HFSM<EPlayerState, PlayerController> MoveHFSM;
    private PlayerController playerCtr;
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        MoveHFSM = HFSM<EPlayerState, PlayerController>.Instance;


        MoveHFSM.ChangeState(EPlayerState.None, playerCtr);
    }
    private void ChangePlayerState(EPlayerState _state)
    {
        MoveHFSM.ChangeState(_state, playerCtr);
        
    }
}
