using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle<T> : IState<T> where T : MonoBehaviour
{

    public void OperateEnter(T _player)
    {
        PlayerController _playerCtr = _player as PlayerController;
        if (_playerCtr != null)
        {
            _playerCtr.Anim.SetFloat("MoveSpeed", 0f);
        }
    }

    public void OperateUpdate(T _player)
    {

    }

    public void OperateExit(T _player)
    {

    }
}
