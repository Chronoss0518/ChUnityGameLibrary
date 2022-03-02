/**
* @file AttackPoint.cs
* @brief �I�u�W�F�N�g�̍U���͂��Ǘ�����@�\
* @author Chronoss0518
* @date 2022/01/02
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief   �I�u�W�F�N�g�̍U���͂��Ǘ�����̃N���X
*/


namespace ChUnity.BattleType
{
    public class AttackPoint : MonoBehaviour
    {
        /**
         * ���̃X�N���v�g�����I�u�W�F�N�g�̍U����
        */
        protected int atk = 0;

        /**
         * ���̃X�N���v�g�S�̂̍ő�U���͂ƍŒ�U����
        */
        static protected int lATK = 0, hATK = 100;

        public int attackPoint { set { atk = (lATK > value ? lATK : (hATK < value ? hATK : value)); } get { return atk; } }

        public int lowAttackPoint { set { lATK = value < hATK ? value : hATK - 1; } get { return lATK; } }
        public int highAttackPoint { set { hATK = value > lATK ? value : lATK + 1; } get { return hATK; } }
        

    }

}
