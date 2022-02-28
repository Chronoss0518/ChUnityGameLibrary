using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity._3D_
{
    public class AnimationControllerBase : MonoBehaviour
    {
        private Animator animator = null;

        public bool IsPlayAnimation()
        {
            var info = animator.GetCurrentAnimatorStateInfo(0);

            return info.normalizedTime >= 1.0f;
        }

        protected bool IsInit()
        {
            return animator != null;
        }

        public void SetBool(string _controlName,bool _flg)
        {
            if (!IsInit()) return;
            animator.SetBool(_controlName, _flg);
        }

        public void SetInteger(string _controlName, int _num)
        {
            if (!IsInit()) return;
            animator.SetInteger(_controlName, _num);
        }

        public void SetFloat(string _controlName, float _num)
        {
            if (!IsInit()) return;
            animator.SetFloat(_controlName, _num);
        }

        public void SetTrigger(string _controlName)
        {
            if (!IsInit()) return;
            animator.SetTrigger(_controlName);
        }

        // Start is called before the first frame update
        protected virtual void Start()
        {
            if (animator != null) return;
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            Start();
        }
    }

}
