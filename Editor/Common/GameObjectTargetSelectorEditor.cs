/**
* @file GameObjectTargetSelectorEditor.cs
* @brief GameObjectTargetSelector�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/01/02
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

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();

            var obj = target as GameObjectTargetSelector;

            var go = SerializeObjectToObject("targetObject");

            Label(go.name);

            InputField<GameObject>(ref go, "����Ώۂ̃I�u�W�F�N�g");

            ObjectToSerializeObject("targetObject",go);

        }
    }

}
