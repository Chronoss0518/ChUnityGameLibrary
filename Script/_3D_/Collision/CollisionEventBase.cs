using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollisionType
{
    CollisionEnter,
    CollisionStay,
    CollisionExit,
    TriggerEnter,
    TriggerStay,
    TriggerExit
}

public abstract class CollisionEventBase : MonoBehaviour
{
    public CollisionType type = CollisionType.CollisionEnter;

    public UnityEngine.Events.UnityEvent action = new UnityEngine.Events.UnityEvent();

    abstract protected bool IsTargetObject(GameObject _obj);

    void EventUpdate(GameObject _obj)
    {
        if (!IsTargetObject(_obj)) return;
        action.Invoke();
    }

    protected void CollisionEnter(Collision collision)
    {
        if (type != CollisionType.CollisionEnter) return;
        EventUpdate(collision.gameObject);
    }

    protected void CollisionStay(Collision collision)
    {
        if (type != CollisionType.CollisionStay) return;
        EventUpdate(collision.gameObject);
    }

    protected void CollisionExit(Collision collision)
    {
        if (type != CollisionType.CollisionExit) return;
        EventUpdate(collision.gameObject);
    }

    protected void TriggerEnter(Collider collision)
    {
        if (type != CollisionType.TriggerEnter) return;
        EventUpdate(collision.gameObject);
    }

    protected void TriggerStay(Collider collision)
    {
        if (type != CollisionType.TriggerStay) return;
        EventUpdate(collision.gameObject);
    }

    protected void TriggerExit(Collider collision)
    {
        if (type != CollisionType.TriggerExit) return;
        EventUpdate(collision.gameObject);
    }
}
