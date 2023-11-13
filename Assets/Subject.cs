using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver _observer)
    {
        observers.Add(_observer);
    }

    public void RemoveObserver(IObserver _observer)
    {
        observers.Remove(_observer);
    }
    
    public void NotifyObsever(Action actionLogic)
    {
        foreach (IObserver _observer in observers)
        {
            _observer.OnNotify(actionLogic);
        }
    }
}
