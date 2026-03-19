namespace WinFormsApp1;

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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        trackBar1 = new System.Windows.Forms.TrackBar();
        label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(73, 152);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(285, 117);
        button1.TabIndex = 0;
        button1.Text = "Metal pipe";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(73, 300);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(285, 117);
        button2.TabIndex = 1;
        button2.Text = "Bruh";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button3.Location = new System.Drawing.Point(435, 152);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(290, 117);
        button3.TabIndex = 1;
        button3.Text = "Apple pay";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button4.Location = new System.Drawing.Point(435, 300);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(290, 117);
        button4.TabIndex = 2;
        button4.Text = "67";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(149, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(555, 52);
        label1.TabIndex = 3;
        label1.Text = "Sound pad ultra max pro 2000";
        // 
        // trackBar1
        // 
        trackBar1.Location = new System.Drawing.Point(285, 101);
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new System.Drawing.Size(236, 45);
        trackBar1.TabIndex = 4;
        trackBar1.Scroll += trackBar1_Scroll;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label2.Location = new System.Drawing.Point(231, 101);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(48, 20);
        label2.TabIndex = 5;
        label2.Text = "Volume";
        label2.Click += label2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label2);
        Controls.Add(trackBar1);
        Controls.Add(label1);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TrackBar trackBar1;

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;

    #endregion
}