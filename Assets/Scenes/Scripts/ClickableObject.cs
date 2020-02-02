using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickableObject : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Target object that changes sprite")]
    GameObject targetObject = null;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (Input.GetMouseButtonDown(0)) {
            if (targetObject != null) {
                if (targetObject.TryGetComponent(out EventObject targetScrpit)) {
                    targetScrpit.ChangeSprite();
                    this.gameObject.SetActive(false);
                } else {
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                    UnityEditor.EditorUtility.DisplayDialog("Error", targetObject.name + " doesnt have EventObject scprit attached", "Ok");
#endif
                }
            }
        }
    }
}
