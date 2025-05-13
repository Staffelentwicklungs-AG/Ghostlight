using UnityEngine;
using UnityEngine.Tilemaps;
using static UnityEngine.InputSystem.InputAction;

public class BaseCharacterMovement : MonoBehaviour
{
    private Vector2 movementInput;
    private Transform camTransform;
    [SerializeField] private float movementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        camTransform = Camera.main.transform;
   
    }
    public void Movement(CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {


        var movementDirection = movementInput.x * camTransform.right + movementInput.y * Vector3.ProjectOnPlane(camTransform.forward, Vector3.up).normalized;

        transform.Translate(movementDirection * Time.deltaTime * movementSpeed );

    }
}
