using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [Space]
    [SerializeField] private List<GameObject> _collectableList = new List<GameObject>();
    private void Update()
    {
        transform.position = _player.transform.position;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pickup();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            _collectableList.Add(collision.gameObject);
            Edge();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            _collectableList.Remove(collision.gameObject);
            Edge();
            collision.gameObject.GetComponent<Collectable>().HideEdge();
        }
    }
    public void Edge()
    {
        if (_collectableList.Count > 0)
        {
            for (int i = 0; i < _collectableList.Count; i++)
            {
                _collectableList[i].GetComponent<Collectable>().HideEdge();
            }
            _collectableList[_collectableList.Count - 1].GetComponent<Collectable>().ShowEdge();
        }
    }
    public void Pickup()
    {
        if (_collectableList.Count > 0)
        {
            GameObject pickedItem = _collectableList[_collectableList.Count - 1];
            pickedItem.GetComponent<Collectable>().HideEdge();
            pickedItem.GetComponent<Collectable>().Picked();
            pickedItem.SetActive(false);
            //_collectableList.RemoveAt(_collectableList.Count - 1);
            //Edge();
            Player playerScript = _player.GetComponent<Player>();
            playerScript.AddToBackpack(pickedItem.GetComponent<Collectable>());
        }
    }
}