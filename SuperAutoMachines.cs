using System.Drawing;
using System.Windows.Forms;
 
public class SuperAutoMachines : App
{
    bool fundiu = false;
    bool clicked = false;
    RectangleF rect1 = RectangleF.Empty;
    RectangleF rect2 = RectangleF.Empty;
    RectangleF rect3 = RectangleF.Empty;
    RectangleF rect4 = RectangleF.Empty;
    RectangleF rect5 = RectangleF.Empty;
    public override void OnFrame(bool isDown, PointF cursor)
    {
        if (rect1.Contains(cursor) && rect2.Contains(cursor) && !isDown)
            fundiu = true;
 
        if (!fundiu)
        {
            rect1 = DrawPiece(new RectangleF(50, 50, 200, 200), 1, 3, 1, 1, true, "CNC");
            rect2 = DrawPiece(new RectangleF(400, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect3 = DrawPiece(new RectangleF(600, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect4 = DrawPiece(new RectangleF(800, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect5 = DrawPiece(new RectangleF(1000, 50, 200, 200), 2, 4, 2, 1, true, "CNC");

        }
        else
        {
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
            DrawPiece(new RectangleF(600, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            DrawPiece(new RectangleF(800, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            DrawPiece(new RectangleF(1000, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
        }
        fundiu = false;
        if (rect3.Contains(cursor) && rect4.Contains(cursor) && !isDown)
            fundiu = true;
 
        if (!fundiu)
        {
            rect1 = DrawPiece(new RectangleF(50, 50, 200, 200), 1, 3, 1, 1, true, "CNC");
            rect3 = DrawPiece(new RectangleF(600, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect4 = DrawPiece(new RectangleF(800, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect5 = DrawPiece(new RectangleF(1000, 50, 200, 200), 2, 4, 2, 1, true, "CNC");

        }
        else
        {
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
            DrawPiece(new RectangleF(600, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            DrawPiece(new RectangleF(800, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
            DrawPiece(new RectangleF(1000, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
        }

        if (!clicked)
        {
            clicked = DrawButton(new RectangleF(400, 400, 200, 100), "Iniciar");
            if (clicked)
                MessageBox.Show("Clicou");
        }
    }
}