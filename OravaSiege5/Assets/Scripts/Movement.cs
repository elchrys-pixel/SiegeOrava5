using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Board Dimensions
    public float boardWidth = 4.66f;
    public float boardHeight = 3.88f;

    //Starting Position
    private int pieceX = 0;
    private int pieceY = 0;

    //Direction the piece will move
    public int dx = 0;
    public int dy = 0;


    //Define function that will move the piece
    private void MovePiece()
    {
        //Update position of piece

        pieceX += dx;
        pieceY += dy;

        //Check if the piece is still on the board

        //if (this.transform.position == new Vector3(4.66f, 0, 0) || this.transform.position.x >= new Vector3(4.66f, 0, 0))
        //{
        //    pieceX -= dx;
        //}

        //if (pieceX < 3.04f || pieceX >= boardWidth || pieceY < 2.17f || pieceY >= boardHeight)

        {
            // if piece is off board move back to original position
            //pieceX = this.transform.position -= new Vector3(-0.55f, 0, 0)
            //pieceY -= dy;

            // if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x >= 4.66f)
            //    this.transform.position += new Vector3(0, 0);

            //if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x <= 3.04f)
            //    this.transform.position += new Vector3(0, 0);

            //if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.y >= 3.88f)
            //    this.transform.position += new Vector3(0, 0);

            //if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.y <= 2.17f)
            //    this.transform.position += new Vector3(0, 0);

        }
    }
        // The function that will handle arrow keys
        //public void MovePiece()


        //if (keyCode == KeyCode.LeftArrow)
        //{
        // dx = -1;
        // dy = 0;
        //}

        //else if (keyCode == KeyCode.RightArrow)
        //{
        //    dx = 1;
        //    dy = 0;
        //}

        //else if (keyCode == KeyCode.UpArrow)
        //{
        //    dx = 0;
        //    dy = 1;
        //}

        //else if (keyCode == KeyCode.DownArrow)
        //{
        //    dx = 0;
        //    dy = -1;
        //}

        // MovePiece function every frame to update position
        void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(0.55f, 0, 0);
            dx = 1;
            dy = 0;
            MovePiece();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position -= new Vector3(0.55f, 0, 0);
            dx = -1;
            dy = 0;
            MovePiece();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0, 0, 0.55f);
            dx = 0;
            dy = 1;
            MovePiece();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position -= new Vector3(0, 0, 0.55f);
            dx = 0;
            dy = -1;
            MovePiece();
        }

        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x >= 4.66f)
            this.transform.position -= new Vector3(0.55f, 0);

        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x <= -3.59f)
            this.transform.position += new Vector3(0.55f, 0);

        if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.z >= 3.88f)
            this.transform.position -= new Vector3(0, 0, 0.55f);

        if (Input.GetKey(KeyCode.DownArrow) && this.transform.position.z <= -4.37f)
            this.transform.position += new Vector3(0, 0, 0.55f);

    }
}
