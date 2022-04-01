/**
* @file RotateCursolEditor.cs
* @brief RotateCursol�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/03/29
* @details RotateCursol�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������RotateCursolEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(RotateCursol))]
    public class RotateCursolEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "��]����I�u�W�F�N�g";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override Object InspectorGUI()
        {
            return base.InspectorGUI();

        }
    }

}
