using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    Vector2 velocity, input;

    void Start()
    {
        transform.position = Vector3.zero;   
    }

    void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (input != Vector2.zero)
        {
            input = input.normalized;
            velocity = Vector2.MoveTowards(velocity, input * maxSpeed, 100f * Time.deltaTime);
        } else
        {
            velocity = Vector2.MoveTowards(velocity, Vector2.zero, 100f * Time.deltaTime);
        }

        if (velocity.magnitude < 0.1f)
        {
            velocity = Vector2.zero;
        }

        transform.Translate(velocity * Time.deltaTime);
    }

    // Bound player coordinates here
}
