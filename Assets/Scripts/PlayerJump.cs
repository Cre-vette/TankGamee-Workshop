using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;
    public int maxJumps = 2;
    public Rigidbody playerRigidbody;
    private int jumpsRemaining;

    // Définir une référence à l'action de saut de la manette
    public InputAction jumpAction;

    private void OnEnable()
    {
        // Activer l'action de saut de la manette
        jumpAction.Enable();
    }

    private void OnDisable()
    {
        // Désactiver l'action de saut de la manette
        jumpAction.Disable();
    }

    void Start()
    {
        jumpsRemaining = maxJumps;
        // Attribuer la fonction JumpOnInput à l'action de saut de la manette
        jumpAction.performed += _ => JumpOnInput();
    }

    void Update()
    {
        // Vérifie si l'action "Jump" est activée dans le PlayerInput et s'il reste des sauts
        if (Keyboard.current.spaceKey.wasPressedThisFrame && jumpsRemaining > 0)
        {
            JumpOnInput();
        }
    }

    void JumpOnInput()
    {
        if (jumpsRemaining > 0)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpsRemaining--;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        jumpsRemaining = maxJumps;
    }
}

