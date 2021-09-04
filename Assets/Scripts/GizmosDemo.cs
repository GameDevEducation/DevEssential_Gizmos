using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif // UNITY_EDITOR

public class GizmosDemo : MonoBehaviour
{
    [SerializeField] float EffectRadius = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        var sceneCamera = Application.isPlaying ? Camera.main : SceneView.currentDrawingSceneView.camera;

        if (Vector3.Distance(sceneCamera.transform.position, transform.position) > 50f)
            return;

        //Gizmos.color = Color.magenta;
        //Gizmos.DrawWireSphere(transform.position, EffectRadius);
        Gizmos.color = new Color(1f, 0f, 1f, 0.5f);
        Gizmos.DrawSphere(transform.position, EffectRadius);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 1, 1));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 1, -1));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 1, -1));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 1, 1));
    }
#endif // UNITY_EDITOR
}
