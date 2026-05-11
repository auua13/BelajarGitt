using UnityEngine;
using UnityEngine.InputSystem;
using TMPro; // WAJIB untuk menggunakan TextMeshPro

public class PlayerController : MonoBehaviour
{
    public PlayerData data;
    public TextMeshProUGUI hpText; // Tarik objek Text HP kamu ke sini di Inspector

    private float currentHP;
    private PlayerInput playerInput;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        
    }
     void Update()
    {
        // 1. CEK STATE & NULL: Keamanan agar tidak error saat pindah scene
        if (GameManager.Instance == null || GameManager.Instance.currentState != GameState.Playing) 
            return;
            
        if (playerInput == null || data == null) return;

        // 2. LOGIKA GERAK
        Vector2 moveInput = playerInput.actions["Move"].ReadValue<Vector2>();
        transform.Translate(new Vector3(moveInput.x, moveInput.y, 0) * data.moveSpeed * Time.deltaTime);
    }


}