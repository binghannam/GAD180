using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {

	public EventHandler Check;
	void Update ()
	{

		if(Check.WinnerisDeclared == true)
        {
			this.gameObject.SetActive(true);
        }
	
	}
}
