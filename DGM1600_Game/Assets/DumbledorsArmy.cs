using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbledorsArmy : MonoBehaviour {

	public string name;
		public string wand;

		public DumbledorsArmy(string newName, string newWand){
			name = newName;
			wand = newWand;
		}

		public int CompareTo(DumbledorsArmy other)
		{
			if(other == null){
				return 1;
			}

			return wand - other.wand;
		}

}