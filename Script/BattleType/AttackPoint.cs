/**
* @file AttackPoint.cs
* @brief オブジェクトの攻撃力を管理する機能
* @author Chronoss0518
* @date 2022/01/02
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief   オブジェクトの攻撃力を管理するのクラス
*/


namespace ChUnity.BattleType
{
    public class AttackPoint : MonoBehaviour
    {
        /**
         * このスクリプトを持つオブジェクトの攻撃力
        */
        protected int atk = 0;

        /**
         * このスクリプト全体の最大攻撃力と最低攻撃力
        */
        static protected int lATK = 0, hATK = 100;

        public int attackPoint { set { atk = (lATK > value ? lATK : (hATK < value ? hATK : value)); } get { return atk; } }

        public int lowAttackPoint { set { lATK = value < hATK ? value : hATK - 1; } get { return lATK; } }
        public int highAttackPoint { set { hATK = value > lATK ? value : lATK + 1; } get { return hATK; } }
        

    }

}
