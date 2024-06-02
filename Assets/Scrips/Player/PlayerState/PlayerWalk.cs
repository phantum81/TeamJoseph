using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk<T> : IState<T> where T : MonoBehaviour
{

    public void OperateEnter(T _player)
    {

    }

    public void OperateUpdate(T _player)
    {
        PlayerController _playerCtr = _player as PlayerController;
        if (_playerCtr != null)
        {
            _playerCtr.Move(_playerCtr.InputDir, _playerCtr.WalkSpeed);
            if(_playerCtr.InputDir.z >0f || _playerCtr.InputDir.x != 0f)
            {
                _playerCtr.Anim.SetFloat("MoveSpeed", 1f);
            }
            else
                _playerCtr.Anim.SetFloat("MoveSpeed", -1f);


            _playerCtr.Rotate();
        }
    }

    public void OperateExit(T _player)
    {

    }
}
