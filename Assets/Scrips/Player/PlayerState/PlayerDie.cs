using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie<T> : IState<T> where T : MonoBehaviour
{

    public void OperateEnter(T _player)
    {
        PlayerController _playerCtr = _player as PlayerController;
        if (_playerCtr != null)
        {
            _playerCtr.Anim.SetTrigger("Dead");
        }
    }

    public void OperateUpdate(T _player)
    {

    }

    public void OperateExit(T _player)
    {

    }
}
