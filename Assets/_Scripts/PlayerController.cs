using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    #region Variables

    [Header("Variables")]
    [SerializeField] private float speed = 6.0f;

    private Rigidbody rbPlayer;

    #endregion

    private void Awake()
    {
        rbPlayer = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");
        Vector3 velocity = new Vector3(xInput, 0, zInput).normalized * speed;
        rbPlayer.MovePosition(rbPlayer.position + velocity * Time.fixedDeltaTime);
    }
}
