using UnityEngine;

public class CammeraFollow : MonoBehaviour {

	public Transform target;

	public Vector3 offset;

	private float currentZoom = 10f;
	private float pitch = 2f;

	void LateUpdate ()
	{
		transform.position = target.position - offset * currentZoom;
		transform.LookAt(target.position + Vector3.up * pitch);
	}
}
