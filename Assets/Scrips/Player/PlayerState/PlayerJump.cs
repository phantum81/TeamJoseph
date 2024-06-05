using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump<T> : IState<T> where T : MonoBehaviour
{

    public void OperateEnter(T _player)
    {

    }

    public void OperateUpdate(T _player)
    {
        PlayerController _playerCtr = _player as PlayerController;
        if (_playerCtr != null)
        {
            _playerCtr.Jump(_playerCtr.JumpForce);
        }
    }

    public void OperateExit(T _player)
    {

    }
}
