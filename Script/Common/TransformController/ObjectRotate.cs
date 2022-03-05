using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public float rotSize = 0.0f;

    public GameObject moveTarget = null;

    private Quaternion rot = Quaternion.identity;

    public void AddRotSize(float _rot) { rotSize += _rot; }

    public void SubRotSize(float _rot) { rotSize -= _rot; }

    public void MulRotSize(float _rot) { rotSize *= _rot; }

    public void DivRotSize(float _rot) { rotSize /= _rot != 0.0f ? _rot : 1.0f; }

    public void SetRotSize(float _rot) { rotSize = _rot; }

    public float GetRotSize() { return rotSize; }

    public void RotAxisZ()
    {
        rot = Quaternion.Euler(0.0f, 0.0f, rotSize) * rot;
    }

    public void RotAxisZInverse()
    {
        rot = Quaternion.Euler(0.0f, 0.0f, -rotSize) * rot;
    }

    public void RotAxisX()
    {
        rot = Quaternion.Euler(rotSize,0.0f, 0.0f) * rot;
    }

    public void RotAxisXInverse()
    {
        rot = Quaternion.Euler(-rotSize, 0.0f, 0.0f) * rot;
    }

    public void RotAxisY()
    {
        rot = Quaternion.Euler(0.0f, rotSize, 0.0f) * rot;
    }

    public void RotAxisYInverse()
    {
        rot = Quaternion.Euler(0.0f, -rotSize, 0.0f) * rot;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (moveTarget != null) return;
        moveTarget = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Start();

        if (moveTarget != null)
        {

            Rigidbody body = moveTarget.GetComponent<Rigidbody>();

            if (body != null) body.MoveRotation(rot);
            else moveTarget.transform.rotation = rot * moveTarget.transform.rotation;

        }

        rot = Quaternion.identity;

    }
}
