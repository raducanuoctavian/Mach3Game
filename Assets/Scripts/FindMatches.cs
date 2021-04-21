﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FindMatches : MonoBehaviour
{   

    private Board board;
    private Rook rook;  
    private Bishop bishop;  
    public List<GameObject> currentMatches = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        rook = FindObjectOfType<Rook>();
        bishop = FindObjectOfType<Bishop>();
        board = FindObjectOfType<Board>();

    }


    public void FindAllMatches()
    {
        StartCoroutine(FindAllMatchesCo());
    }


    private IEnumerator FindAllMatchesCo()
    {
        yield return new WaitForSeconds(.2f);
        for (int i = 0 ; i < board.width ; i++)
        {
            for(int j = 0; j < board.height; j++)
            {
                GameObject currentDot = board.allDots[i, j];
                if(currentDot != null)
                {
                    if(i > 0 && i < board.width -1)
                    {
                        GameObject leftDot = board.allDots[i-1, j];
                        GameObject rightDot = board.allDots[i+1, j];
                        if(leftDot != null && rightDot != null)
                        {
                            if(leftDot.tag == currentDot.tag && rightDot.tag == currentDot.tag)
                            {
                                //rook
                                if(currentDot.GetComponent<Dot>().isRowBomb
                                || leftDot.GetComponent<Dot>().isRowBomb
                                || rightDot.GetComponent<Dot>().isRowBomb)
                                {

                                    currentMatches.Union(rook.GetRowPieces(j));
                                }
    
                                if(currentDot.GetComponent<Dot>().isColumnBomb)
                                {
                            
                                    currentMatches.Union(rook.GetColumnPieces(i));
                                }
                                if(leftDot.GetComponent<Dot>().isColumnBomb)
                                {
                                    currentMatches.Union(rook.GetColumnPieces(i-1));
                                }
                                if(rightDot.GetComponent<Dot>().isColumnBomb)
                                {
                                    currentMatches.Union(rook.GetColumnPieces(i+1));
                                }



                            //bishop
                            if(currentDot.GetComponent<Dot>().isBishop
                                || leftDot.GetComponent<Dot>().isBishop
                                || rightDot.GetComponent<Dot>().isBishop)
                                {
                                    currentMatches.Union(bishop.GetDiagonal());
                                }

                            //horse




                            //Queen




                            //King





                            if(!currentMatches.Contains(leftDot))
                                {
                                    currentMatches.Add(leftDot);
                                }
                                leftDot.GetComponent<Dot>().isMatched = true;
                            if(!currentMatches.Contains(rightDot))
                                {
                                    currentMatches.Add(rightDot);
                                }    
                                rightDot.GetComponent<Dot>().isMatched = true;
                            if(!currentMatches.Contains(currentDot))
                                {
                                    currentMatches.Add(currentDot);
                                }
                                currentDot.GetComponent<Dot>().isMatched = true;

                            
                            }
                        }
                    }
                    if(j > 0 && j < board.height -1)
                    {
                        GameObject upDot = board.allDots[i, j+1];
                        GameObject downDot = board.allDots[i, j-1];
                        if(upDot != null && downDot != null)
                        {
                            if(upDot.tag == currentDot.tag && downDot.tag == currentDot.tag)
                            {

                                if(currentDot.GetComponent<Dot>().isColumnBomb
                                || upDot.GetComponent<Dot>().isColumnBomb
                                || downDot.GetComponent<Dot>().isColumnBomb)
                                {

                                    currentMatches.Union(rook.GetColumnPieces(i));
                                }
                                if(currentDot.GetComponent<Dot>().isRowBomb)
                                {
                                    currentMatches.Union(rook.GetRowPieces(j));
                                }
                                if(upDot.GetComponent<Dot>().isRowBomb)
                                {
                                    currentMatches.Union(rook.GetRowPieces(j+1));
                                }
                                if(downDot.GetComponent<Dot>().isRowBomb)
                                {
                                    currentMatches.Union(rook.GetRowPieces(j-1));
                                }




                                if(currentDot.GetComponent<Dot>().isBishop
                                || upDot.GetComponent<Dot>().isBishop
                                || downDot.GetComponent<Dot>().isBishop)
                                {

                                    currentMatches.Union(bishop.GetDiagonal());
                                }






                                if(!currentMatches.Contains(upDot))
                                {
                                    currentMatches.Add(upDot);
                                }
                                upDot.GetComponent<Dot>().isMatched = true;
                                if(!currentMatches.Contains(downDot))
                                {
                                    currentMatches.Add(downDot);
                                }
                                downDot.GetComponent<Dot>().isMatched = true;
                                if(!currentMatches.Contains(currentDot))
                                {
                                    currentMatches.Add(currentDot);
                                }
                                currentDot.GetComponent<Dot>().isMatched = true;

                            }
                        }
                    }

                }
            }
        }
    
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

}



