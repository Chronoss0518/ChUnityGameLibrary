using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistGameObjectEvent : GameObjectTargetSelector
{
    
    public UnityEngine.Events.UnityEvent trueEvent = new UnityEngine.Events.UnityEvent();
    public UnityEngine.Events.UnityEvent falseEvent = new UnityEngine.Events.UnityEvent();

    public void RunEvent()
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
