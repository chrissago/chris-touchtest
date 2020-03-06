namespace TestingTouches {

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using SagoTouch;

	public class ToggleTouchArea : MonoBehaviour {


		#region Fields

		[SerializeField]
		private TouchArea m_TouchArea;

		[System.NonSerialized]
		private bool m_TouchAreaEnabled = true;

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
			if (m_TouchArea == null)		
			{
				return;
			}
			m_TouchAreaEnabled = !m_TouchAreaEnabled;
			m_TouchArea.enabled = m_TouchAreaEnabled;
			Debug.Log("Touch area enabled " + m_TouchArea.enabled);
		}

		#endregion


	}
}