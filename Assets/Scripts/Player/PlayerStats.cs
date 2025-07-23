using UnityEngine;

/// <summary>
/// This script holds player information across levels and provides information for other scripts to interact with
/// </summary>
public class PlayerStats : MonoBehaviour
{
    // Singleton
    public static PlayerStats Instance;

    #region Unity Exposed Fields
    [Header("References")]
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerLocomotiveStateMachine playerLocomotiveStateMachine;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Rigidbody rb;
    #endregion

    #region Properties/Variables
    /// <summary>
    /// These fields hold character capabilities that progress with development
    /// Variables are necessary for other scripts to read, these are not set in the inspector but are usually derived... and should be written as such
    /// </summary>
    [Header("Properties")]
    // JumpForce
    [SerializeField]
    [Range(0, 500f)] private float jumpForce; // Force to apply when player jumps, be careful
    public float JumpForce => jumpForce;
    // WalkSpeed
    [SerializeField]
    [Range(0, 20f)] private float walkSpeed; // Speed when walking
    public float WalkSpeed => walkSpeed;
    // RunSpeed
    [SerializeField]
    [Range(0, 20f)] private float runSpeed; // Speed when running
    public float RunSpeed => runSpeed;
    // SneakSpeed
    [SerializeField]
    [Range(0, 20f)] private float sneakSpeed; // Speed when sneaking
    public float SneakSpeed => sneakSpeed;

    [Header("Variables")]
    [SerializeField] private readonly float _moveSpeed; // Variable of the movement Speed that is adjusted by the states

    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
