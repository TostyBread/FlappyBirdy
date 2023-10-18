using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{

    public static event Action OnDeath; //Script for when DaPlane crashed with retry
    public static event Action OnScore; //Script for scoring

    [SerializeField] private Rigidbody2D _rigidBody2D;
    [SerializeField] private float _JumpForce;
    [SerializeField] private float _yBound; //maximum DaPlane allow to fly in Yaxis

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _jumpSound;
    [SerializeField] private AudioClip _hitSound;
    [SerializeField] private AudioClip _scoreSound;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && _rigidBody2D.position.y < _yBound) //press space to jump DaPlane && with y axis restrictions
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D()
    {
        OnDeath?.Invoke();

        _audioSource.PlayOneShot(_hitSound);

        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D()
    {
        OnScore?.Invoke();

        _audioSource?.PlayOneShot(_scoreSound);

    }

    private void Jump()
    {
        _rigidBody2D.velocity = Vector2.zero;
        _rigidBody2D.AddForce(Vector2.up * _JumpForce);

        _audioSource.PlayOneShot(_jumpSound);
    }
}
