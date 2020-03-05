using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SagoTouch;
using Touch = SagoTouch.Touch;

public class TouchTesting : MonoBehaviour, ISingleTouchObserver {


#region Monobehavior methods

public void OnEnable() {
	if (TouchDispatcher.Instance == null) {
		return;
	}
	TouchDispatcher.Instance.Add(this, 0, true);
}

public void OnDisable() {
	if (TouchDispatcher.Instance == null) {
		return;
	}
	TouchDispatcher.Instance.Remove(this);
}

#endregion


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
