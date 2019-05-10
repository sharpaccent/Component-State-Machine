using UnityEngine;
using System.Collections;

namespace SA.CSM
{
	public class TestInputState : State
	{
		TestDataContainer dc;
		StateManager states;
		TestStringState stringState;

		private void Start()
		{
			dc = GetComponentInParent<TestDataContainer>();
			states = GetComponentInParent<StateManager>();
			stringState = GetComponent<TestStringState>();
		}

		public override void Tick(float delta)
		{
			dc.horizontal = Input.GetAxis("Horizontal");
			dc.vertical = Input.GetAxis("Vertical");
			dc.space = Input.GetKeyDown(KeyCode.Space);

			if (dc.space)
			{
				states.ChangeState(stringState);
			}

			Debug.Log("input state");
		}
	}
}
