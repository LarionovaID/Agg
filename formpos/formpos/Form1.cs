using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace formpos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbContext db = new DbContext();
        int countError = 0;

        private string text = string.Empty;
        private System.Timers.Timer myTimer;

        //disable login button
        private void EnableLoginButton(object sender, ElapsedEventArgs e)
        {
            button3.Invoke(new Func<bool>(() => button3.Enabled = true));
        }
        //error message
        private void ShowError()
        {
            countError++;
            errorCountLabel.Text = $"'{countError}'";
            pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
            if (countError == 3)
            {
                countError = 0;
                errorCountLabel.Text = $"'{countError}'";
                button3.Enabled = false;
                myTimer = new System.Timers.Timer(10000);
                myTimer.Elapsed += new ElapsedEventHandler(EnableLoginButton);
                myTimer.AutoReset = true;
                myTimer.Enabled = true;
            }
        }
        //refresh
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
        //captcha create picture
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = 10;
            int Ypos = 10;

            //Добавим различные цвета ддя текста
            Brush[] colors = {
                     Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green,
                     Brushes.Yellow,
                     Brushes.White, 
                     Brushes.Tomato,
                     Brushes.Sienna,
                     Brushes.Pink };

            //Добавим различные цвета линий
            Pen[] colorpens = {
                     Pens.Black,
                     Pens.Red,
                     Pens.RoyalBlue,
                     Pens.Green,
                     Pens.Yellow,
                     Pens.White, 
                     Pens.Tomato,
                     Pens.Sienna,
                     Pens.Pink };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = {
                     FontStyle.Bold,
                     FontStyle.Italic,
                     FontStyle.Regular,
                     FontStyle.Strikeout,
                     FontStyle.Underline};

            //Добавим различные углы поворота текста
            Int16[] rotate = {1,-1,2,-2,3,-3,4,-4,5,-5,6,-6};

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);            

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
            textBox3.PasswordChar = '*';
            textBox2.MaxLength = 50;
            textBox3.MaxLength = 20;
        }   
        //login
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == text)
            {
                var email = textBox2.Text;
                var password = textBox3.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string queryString = $"select id, Login, Password from Users where Login = '{email}' and Password = '{password}'";
                SqlCommand command = new SqlCommand(queryString, db.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("done!", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 form3 = new Form3();
                    this.Hide();
                    form3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("user not found");
                    ShowError();
                }
            }
            else
            {
                MessageBox.Show("captcha error");
                ShowError();
            }
        }
        
    }
}
