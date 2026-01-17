using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private void Update()
    {
        transform.position = _player.transform.position;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Sound Detected by: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().ChasePlayer();
        }
    }
}