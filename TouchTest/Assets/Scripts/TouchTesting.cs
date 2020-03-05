using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SagoTouch;
using Touch = SagoTouch.Touch;

public class TouchTesting : MonoBehaviour, ISingleTouchObserver {


#region Fields

[SerializeField]
private Camera m_Camera;

[System.NonSerialized]
private Renderer m_Renderer;

[System.NonSerialized]
private Transform m_Transform;

[System.NonSerialized]
private List<Touch> m_Touches = new List<Touch>();


#endregion


#region Properties

/*
// why does this not work?
public Camera Camera {
	get { return m_Camera = m_Camera ?? CameraUtils.FindRootCamera(this.Transform); }
}
*/

public Camera Camera {
	get { 
		if (m_Camera == null) {
			m_Camera = CameraUtils.FindRootCamera(this.Transform);
		}
		return m_Camera;
	}
}

public Renderer Renderer {
	get { return m_Renderer = m_Renderer ?? GetComponent<Renderer>(); }
}

public Transform Transform {
	get { return m_Transform = m_Transform ?? GetComponent<Transform>(); }
}

#endregion


#region Methods

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
	
	private bool HitTest(Touch touch) {		
		var bounds = this.Renderer.bounds;
		bounds.extents += Vector3.forward;
		return bounds.Contains(CameraUtils.TouchToWorldPoint(touch, this.Transform, this.Camera));
	}

#endregion


#region ISingleTouchObserver

	public bool OnTouchBegan(Touch touch) {
		if (!HitTest(touch))
		{
			return false;
		}
		m_Touches.Add(touch);
		Debug.Log("Touch began. Num touches now " + m_Touches.Count);
		return true;
	}

	public void OnTouchMoved(Touch touch) {		
	}

	public void OnTouchEnded(Touch touch) {		
		Debug.Log("Touch ended");
		m_Touches.Remove(touch);
	}

	public void OnTouchCancelled(Touch touch) {	
		OnTouchEnded(touch);
	}

#endregion


}
