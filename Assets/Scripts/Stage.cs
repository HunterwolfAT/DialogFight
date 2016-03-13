using UnityEngine;
using System.Collections;

public class Stage {
	// Question: What Partner says, op1-4 are the 4 dialog options, k1-4 are the keys to the next stage
	public string question, innervoice, op1, op2, op3, op4, key1, key2, key3, key4;
	public int newGamestate; // Changes up attackes & other special stuff

	public Stage(int gs, string q, string iv, string o1, string o2, string o3, string o4, string k1, string k2, string k3, string k4)
	{
		question = q;
		innervoice = iv;
		op1 = o1;
		op2 = o2;
		op3 = o3;
		op4 = o4;
		key1 = k1;
		key2 = k2;
		key3 = k3;
		key4 = k4;
		newGamestate = gs;
	}
}
