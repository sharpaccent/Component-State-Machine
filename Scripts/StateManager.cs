using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SA.CSM
{
	public class StateManager : MonoBehaviour
	{
		[SerializeField]
		State currentState;
		[SerializeField]
		State defaultState;


		private void Start()
		{
			
		}

		private void Update()
		{
			if (currentState != null)
			{
				currentState.Tick(Time.deltaTime);
			}
		}

		public void ChangeState(State targetState)
		{
			if (currentState != null)
			{
				//currentState.Exit()
			}

			currentState = targetState;

			if (currentState != null)
			{
				//currentState.OnEnter()
			}
		}

		public void BackToDefaultState()
		{
			ChangeState(defaultState);
		}

	}
}
