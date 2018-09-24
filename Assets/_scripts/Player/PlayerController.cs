using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController: MonoBehaviour, IMovementController {

    [SerializeField] private float speed = 5f;
    [SerializeField] private float lookSensitivity = 5f;
    [SerializeField] private Camera cam;
    private PlayerMotor motor;
    private Rigidbody rb;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        motor = new PlayerMotor();
        motor.SetMovementController(this);
    }

    private void FixedUpdate()
    {
        // Translate
        motor.PerformMovement();
        // Rotate
        motor.PerformRotation();
    }

    #region IMovementController implementation
    public Vector3 CalculateVelocity()
    {
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");
        Vector3 _movHorizontal = gameObject.transform.right * _xMov;
        Vector3 _movVertical = gameObject.transform.forward * _zMov;

        //Final movement vector
        return (_movHorizontal + _movVertical).normalized * speed;
    }

    public Vector3 CalculateHorizontalRotation()
    {
        float _yRot;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _yRot = 0.15f;
        }
        else
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _yRot = -0.15f;
        }
        else
        {
            _yRot = Input.GetAxisRaw("Mouse X");
        }
        return new Vector3(0f, _yRot, 0f) * lookSensitivity;
    }

    public Vector3 CalculateVerticalRotation()
    {
        float _xRot;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _xRot = 0.15f;
        }
        else
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _xRot = -0.15f;
        }
        else
        {
            _xRot = Input.GetAxisRaw("Mouse Y");
        }
        return new Vector3(_xRot, 0f, 0f) * lookSensitivity;
    }

    public void MoveRigidbody(Vector3 velocity)
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    public void RotateHorizontal(Vector3 rotation)
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }

    public void RotateVertical(Vector3 rotation)
    {
        if (cam != null)
        {
            cam.transform.Rotate(-rotation);
        }
    }
    #endregion

}
