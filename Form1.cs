using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.draw
{
    public partial class Form1 : Form
    {
        Point m_down;
        Point m_move;
        bool m_isDown = false;
        Shapes CurrentShape = Shapes.Line;

        List<Shape> shapes = new List<Shape>();

        Pen pen = new Pen(Color.Red, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m_down = e.Location;

            m_isDown = true;

            mDownLbl.Text = e.Location.ToString();
        }

        private void linebtn_Click(object sender, EventArgs e)
        {
            CurrentShape = Shapes.Line;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m_isDown = false;

            Shape shape = ObjectShape(CurrentShape);

            shapes.Add(shape);

            mUpLbl.Text = e.Location.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (m_isDown)
            {
                Shape shape = ObjectShape(CurrentShape);

                shape.Draw(g);
            }

            foreach (Shape item in shapes)
            {
                item.Draw(g);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_isDown)
            {
                m_move = e.Location;
                pictureBox1.Refresh();
            }

            mMoveLbl.Text = e.Location.ToString();
        }

        private void circlebtn_Click(object sender, EventArgs e)
        {
            CurrentShape = Shapes.Circle;
        }

        private void rectbtn_Click(object sender, EventArgs e)
        {
            CurrentShape = Shapes.Rect;
        }

        private Shape ObjectShape(Shapes shape)
        {
            switch (shape)
            {
                case Shapes.Line:
                    return new Line(pen, m_down, m_move);
                    break;
                case Shapes.Rect:
                    return new Rect(pen, m_down, m_move);
                    break;
                case Shapes.Circle:
                    return new Circle(pen, m_down, m_move);
                    break;
                default:
                    throw new Exception("object error!");
                    break;
            }
        }

        private void colorlbl_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(colorDialog1.Color);
                colorlbl.BackColor = colorDialog1.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen = new Pen(colorlbl.BackColor, (float)numericUpDown1.Value);
        }
    }
}
