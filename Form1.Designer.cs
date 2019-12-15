namespace lab04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUnstickTexture = new System.Windows.Forms.Button();
            this.btnStickTexture = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pbShowTexture = new System.Windows.Forms.PictureBox();
            this.tbTexturePath = new System.Windows.Forms.TextBox();
            this.btnOpenTextureFile = new System.Windows.Forms.Button();
            this.lbCamPosZ = new System.Windows.Forms.Label();
            this.lbCamPosY = new System.Windows.Forms.Label();
            this.lbCamPosX = new System.Windows.Forms.Label();
            this.lbCamX = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRotation = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.tbShapeSize1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSetHeight = new System.Windows.Forms.Button();
            this.btnSetLength = new System.Windows.Forms.Button();
            this.tbRotZ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRotY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRotX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosZ = new System.Windows.Forms.TextBox();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbScaleZ = new System.Windows.Forms.TextBox();
            this.tbScaleY = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.tbShapeSize2 = new System.Windows.Forms.TextBox();
            this.lboxObjectsList = new System.Windows.Forms.ListBox();
            this.btnPyramid = new System.Windows.Forms.Button();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.openGLControl = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnstickTexture
            // 
            this.btnUnstickTexture.Location = new System.Drawing.Point(197, 441);
            this.btnUnstickTexture.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnstickTexture.Name = "btnUnstickTexture";
            this.btnUnstickTexture.Size = new System.Drawing.Size(69, 28);
            this.btnUnstickTexture.TabIndex = 126;
            this.btnUnstickTexture.Text = "Unstick";
            this.btnUnstickTexture.UseVisualStyleBackColor = true;
            // 
            // btnStickTexture
            // 
            this.btnStickTexture.Location = new System.Drawing.Point(120, 441);
            this.btnStickTexture.Margin = new System.Windows.Forms.Padding(4);
            this.btnStickTexture.Name = "btnStickTexture";
            this.btnStickTexture.Size = new System.Drawing.Size(69, 28);
            this.btnStickTexture.TabIndex = 125;
            this.btnStickTexture.Text = "Stick";
            this.btnStickTexture.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 420);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 124;
            this.label15.Text = "Texture";
            // 
            // pbShowTexture
            // 
            this.pbShowTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShowTexture.Location = new System.Drawing.Point(12, 509);
            this.pbShowTexture.Margin = new System.Windows.Forms.Padding(4);
            this.pbShowTexture.Name = "pbShowTexture";
            this.pbShowTexture.Size = new System.Drawing.Size(254, 194);
            this.pbShowTexture.TabIndex = 123;
            this.pbShowTexture.TabStop = false;
            // 
            // tbTexturePath
            // 
            this.tbTexturePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTexturePath.Location = new System.Drawing.Point(12, 477);
            this.tbTexturePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbTexturePath.Name = "tbTexturePath";
            this.tbTexturePath.ReadOnly = true;
            this.tbTexturePath.Size = new System.Drawing.Size(253, 22);
            this.tbTexturePath.TabIndex = 122;
            // 
            // btnOpenTextureFile
            // 
            this.btnOpenTextureFile.Location = new System.Drawing.Point(11, 441);
            this.btnOpenTextureFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenTextureFile.Name = "btnOpenTextureFile";
            this.btnOpenTextureFile.Size = new System.Drawing.Size(59, 28);
            this.btnOpenTextureFile.TabIndex = 121;
            this.btnOpenTextureFile.Text = "Open";
            this.btnOpenTextureFile.UseVisualStyleBackColor = true;
            // 
            // lbCamPosZ
            // 
            this.lbCamPosZ.AutoSize = true;
            this.lbCamPosZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosZ.ForeColor = System.Drawing.Color.Blue;
            this.lbCamPosZ.Location = new System.Drawing.Point(1233, 212);
            this.lbCamPosZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamPosZ.Name = "lbCamPosZ";
            this.lbCamPosZ.Size = new System.Drawing.Size(49, 17);
            this.lbCamPosZ.TabIndex = 120;
            this.lbCamPosZ.Text = "0.000";
            this.lbCamPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamPosY
            // 
            this.lbCamPosY.AutoSize = true;
            this.lbCamPosY.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosY.ForeColor = System.Drawing.Color.Lime;
            this.lbCamPosY.Location = new System.Drawing.Point(1233, 181);
            this.lbCamPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamPosY.Name = "lbCamPosY";
            this.lbCamPosY.Size = new System.Drawing.Size(49, 17);
            this.lbCamPosY.TabIndex = 119;
            this.lbCamPosY.Text = "0.000";
            this.lbCamPosY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamPosX
            // 
            this.lbCamPosX.AutoSize = true;
            this.lbCamPosX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosX.ForeColor = System.Drawing.Color.Red;
            this.lbCamPosX.Location = new System.Drawing.Point(1233, 149);
            this.lbCamPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamPosX.Name = "lbCamPosX";
            this.lbCamPosX.Size = new System.Drawing.Size(49, 17);
            this.lbCamPosX.TabIndex = 118;
            this.lbCamPosX.Text = "0.000";
            this.lbCamPosX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamX
            // 
            this.lbCamX.AutoSize = true;
            this.lbCamX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamX.ForeColor = System.Drawing.Color.Red;
            this.lbCamX.Location = new System.Drawing.Point(655, 30);
            this.lbCamX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamX.Name = "lbCamX";
            this.lbCamX.Size = new System.Drawing.Size(0, 17);
            this.lbCamX.TabIndex = 117;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.WindowText;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(1205, 212);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 17);
            this.label18.TabIndex = 116;
            this.label18.Text = "Z :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.WindowText;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(1205, 181);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 17);
            this.label17.TabIndex = 115;
            this.label17.Text = "Y :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.WindowText;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(1205, 149);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 114;
            this.label16.Text = "X :";
            // 
            // btnRotation
            // 
            this.btnRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotation.Image = ((System.Drawing.Image)(resources.GetObject("btnRotation.Image")));
            this.btnRotation.Location = new System.Drawing.Point(799, 79);
            this.btnRotation.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(33, 25);
            this.btnRotation.TabIndex = 113;
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // btnScale
            // 
            this.btnScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScale.Image = ((System.Drawing.Image)(resources.GetObject("btnScale.Image")));
            this.btnScale.Location = new System.Drawing.Point(799, 14);
            this.btnScale.Margin = new System.Windows.Forms.Padding(4);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(33, 25);
            this.btnScale.TabIndex = 112;
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnPosition.Image")));
            this.btnPosition.Location = new System.Drawing.Point(799, 47);
            this.btnPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(33, 25);
            this.btnPosition.TabIndex = 111;
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // tbShapeSize1
            // 
            this.tbShapeSize1.Enabled = false;
            this.tbShapeSize1.Location = new System.Drawing.Point(71, 142);
            this.tbShapeSize1.Margin = new System.Windows.Forms.Padding(4);
            this.tbShapeSize1.Name = "tbShapeSize1";
            this.tbShapeSize1.Size = new System.Drawing.Size(155, 22);
            this.tbShapeSize1.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 192);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 110;
            this.label14.Text = "Height";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 109;
            this.label13.Text = "Length";
            // 
            // btnSetHeight
            // 
            this.btnSetHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetHeight.Image = ((System.Drawing.Image)(resources.GetObject("btnSetHeight.Image")));
            this.btnSetHeight.Location = new System.Drawing.Point(233, 189);
            this.btnSetHeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetHeight.Name = "btnSetHeight";
            this.btnSetHeight.Size = new System.Drawing.Size(33, 25);
            this.btnSetHeight.TabIndex = 108;
            this.btnSetHeight.UseVisualStyleBackColor = true;
            this.btnSetHeight.Click += new System.EventHandler(this.btnSetHeight_Click);
            // 
            // btnSetLength
            // 
            this.btnSetLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetLength.Image = ((System.Drawing.Image)(resources.GetObject("btnSetLength.Image")));
            this.btnSetLength.Location = new System.Drawing.Point(233, 142);
            this.btnSetLength.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetLength.Name = "btnSetLength";
            this.btnSetLength.Size = new System.Drawing.Size(33, 25);
            this.btnSetLength.TabIndex = 107;
            this.btnSetLength.UseVisualStyleBackColor = true;
            this.btnSetLength.Click += new System.EventHandler(this.btnSetLength_Click);
            // 
            // tbRotZ
            // 
            this.tbRotZ.Enabled = false;
            this.tbRotZ.Location = new System.Drawing.Point(695, 79);
            this.tbRotZ.Margin = new System.Windows.Forms.Padding(4);
            this.tbRotZ.Name = "tbRotZ";
            this.tbRotZ.Size = new System.Drawing.Size(95, 22);
            this.tbRotZ.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(668, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 105;
            this.label12.Text = "Z";
            // 
            // tbRotY
            // 
            this.tbRotY.Enabled = false;
            this.tbRotY.Location = new System.Drawing.Point(551, 79);
            this.tbRotY.Margin = new System.Windows.Forms.Padding(4);
            this.tbRotY.Name = "tbRotY";
            this.tbRotY.Size = new System.Drawing.Size(95, 22);
            this.tbRotY.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 83);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 103;
            this.label11.Text = "Y";
            // 
            // tbRotX
            // 
            this.tbRotX.Enabled = false;
            this.tbRotX.Location = new System.Drawing.Point(407, 79);
            this.tbRotX.Margin = new System.Windows.Forms.Padding(4);
            this.tbRotX.Name = "tbRotX";
            this.tbRotX.Size = new System.Drawing.Size(95, 22);
            this.tbRotX.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 101;
            this.label10.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 100;
            this.label9.Text = "Rotation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 99;
            this.label8.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 98;
            this.label7.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "X";
            // 
            // tbPosZ
            // 
            this.tbPosZ.Enabled = false;
            this.tbPosZ.Location = new System.Drawing.Point(695, 47);
            this.tbPosZ.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosZ.Name = "tbPosZ";
            this.tbPosZ.Size = new System.Drawing.Size(95, 22);
            this.tbPosZ.TabIndex = 96;
            // 
            // tbPosY
            // 
            this.tbPosY.Enabled = false;
            this.tbPosY.Location = new System.Drawing.Point(551, 47);
            this.tbPosY.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(95, 22);
            this.tbPosY.TabIndex = 95;
            // 
            // tbPosX
            // 
            this.tbPosX.Enabled = false;
            this.tbPosX.Location = new System.Drawing.Point(407, 47);
            this.tbPosX.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(95, 22);
            this.tbPosX.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "Position";
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.Enabled = false;
            this.tbScaleZ.Location = new System.Drawing.Point(695, 14);
            this.tbScaleZ.Margin = new System.Windows.Forms.Padding(4);
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(95, 22);
            this.tbScaleZ.TabIndex = 92;
            // 
            // tbScaleY
            // 
            this.tbScaleY.Enabled = false;
            this.tbScaleY.Location = new System.Drawing.Point(551, 14);
            this.tbScaleY.Margin = new System.Windows.Forms.Padding(4);
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(95, 22);
            this.tbScaleY.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 89;
            this.label5.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "X";
            // 
            // tbScaleX
            // 
            this.tbScaleX.Enabled = false;
            this.tbScaleX.Location = new System.Drawing.Point(407, 14);
            this.tbScaleX.Margin = new System.Windows.Forms.Padding(4);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(95, 22);
            this.tbScaleX.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Scale";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(176, 14);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(91, 41);
            this.btnChooseColor.TabIndex = 85;
            this.btnChooseColor.Text = "Colors";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // tbShapeSize2
            // 
            this.tbShapeSize2.Enabled = false;
            this.tbShapeSize2.Location = new System.Drawing.Point(71, 189);
            this.tbShapeSize2.Margin = new System.Windows.Forms.Padding(4);
            this.tbShapeSize2.Name = "tbShapeSize2";
            this.tbShapeSize2.Size = new System.Drawing.Size(155, 22);
            this.tbShapeSize2.TabIndex = 84;
            // 
            // lboxObjectsList
            // 
            this.lboxObjectsList.FormattingEnabled = true;
            this.lboxObjectsList.ItemHeight = 16;
            this.lboxObjectsList.Location = new System.Drawing.Point(12, 235);
            this.lboxObjectsList.Margin = new System.Windows.Forms.Padding(4);
            this.lboxObjectsList.Name = "lboxObjectsList";
            this.lboxObjectsList.Size = new System.Drawing.Size(253, 164);
            this.lboxObjectsList.TabIndex = 83;
            this.lboxObjectsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxObjectsList_MouseClick);
            // 
            // btnPyramid
            // 
            this.btnPyramid.FlatAppearance.BorderSize = 0;
            this.btnPyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyramid.Image = ((System.Drawing.Image)(resources.GetObject("btnPyramid.Image")));
            this.btnPyramid.Location = new System.Drawing.Point(59, 14);
            this.btnPyramid.Margin = new System.Windows.Forms.Padding(4);
            this.btnPyramid.Name = "btnPyramid";
            this.btnPyramid.Size = new System.Drawing.Size(44, 41);
            this.btnPyramid.TabIndex = 82;
            this.btnPyramid.UseVisualStyleBackColor = true;
            this.btnPyramid.Click += new System.EventHandler(this.btnPyramid_Click);
            // 
            // btnCylinder
            // 
            this.btnCylinder.FlatAppearance.BorderSize = 0;
            this.btnCylinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCylinder.Image = ((System.Drawing.Image)(resources.GetObject("btnCylinder.Image")));
            this.btnCylinder.Location = new System.Drawing.Point(111, 14);
            this.btnCylinder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(40, 41);
            this.btnCylinder.TabIndex = 81;
            this.btnCylinder.UseVisualStyleBackColor = true;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCube.FlatAppearance.BorderSize = 0;
            this.btnCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCube.Image = ((System.Drawing.Image)(resources.GetObject("btnCube.Image")));
            this.btnCube.Location = new System.Drawing.Point(12, 14);
            this.btnCube.Margin = new System.Windows.Forms.Padding(4);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(39, 41);
            this.btnCube.TabIndex = 80;
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(275, 149);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(5);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1053, 561);
            this.openGLControl.TabIndex = 78;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnUnstickTexture);
            this.Controls.Add(this.btnStickTexture);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pbShowTexture);
            this.Controls.Add(this.tbTexturePath);
            this.Controls.Add(this.btnOpenTextureFile);
            this.Controls.Add(this.lbCamPosZ);
            this.Controls.Add(this.lbCamPosY);
            this.Controls.Add(this.lbCamPosX);
            this.Controls.Add(this.lbCamX);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnScale);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.tbShapeSize1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSetHeight);
            this.Controls.Add(this.btnSetLength);
            this.Controls.Add(this.tbRotZ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRotY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbRotX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPosZ);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbScaleZ);
            this.Controls.Add(this.tbScaleY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbScaleX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.tbShapeSize2);
            this.Controls.Add(this.lboxObjectsList);
            this.Controls.Add(this.btnPyramid);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.openGLControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbShowTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnstickTexture;
        private System.Windows.Forms.Button btnStickTexture;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbShowTexture;
        private System.Windows.Forms.TextBox tbTexturePath;
        private System.Windows.Forms.Button btnOpenTextureFile;
        private System.Windows.Forms.Label lbCamPosZ;
        private System.Windows.Forms.Label lbCamPosY;
        private System.Windows.Forms.Label lbCamPosX;
        private System.Windows.Forms.Label lbCamX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.TextBox tbShapeSize1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSetHeight;
        private System.Windows.Forms.Button btnSetLength;
        private System.Windows.Forms.TextBox tbRotZ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRotY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRotX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPosZ;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbScaleZ;
        private System.Windows.Forms.TextBox tbScaleY;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.TextBox tbShapeSize2;
        private System.Windows.Forms.ListBox lboxObjectsList;
        private System.Windows.Forms.Button btnPyramid;
        private System.Windows.Forms.Button btnCylinder;
        private System.Windows.Forms.Button btnCube;
        private SharpGL.OpenGLControl openGLControl;
    }
}

