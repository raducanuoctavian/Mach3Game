/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
    private Board board;

    // Start is called before the first frame update
    
    void Start()
    {
        board = FindObjectOfType<Board>();
    }

    public List<GameObject> UpDownL()
    {
        List<GameObject> dots = new List<GameObject>();
        for(int i = 0, j=0; i < board.height; i++, j++)
        {

                if (board.allDots[j,i]!= null)
                {
                    dots.Add(board.allDots[j,i]);
                    board.dots.GetComponent<Dot>().isMatched = true;
                
                }
        }
        return dots;
    }


    public List<GameObject> DownUpL()
    {
        List<GameObject> dots = new List<GameObject>();
        for(int i = 0, j=0; i < board.height; i++, j++)
        {

                if (board.allDots[j,i]!= null)
                {
                    dots.Add(board.allDots[j,i]);
                    board.allDots[i,j].GetComponent<Dot>().isMatched = true;
                
                }
        }
        return dots;
    } 


    public List<GameObject> RightLeftL()
    {
        List<GameObject> dots = new List<GameObject>();
        for(int i = 0, j=0; i < board.height; i++, j++)
        {

                if (board.allDots[j,i]!= null)
                {
                    dots.Add(board.allDots[j,i]);
                    board.allDots[i,j].GetComponent<Dot>().isMatched = true;
                
                }
        }
        return dots;
    }

    public List<GameObject> LeftRightL()
    {
        List<GameObject> dots = new List<GameObject>();
        for(int i = 0, j=0; i < board.height; i++, j++)
        {

                if (board.allDots[j,i]!= null)
                {
                    dots.Add(board.allDots[j,i]);
                    board.allDots[i,j].GetComponent<Dot>().isMatched = true;
                
                }
        }
        return dots;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
*/