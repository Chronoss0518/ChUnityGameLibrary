using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCursol : GameObjectTargetSelector
{

    public float moveSize = 0.0f;

    Vector3 nowPos;

    // Start is called before the first frame update
    void Start()
    {
        if (targetObject != null) return;

        targetObject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Start();

        var pos = Input.mousePosition;
        
        if (target != null)
        {

            var rotSize = pos - nowPos;

            rotSize *= moveSize;

            var rot = Quaternion.Euler(-rotSize.y, rotSize.x, 0.0f);

            Rigidbody body = target.GetComponent<Rigidbody>();

            if (body != null) body.MoveRotation(rot * target.transform.rotation);
            else target.transform.rotation = rot * target.transform.rotation;


        }

        nowPos = pos;

    }
}
