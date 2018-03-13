using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSweet : MonoBehaviour {

    private int x;
    private int y;
    public int X
    {
        get
        {
            return x;
        }
        
        set
        {
            if (CanMove())
            {
                x = value;
            }
            
        }
    }
    public int Y
    {
        get
        {
            return y;
        }

        set
        {
            if (CanMove())
            {
                y = value;
            }
           
        }
    }

    private GameManager.SweetsType type;
    public GameManager.SweetsType Type
    {
        get
        {
            return type;
        }

    }

    [HideInInspector]
    public GameManager gameManager;

    public MovedSweet MovedComponent
    {
        get
        {
            return movedComponent;
        }

    }
    private MovedSweet movedComponent;

    public ColorSweet ColoredComponent
    {
        get
        {
            return coloredComponent;
        }

    }

    public ClearedSweet ClearedComponent
    {
        get
        {
            return clearedComponent;
        }
    }

    private ColorSweet coloredComponent;

    private ClearedSweet clearedComponent;

    public bool CanMove()
    {
        return movedComponent != null;
    }

    public bool CanColor()
    {
        return coloredComponent != null;
    }

    public bool CanClear()
    {
        return clearedComponent!= null;
    }

    private void Awake()
    {
        movedComponent = GetComponent<MovedSweet>();
        coloredComponent = GetComponent<ColorSweet>();
        clearedComponent = GetComponent<ClearedSweet>();
    }


    public void Init(int _x,int _y,GameManager _gameManager,GameManager.SweetsType _type)
    {
        x = _x;
        y = _y;
        gameManager = _gameManager;
        type = _type;
    }

    private void OnMouseEnter()
    {
        gameManager.EnterSweet(this);
    }

    private void OnMouseDown()
    {
        gameManager.PressSweet(this);
    }

    private void OnMouseUp()
    {
        gameManager.ReleaseSweet();
    }

    
}
