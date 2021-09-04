using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif // UNITY_EDITOR

public class HandlesDemo : MonoBehaviour
{
    public float Range = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(HandlesDemo))]
public class HandlesDemoEditor : Editor
{
    public void OnSceneGUI()
    {
        var linkedObject = target as HandlesDemo;

        Handles.color = Color.green;
        //Handles.DrawSolidDisc(linkedObject.transform.position, Vector3.up, linkedObject.Range);

        // run before drawing any user interactable handles to detect changes
        EditorGUI.BeginChangeCheck();

        // draw the handle for the range and store the potential new value
        float newRange = Handles.RadiusHandle(Quaternion.identity, linkedObject.transform.position, linkedObject.Range, false);

        // if the value was changed then update it and register with the undo system
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(target, "Update range");
            linkedObject.Range = newRange;
        }
    }
}
#endif // UNITY_EDITOR
