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
    [SerializeField] private PlayerStateMachine playerStateMachine;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Rigidbody rb;
    #endregion

    #region Properties/Variables
    /// <summary>
    /// These fields hold character capabilities that progress with development
    /// Variables are necessary for other scripts to read
    /// </summary>
    [Header("Properties")]
    [SerializeField]
    [Range(0, 500f)] private float jumpForce;
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
