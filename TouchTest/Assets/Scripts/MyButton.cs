﻿namespace TouchAreaExample {
	
    using SagoTouch;
    using UnityEngine;
    using Touch = SagoTouch.Touch;
    
	public class MyButton : MonoBehaviour {
	
	
		#region Fields
		
		[System.NonSerialized]
		private TouchArea m_TouchArea;
		
		[System.NonSerialized]
		private TouchAreaObserver m_TouchAreaObserver;
		
		#endregion
		
		
		#region Properties
		
		public TouchArea TouchArea {
			get { return m_TouchArea = m_TouchArea ?? GetComponent<TouchArea>(); }
		}
		
		public TouchAreaObserver TouchAreaObserver {
			get { return m_TouchAreaObserver = m_TouchAreaObserver ?? GetComponent<TouchAreaObserver>(); }
		}
		
		#endregion
		
		
		#region Methods
		
		private void OnEnable() {
			this.TouchAreaObserver.TouchUpDelegate = OnTouchUp;
		}
		
		private void OnDisable() {
			this.TouchAreaObserver.TouchUpDelegate = null;
		}
		
		public void OnTouchUp(TouchArea touchArea, Touch touch) {
			Debug.Log("Touch Up!", this);
		}
		
		#endregion
		
		
	}
	
	
}