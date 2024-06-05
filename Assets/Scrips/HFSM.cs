using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class HFSM<TState, T> where TState : System.Enum where T : MonoBehaviour
{
    private static HFSM<TState, T> instance;
    public static HFSM<TState, T> Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new HFSM<TState, T>();
            }
            return instance;
        }
    }

    private TState curState;
    public TState CurState => curState;
    private Dictionary<TState, IState<T>> stateDic;

    private HFSM()
    {
        curState = default(TState);
        stateDic= new Dictionary<TState, IState<T>>();
        Init();
        

    }

    public void Init()
    {
        foreach(TState state in Enum.GetValues(typeof(TState)))
        {
            stateDic[state] = CreateStateInstance(state);
        }
    }
    private IState<T> CreateStateInstance(TState _state)
    {
        switch(_state)
        {
            case EPlayerState.None:
                return new PlayerNone<T>();
            case EPlayerState.Idle:
                 return new PlayerIdle<T>();
            case EPlayerState.Walk:
                return new PlayerWalk<T>();
            case EPlayerState.Run:
                return new PlayerRun<T>();
            case EPlayerState.Jump:
                return new PlayerJump<T>();
            case EPlayerState.Sit:
                return new PlayerSit<T>();
            case EPlayerState.Attack:
                return new PlayerAttack<T>();
            case EPlayerState.Hitted:
                return new PlayerHitted<T>();
            case EPlayerState.Die:
                return new PlayerDie<T>();

            default:
            return null;
        }
    }


    public void ChangeState(TState _newState, T _obj)
    {
        if (EqualityComparer<TState>.Default.Equals(curState, _newState))
            return;
            
        ExitState(curState, _obj);        
        curState = _newState;
        EnterState(curState, _obj);
    }

    private void EnterState(TState _state, T _obj)
    {
        stateDic[_state].OperateEnter(_obj);
    }
    private void ExitState(TState _state, T _obj)
    {
        stateDic[_state].OperateExit(_obj);
    }

    public void Update(T _obj)
    {
        stateDic[curState].OperateUpdate(_obj);
    }

}
