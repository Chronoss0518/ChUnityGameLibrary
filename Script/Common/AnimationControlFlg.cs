using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlFlg : MonoBehaviour
{
    private bool flg = false;

    private Animator animator = null;

    public string flgName = "";

    public void SetFlg(bool _flg)
    {
        flg = _flg;
    }

    public void SetTrue() { flg = true; }

    public void SetFalse() { flg = false; }

    // Start is called before the first frame update
    void Start()
    {
        if (animator != null) return;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Start();
        if (animator == null) return;

        animator.SetBool(flgName, flg);

    }
}
