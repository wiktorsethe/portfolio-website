using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;             // Prędkość poruszania
    public float rotationSpeed = 100f;   // Prędkość obracania
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Pobranie komponentu CharacterController
    }

    void Update()
    {
        Vector3 move = Vector3.zero;

        // Poruszanie się do przodu
        if (Input.GetKey(KeyCode.W))
        {
            move += transform.forward;
        }

        // Obracanie gracza
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // Ruch gracza
        controller.Move(move * speed * Time.deltaTime);
    }
}
