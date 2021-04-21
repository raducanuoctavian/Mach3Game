using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    private Board board;

    // Start is called before the first frame update
    
    void Start()
    {
        board = FindObjectOfType<Board>();
    }

    public List<GameObject> GetColumnPieces(int column)
    {
        List<GameObject> dots = new List<GameObject>();
        for(int i = 0; i < board.height; i++)
        {

            if (board.allDots[column,i]!= null)
            {
                dots.Add(board.allDots[column,i]);
                board.allDots[column,i].GetComponent<Dot>().isMatched = true;
            }
        }
        return dots;
    }
    public List<GameObject> GetRowPieces(int row)
    {
        List<GameObject> dots = new List<GameObject>();
        for(int j = 0; j < board.width; j++)
        {
            if (board.allDots[j, row]!= null)
            {
                dots.Add(board.allDots[j, row]);
                board.allDots[j, row].GetComponent<Dot>().isMatched = true;
            }
        }
        return dots;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
