using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SagoTouch;
using Touch = SagoTouch.Touch;

public class TouchTesting : MonoBehaviour, ISingleTouchObserver {


#region Fields

private Touch m_Current;
private Vector2 m_CurrentLastPos;

#endregion

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
		if (m_Current == null)
		{
			Debug.Log("Touch Began");
			m_Current = touch;
			m_CurrentLastPos = m_Current.Position;
			return true;
		}
		return false;
	}

	public void OnTouchMoved(Touch touch) {
		if (touch == m_Current && touch.Position != m_CurrentLastPos)
		{
			Debug.Log(touch.Position - m_CurrentLastPos);
			m_CurrentLastPos = m_Current.Position;
		}
	}

	public void OnTouchEnded(Touch touch) {		
		Debug.Log("Touch ended");
		if (touch == m_Current)
		{
			m_Current = null;
		}
	}

	public void OnTouchCancelled(Touch touch) {	
		Debug.Log("Touch cancelled");
		if (touch == m_Current)
		{
			m_Current = null;
		}
	}

#endregion


}
