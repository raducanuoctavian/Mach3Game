using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : MonoBehaviour
{
    private Board board;
    private Board allDots;
    public static List<Coord> coord = new List<Coord>();



    // Start is called before the first frame update


    public void Start()
    {
        board = FindObjectOfType<Board>();
                   for (int i = 0 ; i < board.width ; i++)
                {
                    for(int j = 0; j < board.height; j++)
                        {
                            GameObject currentDot = new GameObject();
    currentDot = board.allDots[i, j];}}
        
    }
    public void diagonalElements(int x, int y,Board board)
    {
        int maxX = 8;
        for(int i = x - 1, j = y + 1; j > 0 && i < maxX ; j--, i++)
        {

            coord.Add(new Coord(i,j));
        }
        
    }
    public List<GameObject> GetDiagonal()
    {

        List<GameObject> dots = new List<GameObject>(); 
           for (int i = 0 ; i < board.width ; i++)
                {
                    for(int j = 0; j < board.height; j++)
                        {
                            currentDot.diagonalElements(i,j,board);
        if(i >= 0 && i < board.width )
            {
                if (currentDot!= null)
                    {
                        dots.Add(currentDot);
                        currentDot.GetComponent<Dot>().isMatched = true;
                    }
            }
    }}}
        /*for (int i = 0, j = 0 ; i < board.width ; i++, j++)
            {
                GameObject currentDot = board.allDots[i, j];
                if(currentDot != null)
                    {
                        if(i >= 0 && i < board.width )
                        {    
                            diagonalElements(i,j,board);
                            if (currentDot!= null)
                            {

                                dots.Add(currentDot);
                                currentDot.GetComponent<Dot>().isMatched = true;


                            }
                        }
                    
                    }
                
            }
        return dots;
    }
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
