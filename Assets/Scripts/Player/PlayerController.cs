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

}