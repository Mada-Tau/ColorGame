using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    Color background;
    public ColorManager colorManager;


    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }
    void OnMouseDown()
    {
        _highlight.SetActive(false);

    }
    void OnMouseUp()
    {
        _highlight.SetActive(true);
        background = colorManager.selectedColor;
        this._baseColor = background;
        this._offsetColor = background;
        Init(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
    
}
