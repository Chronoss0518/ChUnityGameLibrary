﻿/**
* @file LifePoint.cs
* @brief オブジェクトの体力を管理する機能
* @author Chronoss0518
* @date 2022/01/02
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief   オブジェクトの体力を管理するのクラス
*/

namespace ChUnity.BattleType
{
    public class LifePoint : MonoBehaviour
    {
        /**
         * このスクリプトを持つオブジェクトの体力
        */
        protected int lp = 0;

        /**
         * このスクリプトを持つオブジェクトの最大体力
        */
        protected int maxLP = 0;

        /**
         * このスクリプト全体の最大体力と最低体力
        */
        static protected int lMaxLP = 0, hMaxLP = 100;

        public int maxLifePoint { set { maxLP = value; } get { return maxLP; } }
        public int lowMaxLifePoint { set { lMaxLP = value < hMaxLP ? value : hMaxLP - 1; } get { return lMaxLP; } }
        public int highMaxLifePoint { set { hMaxLP = value > lMaxLP ? value : lMaxLP + 1; } get { return hMaxLP; } }

        /**
       * @fn public void SetLP(int _lp)
       * @brief 体力を固定値にする。(最大体力は超えない)
       */
        public void SetLP(int _lp)
        {
            lp = _lp >= maxLP ? maxLP : _lp;
        }

        /**
       * @fn public void Heal(int _heal)
       * @brief 体力を回復する。(最大体力は超えない)
       */
        public void Heal(int _heal)
        {
            lp += _heal;
            lp = lp > maxLP ? maxLP : lp;
        }

        /**
       * @fn public void Damage(int _damage)
       * @brief 体力を傷つける。(0以下にならない)
       */
        public void Damage(int _damage)
        {
            lp -= _damage;
            lp = lp < 0 ? 0 : lp;
        }

        /**
       * @fn public bool IsDeath()
       * @brief 体力が切れたかどうかを確認する。
       */
        public bool IsDeath()
        {
            return (lp <= 0);
        }

    }
}

