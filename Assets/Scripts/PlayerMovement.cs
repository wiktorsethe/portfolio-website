using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12f;          // Prędkość poruszania się do przodu
    public float rotationSpeed = 100f; // Prędkość obracania się w lewo i w prawo

    void Update()
    {
        // Sprawdzamy, czy gracz naciska W, aby poruszać się do przodu
        bool isMovingForward = Input.GetKey(KeyCode.W);

        // Poruszanie się do przodu przy naciśnięciu klawisza W
        if (isMovingForward)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // Obracanie gracza w lewo i prawo tylko wtedy, gdy porusza się do przodu
        if (isMovingForward && Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (isMovingForward && Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
