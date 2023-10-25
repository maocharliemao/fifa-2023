using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StateBases), true)]
public class StateBasesEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Turn on"))
        {
            
            // ‘target’ is the magic variable that editors use to link back to the original component. It’s in the BASE CLASS, so you have to ‘cast’ to get access to YOUR functions.
            StateBases stateBases;
            stateBases = target as StateBases;
            if(stateBases != null)
            {
                stateBases?.GetComponent<StateManager>().ChangeState(stateBases);
            }

        }
    }


}

 

