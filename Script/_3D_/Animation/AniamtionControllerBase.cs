using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity._3D_
{
    public class AnimationControllerBase : MonoBehaviour
    {
        public Animator animator = null;
        public string motionTimeValueName = "";

        public void SetNowAnimationNormalizeTime(float _normalizeTime)
        {
            if (string.IsNullOrWhiteSpace(motionTimeValueName)) return;
            animator.SetFloat(motionTimeValueName, _normalizeTime);
        }

        private void UpdateMotionTime()
        {

            if (string.IsNullOrWhiteSpace(motionTimeValueName)) return;
            var info = animator.GetCurrentAnimatorStateInfo(0);

            var time = animator.GetFloat(motionTimeValueName);

            time = info.normalizedTime;

            animator.SetFloat(motionTimeValueName, time);
        }

        public bool IsPlayAnimation()
        {
            var info = animator.GetCurrentAnimatorStateInfo(0);

            return info.normalizedTime >= 1.0f;
        }

        public void AnimationStop()
        {
            animator.enabled = false;
        }

        public void AnimationStart()
        {
            animator.enabled = true;
        }

        public void AnimationPlay(int _stateNo)
        {
            animator.Play(_stateNo);
        }

        public void AnimationPlay(string _stateName)
        {
            animator.Play(_stateName);
        }

        protected bool IsInit()
        {
            return animator != null;
        }

        public void SetBool(string _controlName,bool _flg)
        {
            if (string.IsNullOrWhiteSpace(_controlName)) return;
            if (!IsInit()) return;
            animator.SetBool(_controlName, _flg);
        }

        public void SetInteger(string _controlName, int _num)
        {
            if (string.IsNullOrWhiteSpace(_controlName)) return;
            if (!IsInit()) return;
            animator.SetInteger(_controlName, _num);
        }

        public void SetFloat(string _controlName, float _num)
        {
            if (string.IsNullOrWhiteSpace(_controlName)) return;
            if (!IsInit()) return;
            animator.SetFloat(_controlName, _num);
        }

        public void SetTrigger(string _controlName)
        {
            if (string.IsNullOrWhiteSpace(_controlName)) return;
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

            UpdateMotionTime();

            return;

        }
    }

}
