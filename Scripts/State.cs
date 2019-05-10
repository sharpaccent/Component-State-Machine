using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA.CSM
{
	public abstract class State : MonoBehaviour
	{
		
		public abstract void Tick(float delta);

	}
}
