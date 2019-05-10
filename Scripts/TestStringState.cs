using UnityEngine;
using System.Collections;

namespace SA.CSM
{
	public class TestStringState : State
	{
		public float timerMax = 2;
		float timer;

		StateManager states;

		TestInputState inputState;

		private void Start()
		{
			states = GetComponent<StateManager>();
			inputState = GetComponent<TestInputState>();

		}

		public override void Tick(float delta)
		{
			timer += delta;

			if (timer > timerMax)
			{
				timer = 0;
				Debug.Log("String State");
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				states.ChangeState(inputState);
			}
		}
	}
}
