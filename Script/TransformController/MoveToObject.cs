using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity.Transform
{

    public class MoveToObject : Common.GameObjectTargetSelector
    {
        public float moveSpeed = 0.0f;

        public bool xAxis = true;
        public bool yAxis = true;
        public bool zAxis = true;

        // Update is called once per frame
        void Update()
        {
            if (target == null) return;

            Vector3 dir = target.transform.position - transform.position;

            dir.x = xAxis ? dir.x : 0.0f;
            dir.y = yAxis ? dir.y : 0.0f;
            dir.z = zAxis ? dir.z : 0.0f;

            dir.Normalize();

            var rd = GetComponent<Rigidbody>();

            if (rd != null) rd.MovePosition(transform.position + (dir * moveSpeed));
            else transform.position += (dir * moveSpeed);
        }
    }

}