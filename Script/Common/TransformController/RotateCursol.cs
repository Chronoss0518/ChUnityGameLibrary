using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCursol : MonoBehaviour
{

    public float moveSize = 0.0f;

    public GameObject targetObject = null;

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
        
        if (targetObject != null)
        {

            var rotSize = pos - nowPos;

            rotSize *= moveSize;

            var rot = Quaternion.Euler(rotSize.y, rotSize.x, 0.0f);

            Rigidbody body = targetObject.GetComponent<Rigidbody>();

            if (body != null) body.MoveRotation(rot);
            else targetObject.transform.rotation = rot * targetObject.transform.rotation;


        }

        nowPos = pos;

    }
}
