using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicGame : MonoBehaviour, IObserver
{
    public Subject _playerSubject;
    public TextMeshProUGUI _pointPlayer;
    public TextMeshProUGUI _dieCountPlayer;

    public int pointAdd = 1;
    public int dieAdd = 1;

    private void Start()
    {
        _pointPlayer.text = "0";
        _dieCountPlayer.text = "0";
    }



    // Start is called before the first frame update
    public void OnNotify(Action actionLogic)
    {
        if(actionLogic == Action.A)
        {
            print("press A");
            obseverA();
        }

        if (actionLogic == Action.D)
        {
            print("press D");

            obseverD();
        }
    }

    public void OnEnable()
    {
        _playerSubject.AddObserver(this);
    }

    void obseverA()
    {
        int nowPoint = int.Parse(_pointPlayer.text);
        _pointPlayer.text = (nowPoint + pointAdd).ToString();
    }

    public void obseverD()
    {
        int nowPoint = int.Parse(_pointPlayer.text);
        _pointPlayer.text = (nowPoint - pointAdd).ToString();    

        int nowDie = int.Parse(_dieCountPlayer.text);
        _dieCountPlayer.text = (nowDie + dieAdd).ToString();
    }
}
