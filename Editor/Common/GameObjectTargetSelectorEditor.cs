/**
* @file GameObjectTargetSelectorEditor.cs
* @brief GameObjectTargetSelector�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/03/29
* @details GameObjectTargetSelector�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   Custom InspectorBase���p������LifePoint��CustomInspector
*/

namespace ChUnity.Common
{


    [CustomEditor(typeof(GameObjectTargetSelector))]
    public class GameObjectTargetSelectorEditor : CustomInspectorBase
    {

        protected string targetObjectDescription = "����Ώۂ̃I�u�W�F�N�g";

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override Object InspectorGUI()
        {

            var obj = target as GameObjectTargetSelector;

            obj.target = (GameObject)InputField<GameObject>(obj.target, targetObjectDescription);

            return obj;
        }
    }

}
