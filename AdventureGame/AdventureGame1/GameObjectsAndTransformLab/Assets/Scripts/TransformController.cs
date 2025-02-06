using UnityEngine;

public class TransformController : MonoBehaviour
{
	private void Update()
	{
		var x = Mathf.PingPong(Time.time, 3);
		var y = Mathf.PingPong(Time.time, 3);
		var p = new Vector3(y, x, 0);
		transform.position = p;
		transform.Rotate(new Vector3(30, 60, 0) * Time.deltaTime);
	}
}
