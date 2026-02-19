using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CCPlayer : MonoBehaviour
{

    [Header("Movement")]
    public float walkSpeed = 5;
    public float runSpeed = 9;
    public float jumpHeight = 5;

    public Transform cameraTransform;
    public float lookSensativity = 1f;

    private CharacterController cc;
    private Vector2 moveInput;
    private Vector2 lookInput;
    private float verticalVelocity;
    private float gravity = -20f;
    private float pitch;

    private GameObject currentTarget;
    public Image reticleImage;

    private bool isRunning;
    private bool isJumping;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        reticleImage = GameObject.Find("Reticle").GetComponent<Image>();
        reticleImage.color = new Color(r: 0, g: 0, b: 0, a: .7f);


    }


    private void Handlelook()
    {
        float yaw = lookInput.x * lookSensativity;

        float pitchDelta = lookInput.y * lookSensativity;

        transform.Rotate(eulers: Vector3.up * yaw);

    }

    private void HandleMovement()
    {
        bool grounded = cc.isGrounded;
        Debug.Log("is grounded: " + grounded);

        if (grounded && verticalVelocity < 0)
        {
            verticalVelocity = 2f;

        }

        float currentSpeed = walkSpeed;

        if (isRunning)
        {
            currentSpeed = runSpeed;
        }

        else if(!isRunning)
        {
            currentSpeed = walkSpeed;
        }

        Vector3 move = transform.right * moveInput.x * currentSpeed + transform.forward * moveInput .y * currentSpeed;

        if (isJumping && grounded)
        {
            verticalVelocity = Mathf.Sqrt(f: jumpHeight * -2f * gravity);

        }
        else
        {
            isJumping = false;
        }

        verticalVelocity += gravity * Time.deltaTime;
        cc.Move(move * Time.deltaTime);

        Vector3 velocity = Vector3.up * verticalVelocity;
        cc.Move(motion:(move + velocity) * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void Onlook(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed) isJumping = true;

    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        isRunning = context.ReadValueAsButton();

    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed) interactPressed = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
