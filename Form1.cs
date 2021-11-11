using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c;
            
            a = Convert.ToDouble(txtA.Text);//считываем значение сторон а
            b = Convert.ToDouble(txtB.Text);//считываем значение сторон b
            c = Convert.ToDouble(txtC.Text);//считываем значение сторон c
            
            Triangle triangle = new Triangle(a, b, c);//создаем объект класса Triangle с названием Triangle 
            listView1.Items.Add("Сторона a");//добавляем соответсвующие ячейки в коллекцию items объекта с именем listView1
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");          
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[5].SubItems.Add("Не существует");
            listView1.Items[6].SubItems.Add(triangle.TriangleType);


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnnTe_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
