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


		#region Monobehavior Methods

		public void Start()
		{
			#if !ENABLE_BUTTONS
			this.gameObject.SetActive(false);
			#endif
		}

		#endregion
		

		#region Methods
		public void OnTap() {
			#if ENABLE_BUTTONS
			if (TouchDispatcher.Instance == null)		
			{
				return;
			}
			m_TouchesEnabled = !m_TouchesEnabled;
			TouchDispatcher.Instance.enabled = m_TouchesEnabled;
			Debug.Log("Touch dispatcher enabled " + TouchDispatcher.Instance.enabled);
			#endif
		}

		#endregion


	}

}