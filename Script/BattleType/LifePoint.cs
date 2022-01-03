using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePoint : MonoBehaviour
{
    protected int lp = 0;

    protected int maxLP = 0;

    protected int lMaxLP = 0,hMaxLP = 100;

    public int maxLifePoint { set { maxLP = value; } get { return maxLP; } }
    public int lowMaxLifePoint { set { lMaxLP = value < hMaxLP ? value : hMaxLP - 1; } get { return lMaxLP; } }
    public int highMaxLifePoint { set { hMaxLP = value > lMaxLP ? value : lMaxLP + 1; } get { return hMaxLP; } }

    public int lifePoint { set { lp = value; } get { return lp; } }

    public void Heal(int _heal)
    {
        lp += _heal;
        lp = lp > maxLP ? maxLP : lp;
    }

    public void Damage(int _damage)
    {
        lp -= _damage;
        lp = lp < 0 ? 0: lp;
    }
    public bool IsDeath()
    {
        return (lp <= 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
