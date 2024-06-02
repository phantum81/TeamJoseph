using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject _go = GameObject.Find("GameManager");
                if (_go == null)
                {
                    _instance = _go.AddComponent<GameManager>();

                }
                if (_instance == null)
                {
                    _instance = _go.GetComponent<GameManager>();
                }
            }
            return _instance;

        }
    }

    private InputManager inputMgr;
    public InputManager InputMgr
    {
        get
        {
            if (inputMgr == null)
            {
                GameObject _go = GameObject.Find("InputManager");
                if (_go == null)
                {
                    inputMgr = _go.AddComponent<InputManager>();

                }
                if (inputMgr == null)
                {
                    inputMgr = _go.GetComponent<InputManager>();
                }
            }
            return inputMgr;

        }
    }

    private UnitManager unitMgr;
    public UnitManager UnitMgr
    {
        get
        {
            if (unitMgr == null)
            {
                GameObject _go = GameObject.Find("UnitMgr");
                if (_go == null)
                {
                    unitMgr = _go.AddComponent<UnitManager>();

                }
                if (unitMgr == null)
                {
                    unitMgr = _go.GetComponent<UnitManager>();
                }
            }
            return unitMgr;

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
