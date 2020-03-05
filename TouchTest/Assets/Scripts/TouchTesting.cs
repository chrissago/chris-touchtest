using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SagoTouch;
using Touch = SagoTouch.Touch;

public class TouchTesting : MonoBehaviour, ISingleTouchObserver {


#region Touch methods

	public bool OnTouchBegan(Touch touch) {
		return false;
	}

	public void OnTouchMoved(Touch touch) {
	}

	public void OnTouchEnded(Touch touch) {		
	}

	public void OnTouchCancelled(Touch touch) {	
	}

#endregion


}
