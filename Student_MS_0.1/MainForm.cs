using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_MS_0._1
{
    public partial class MainForm : Form
    {
        /*StudentClass student = new StudentClass();
        CourseClass course = new CourseClass(); */

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           ); 

        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();
            //populate the combobox with courses name
            /* comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName"; */
        }

        //create a function to display student count
        private void studentCount()
        {
            //Display the values
            /* label_totalStd.Text = "Total Students : " + student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent(); */

        }


        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_coursesubmenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_coursesubmenu.Visible == true)
                panel_coursesubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);

        }

        private void button_registration_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_manageStd_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_status_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursesubmenu);
        }

        private void button_newcourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_managescore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_courseprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourse());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);

            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }
    }
}
