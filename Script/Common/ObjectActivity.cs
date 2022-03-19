using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivity : GameObjectTargetSelector
{
    bool flg = false;
    public void SetActivity(bool _flg)
    {
        if (targetObject == null) return;
        flg = _flg;
        targetObject.SetActive(_flg);
    }

    public void SetActive()
    {
        if (targetObject == null) return;
        flg = true;
        targetObject.SetActive(true);
    }

    public void SetUnActive()
    {
        if (targetObject == null) return;
        flg = false;
        targetObject.SetActive(false);
    }

    public void ActiveFlgInverce()
    {
        if (targetObject == null) return;
        flg = !flg;
        targetObject.SetActive(flg);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (targetObject == null)
        {

            targetObject = gameObject;
        }

        flg = targetObject.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {
        Start();
    }
}
