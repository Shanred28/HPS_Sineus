using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speedFly;

    private CharacterController characterController;
    public Vector3 TargetDirectionControl;
    public Vector3 DirectionControl;
    private Vector3 movementDirections;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        if (ÑharacterizationEcomorf.Instance.SpeedChar > 5)
            speedFly = speedFly  + (ÑharacterizationEcomorf.Instance.SpeedChar - 5) + 4;

    }

    private void Update()
    {
        DirectTarget();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void DirectTarget()
    {
        DirectionControl = Vector3.MoveTowards(DirectionControl, TargetDirectionControl, Time.deltaTime * speedFly);
    }
    private void Move()
    {
        
        movementDirections = DirectionControl * speedFly;

        movementDirections = transform.TransformDirection(movementDirections);

       // movementDirections += Physics.gravity * Time.deltaTime;

        characterController.Move(movementDirections * Time.fixedDeltaTime );
    }
}