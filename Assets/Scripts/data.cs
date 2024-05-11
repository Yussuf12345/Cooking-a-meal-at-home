using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu (fileName="new data",menuName="data")]
[Serializable]
public class data : ScriptableObject {
	//this is an object which is used to store email and password, it is an array to allow for any future expansion
	public int[] into;
	public string[] stringo;
}
