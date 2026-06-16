namespace ScottWin;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ListViewDepartments = new System.Windows.Forms.ListView();
        textBox1 = new System.Windows.Forms.TextBox();
        btnSAFE = new System.Windows.Forms.Button();
        tbDeptNO = new System.Windows.Forms.TextBox();
        tbDNAME = new System.Windows.Forms.TextBox();
        tbLOC = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        Show = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        btnCreate = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // ListViewDepartments
        // 
        ListViewDepartments.FullRowSelect = true;
        ListViewDepartments.Location = new System.Drawing.Point(76, 63);
        ListViewDepartments.Name = "ListViewDepartments";
        ListViewDepartments.Size = new System.Drawing.Size(375, 217);
        ListViewDepartments.TabIndex = 0;
        ListViewDepartments.UseCompatibleStateImageBehavior = false;
        ListViewDepartments.View = System.Windows.Forms.View.Details;
        ListViewDepartments.SelectedIndexChanged += ListViewDepartments_SelectedIndexChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(16, 11);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(100, 27);
        textBox1.TabIndex = 1;
        // 
        // btnSAFE
        // 
        btnSAFE.Location = new System.Drawing.Point(199, 11);
        btnSAFE.Name = "btnSAFE";
        btnSAFE.Size = new System.Drawing.Size(176, 27);
        btnSAFE.TabIndex = 4;
        btnSAFE.Text = "SAVE";
        btnSAFE.UseVisualStyleBackColor = true;
        btnSAFE.Click += btnSAVE_Click;
        // 
        // tbDeptNO
        // 
        tbDeptNO.Location = new System.Drawing.Point(129, 11);
        tbDeptNO.Name = "tbDeptNO";
        tbDeptNO.Size = new System.Drawing.Size(64, 27);
        tbDeptNO.TabIndex = 5;
        // 
        // tbDNAME
        // 
        tbDNAME.Location = new System.Drawing.Point(129, 54);
        tbDNAME.Name = "tbDNAME";
        tbDNAME.Size = new System.Drawing.Size(64, 27);
        tbDNAME.TabIndex = 6;
        tbDNAME.TextChanged += txtDNAME_TextChanged;
        // 
        // tbLOC
        // 
        tbLOC.Location = new System.Drawing.Point(129, 105);
        tbLOC.Name = "tbLOC";
        tbLOC.Size = new System.Drawing.Size(64, 27);
        tbLOC.TabIndex = 7;
        tbLOC.TextChanged += txtLOC_TextChanged;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(16, 11);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(98, 27);
        label1.TabIndex = 8;
        label1.Text = "DEPTNO";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(16, 54);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(98, 27);
        label2.TabIndex = 9;
        label2.Text = "DNAME";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(16, 105);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(98, 27);
        label3.TabIndex = 10;
        label3.Text = "LOC";
        // 
        // Show
        // 
        Show.Location = new System.Drawing.Point(76, 296);
        Show.Name = "Show";
        Show.Size = new System.Drawing.Size(147, 41);
        Show.TabIndex = 11;
        Show.Text = "ShowField";
        Show.UseVisualStyleBackColor = true;
        Show.Click += Show_Click_1;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnCreate);
        panel1.Controls.Add(btnDelete);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(tbLOC);
        panel1.Controls.Add(tbDNAME);
        panel1.Controls.Add(tbDeptNO);
        panel1.Controls.Add(btnSAFE);
        panel1.Controls.Add(textBox1);
        panel1.Location = new System.Drawing.Point(76, 361);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(415, 159);
        panel1.TabIndex = 12;
        panel1.Visible = false;
        // 
        // btnCreate
        // 
        btnCreate.Location = new System.Drawing.Point(199, 105);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new System.Drawing.Size(176, 27);
        btnCreate.TabIndex = 12;
        btnCreate.Text = "CREATE";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new System.Drawing.Point(199, 54);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(176, 27);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "DELETE";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(959, 602);
        Controls.Add(panel1);
        Controls.Add(Show);
        Controls.Add(ListViewDepartments);
        Text = "Form1";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnCreate;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button Show;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnSAFE;
    private System.Windows.Forms.TextBox tbDeptNO;
    private System.Windows.Forms.TextBox tbDNAME;
    private System.Windows.Forms.TextBox tbLOC;

    private System.Windows.Forms.ListView ListViewDepartments;

    #endregion

}

