using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistGameObjectEvent : MonoBehaviour
{
    public GameObject targetObject = null;
    
    public UnityEngine.Events.UnityEvent trueEvent = new UnityEngine.Events.UnityEvent();
    public UnityEngine.Events.UnityEvent falseEvent = new UnityEngine.Events.UnityEvent();

    public void SetGameObject(GameObject _obj)
    {
        targetObject = _obj;
    }

    public void RunExistEvent()
    {
        if(targetObject != null)
        {
            trueEvent.Invoke();
        }else
        {
            falseEvent.Invoke();
        }
    }

}
