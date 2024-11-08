using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_232410101011_utspbo.View
{
    public partial class HalLogin : Form
    {
        public HalLogin()
        {
            InitializeComponent();
        }

        private void HalLogin_Load(object sender, EventArgs e)
        {
            partial class HalLogin
            /// <param name="disposing">true if managed resources
should be disposed; otherwise, false.</param>
protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginIni
        t();
            SuspendLayout();
            //
            // dataGridView1
            //
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 294);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick +=
            dataGridView1_CellContentClick;
            {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components =
            null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
        }
    }
}
