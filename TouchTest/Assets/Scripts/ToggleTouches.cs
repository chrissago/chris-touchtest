namespace TestingTouches {

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using SagoTouch;

	public class ToggleTouches : MonoBehaviour {


		#region Fields

		[System.NonSerialized]
		private bool m_TouchesEnabled = true;

		#endregion


		#region Methods
		public void OnTap() {
			if (TouchDispatcher.Instance == null)		
			{
				return;
			}
			m_TouchesEnabled = !m_TouchesEnabled;
			TouchDispatcher.Instance.enabled = m_TouchesEnabled;
			Debug.Log("Touch dispatcher enabled " + TouchDispatcher.Instance.enabled);
		}

		#endregion


	}

}