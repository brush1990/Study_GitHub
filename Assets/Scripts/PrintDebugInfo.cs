using UnityEngine;
using System.Collections;

public class PrintDebugInfo : MonoBehaviour 
{	
	void Awake() 
    {
        Debug.Log("PrintDebugInfo is Runing!");
        Debug.Log("PrintDebugInfo Awake is Runing!");
	}
		
	void Start() 
    {
        GameObject go = new GameObject();
        go.name = "GameRoot";        
	}
}
