using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack<T> : IState<T> where T : MonoBehaviour
{

    public void OperateEnter(T _player)
    {
        PlayerController _playerCtr = _player as PlayerController;
        if(_playerCtr != null)
        {
            _playerCtr.Anim.SetTrigger("Attack");
        }
    }

    public void OperateUpdate(T _player)
    {
        
    }

    public void OperateExit(T _player)
    {

    }
}
