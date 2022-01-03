using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(LifePoint))]
public class LifePointEditor : CustomInspectorBase
{

    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();

        var obj = target as LifePoint;

        {

            int tmp = obj.maxLifePoint;
            Slider(ref tmp, obj.lowMaxLifePoint, obj.highMaxLifePoint, "Max Life Point");
            obj.maxLifePoint = tmp;
        }

        {

            int low = obj.lowMaxLifePoint, high = obj.highMaxLifePoint;
            Label("Set Max Life Point Range");
            BeginHorizontal();
            InputField(ref low, "Low:");
            EndHorizontal();

            BeginHorizontal();
            InputField(ref high, "High:");
            EndHorizontal();

            obj.lowMaxLifePoint = low;
            obj.highMaxLifePoint = high;
        }

    }
}
