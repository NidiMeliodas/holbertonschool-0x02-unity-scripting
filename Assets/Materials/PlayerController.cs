using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 5f;  // Modifiable depuis l'Inspector

	private Rigidbody rb;

	// Initialisation
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		if (rb == null)
		{
			Debug.LogError("Le PlayerController nécessite un composant Rigidbody.");
		}
	}

	// FixedUpdate est utilisé pour la physique
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal"); // A/D ou Flèches gauche/droite
		float moveVertical = Input.GetAxis("Vertical");     // W/S ou Flèches haut/bas

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
	}
}
