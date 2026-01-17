using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private GameObject _edge;
    [Space]
    [SerializeField] private string _itemName;
    [SerializeField] private int _weight;
    [SerializeField] private int _value;
    [Space]
    [SerializeField] private bool _isPicked;
    public void ShowEdge()
    {
        _edge.SetActive(true);
    }
    public void HideEdge()
    {
        _edge.SetActive(false);
    }
    public void Picked()
    {
        _isPicked = true;
    }
    public void Dropped()
    {
        _isPicked = false;
    }
    public int GetValue()
    {
        return _value;
    }
    public int GetWeight()
    {
        return _weight;
    }
    public bool IsPicked()
    {
        return _isPicked;
    }
}
