using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using group2Project.Models;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace group2Project.Views
{
    public partial class mapView : Form
    {
        public int NumOfPlayers;
        public Courses Course;
        public int PlayerTurn = 0;
        public int QuestionIndex { get; set; }
        List<Student> Players = new List<Student>();
        List<Trivia> questions = new List<Trivia>();
        ScoreBoard scoreboard;
        public mapView(int NumOfPlayers, Courses Course, List<Trivia> questions, ScoreBoard scoreBoard)
        {
            InitializeComponent();
            Console.WriteLine(NumOfPlayers);
            Console.WriteLine(Course);
            this.questions = questions;
            this.NumOfPlayers = NumOfPlayers;
            this.Course = Course;
            this.QuestionIndex = 0;
            this.scoreboard = scoreBoard;
        }

        public void initializePlayers(int NumOfPlayers)
        {
            int i = 0;
            //Had to remove for testing 
            /* this next five lines is all for testing, due to this, we can only have 2 players until this is changed */
            /*List<Student> testData = new List<Student>();
            Student person1 = new Student("example", "testing", 0);
            Student person2 = new Student("2ndexample", "testing", 0);
            testData.Add(person1);
            testData.Add(person2);

            for (i = 0; i < testData.Count; i++)
            {
                Players.Add(testData[i]);
                Console.WriteLine(Players[i].userName);
            }*/
        }
            //we will need to figure out how to get each player to have individual usernames and passwords, this will probably include the database
         /* for (i = 0; i < NumOfPlayers; i++)
            {
                Players.Add(person1); //for now only test with 2 players 
                Console.WriteLine(Players[i].password);
            }
         } */ //commented out for testing
           

            
        
        // The height of a hexagon.
        private const float HexHeight = 50;

        // Selected hexagons.
        private List<PointF> Hexagons = new List<PointF>();

        // Redraw the grid.
        private void picGrid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int playerNum = 1;

            // Draw the selected hexagons.
            foreach (PointF point in Hexagons)
            {
                e.Graphics.FillPolygon(Brushes.LightSeaGreen,
                    HexToPoints(HexHeight, point.X, point.Y));

                // Find center point of hex
                PointF[] clickedHexagons = HexToPoints(HexHeight, point.X, point.Y);
                float centerX = 0;
                float centerY = 0;
                foreach (PointF clickedHex in HexToPoints(HexHeight, point.X, point.Y)) 
                {
                    centerX += clickedHex.X;
                    centerY += clickedHex.Y;
                }
                centerX /= clickedHexagons.Length;
                centerY /= clickedHexagons.Length;

                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    float x = point.X;
                    float y = point.Y;
                    string label = playerNum.ToString();
                    e.Graphics.DrawString(label, this.Font,
                        Brushes.Black, centerX, centerY, sf);
                }
                playerNum++;
            }
            // Draw the grid.
            DrawHexGrid(e.Graphics, Pens.Black,
                0, picGrid.ClientSize.Width,
                0, picGrid.ClientSize.Height,
                HexHeight);
        }
        // Draw a hexagonal grid for the indicated area.
        private void DrawHexGrid(Graphics gr, Pen pen,
            float xmin, float xmax, float ymin, float ymax,
            float height)
        {
            // Loop until a hexagon won't fit.
            for (int row = 0; ; row++)
            {
                // Get the points for the row's first hexagon.
                PointF[] points = HexToPoints(height, row, 0);

                // If it doesn't fit, we're done.
                if (points[4].Y > ymax) break;

                // Draw the row.
                for (int col = 0; ; col++)
                {
                    // Get the points for the row's next hexagon.
                    points = HexToPoints(height, row, col);

                    // If it doesn't fit horizontally,
                    // we're done with this row.
                    if (points[3].X > xmax)
                    {
                        break;
                    }
                    // If it fits vertically, draw it.
                    if (points[4].Y <= ymax)
                    {
                        gr.DrawPolygon(pen, points);

                        // This can be used to label the initial hexagon

                        /*using (StringFormat sf = new StringFormat())
                        {
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            float x = (points[0].X + points[3].X) / 2;
                            float y = (points[1].Y + points[4].Y) / 2;
                            string label = "(" + row.ToString() + ", " +
                                col.ToString() + ")";
                            gr.DrawString(label, this.Font,
                                Brushes.Black, x, y, sf);
                        }*/
                    }
                }
            }
        }

        private void picGrid_Resize(object sender, EventArgs e)
        {
            picGrid.Refresh();
        }
        // Display the row and column under the mouse.
        private void picGrid_MouseMove(object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex(e.X, e.Y, HexHeight, out row, out col);
            this.Text = "(" + row + ", " + col + ")";
        }
        // Add the clicked hexagon to the Hexagons list.
        private void picGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int row, col;
            Label label = new Label();
            label.Text = ""; //should be player number later on once we get that working
            QuizGame quiz = new QuizGame(Course, questions, QuestionIndex);
            quiz.ShowDialog();
            /*if (coordinate already has been clicked) 
             * {
             *      check if player is in cooldown;
             *      enter a contested territory mode;
             * }*/
            if (quiz.returnCorrect() == true)
            {
                scoreboard.territories++;
                scoreboard.UpdateList();
                Console.WriteLine(scoreboard.territories);
                QuestionIndex++; //Increase question index if correct
                if(QuestionIndex >= questions.Count()) //If we reach the end of the questions reset Index back to 0
                {
                    QuestionIndex = 0;
                }
                PointToHex(e.X, e.Y, HexHeight, out row, out col);
                label.Location = new System.Drawing.Point(e.X , e.Y); 
                label.Size = new System.Drawing.Size((int)HexWidth(HexHeight - 20), (int)HexHeight - 15);
                label.BackColor = Color.LightBlue;
                //Console.WriteLine(Players[PlayerTurn].score);
                //Players[PlayerTurn].score++;
                label.Text = (PlayerTurn + 1).ToString();
                //Console.WriteLine(Players[PlayerTurn].score);
                //picGrid.Controls.Add(label);
                Hexagons.Add(new PointF(row, col));     
            } 
                if (PlayerTurn + 1 < Players.Count) {
                    PlayerTurn++;
                }
                else
                {
                    PlayerTurn = 0;
                }
                
                picGrid.Refresh();
            
           
        }
        // Return the width of a hexagon.
        private float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }

        // Return the row and column of the hexagon at this point.
        private void PointToHex(float x, float y, float height,
            out int row, out int col)
        {
            // Find the test rectangle containing the point.
            float width = HexWidth(height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 == 0)
            {
                row = (int)(y / height);
            }
            else
            {
                row = (int)((y - height / 2) / height);
            }
            // Find the test area.
            float testx = col * width * 0.75f;
            float testy = row * height;
            if (col % 2 == 1)
            {
                testy += height / 2;
            }
            // See if the point is above or below the test hexagon on the left.
            bool is_above = false, is_below = false;
            float dx = x - testx;
            if (dx < width / 4)
            {
                float dy = y - (testy + height / 2);
                if (dx < 0.001)
                {
                    // The point is on the left edge of the test rectangle.
                    if (dy < 0) is_above = true;
                    if (dy > 0) is_below = true;
                }
                else if (dy < 0)
                {
                    // See if the point is above the test hexagon.
                    if (-dy / dx > Math.Sqrt(3)) is_above = true;
                }
                else
                {
                    // See if the point is below the test hexagon.
                    if (dy / dx > Math.Sqrt(3)) is_below = true;
                }
            }
            // Adjust the row and column if necessary.
            if (is_above)
            {
                if (col % 2 == 0) row--;
                col--;
            }
            else if (is_below)
            {
                if (col % 2 == 1) row++;
                col--;
            }
        }
        // Return the points that define the indicated hexagon.
        private PointF[] HexToPoints(float height, float row, float col)
        {
            // Start with the leftmost corner of the upper left hexagon.
            float width = HexWidth(height);
            float y = height / 2;
            float x = 0;
            // Move down the required number of rows.
            y += row * height;
            // If the column is odd, move down half a hex more.
            if (col % 2 == 1)
            {
                y += height / 2;
            }
            // Move over for the column number.
            x += col * (width * 0.75f);
            // Generate the points.
            return new PointF[]
                {
                    new PointF(x, y),
                    new PointF(x + width * 0.25f, y - height / 2),
                    new PointF(x + width * 0.75f, y - height / 2),
                    new PointF(x + width, y),
                    new PointF(x + width * 0.75f, y + height / 2),
                    new PointF(x + width * 0.25f, y + height / 2),
                };
        }

        private void mapView_Load(object sender, EventArgs e)
        {
            initializePlayers(NumOfPlayers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
