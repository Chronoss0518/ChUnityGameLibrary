/**
* @file ObjectMoveEditor.cs
* @brief ObjectMove�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/03/29
* @details ObjectMove�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������ObjectMoveEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(ObjectMove))]
    public class ObjectMoveEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "�ړ�����I�u�W�F�N�g";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as ObjectMove;

            obj.len  = InputField(obj.len,"�ړ����x");

            obj.normalizeFlg = IsTrueToggle(obj.normalizeFlg, "�ړ�����ۂɐ��K��(�x�N�g���̒�����1�ɂ��邱��)���s�����̃t���O");

            obj.moveDirFlg = IsTrueToggle(obj.moveDirFlg, "�ړ�����ۂɌ��݌����Ă�����������Ɉړ������邩�̃t���O");

            Label("�ړ���");

            obj.autoMoveDir = InputField(obj.autoMoveDir,"�����ňړ��������(�傫���͎��s����1�ɂȂ�܂��B)");

            return obj;

        }
    }

}
