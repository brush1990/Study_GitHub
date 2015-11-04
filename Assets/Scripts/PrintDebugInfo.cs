using UnityEngine;
using System.Collections;

public class PrintDebugInfo : MonoBehaviour 
{	
	void Awake() 
    {
        Debug.Log("Test Delete Recovery!");
	}
		
	void Start() 
    {
        GameObject go = new GameObject();
        go.name = "GameRoot";        
	}
}
