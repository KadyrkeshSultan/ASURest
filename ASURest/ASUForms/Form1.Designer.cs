namespace ASUForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDeclarantName = new System.Windows.Forms.TextBox();
            this.textBoxDeclarantAdr = new System.Windows.Forms.TextBox();
            this.textBoxDeclarantPhone = new System.Windows.Forms.TextBox();
            this.textBoxDeclarantIIN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDeclarantID = new System.Windows.Forms.TextBox();
            this.buttonCreateDeclarant = new System.Windows.Forms.Button();
            this.buttonGetDeclarant = new System.Windows.Forms.Button();
            this.buttonPutDeclarant = new System.Windows.Forms.Button();
            this.buttonDeleteDeclarant = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(100, 56);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "admin@asu.kz";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 100);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "asupoverka12345";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(30, 142);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(66, 23);
            this.btnGetToken.TabIndex = 4;
            this.btnGetToken.Text = "GetToken";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(127, 144);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(73, 20);
            this.textBoxToken.TabIndex = 5;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(100, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrl.TabIndex = 6;
            this.textBoxUrl.Text = "https://localhost:5001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Controls.Add(this.buttonDeleteDeclarant);
            this.groupBox1.Controls.Add(this.buttonPutDeclarant);
            this.groupBox1.Controls.Add(this.buttonGetDeclarant);
            this.groupBox1.Controls.Add(this.buttonCreateDeclarant);
            this.groupBox1.Controls.Add(this.textBoxDeclarantID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxDeclarantIIN);
            this.groupBox1.Controls.Add(this.textBoxDeclarantPhone);
            this.groupBox1.Controls.Add(this.textBoxDeclarantAdr);
            this.groupBox1.Controls.Add(this.textBoxDeclarantName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(312, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 189);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DeclarantCtrl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "IIN";
            // 
            // textBoxDeclarantName
            // 
            this.textBoxDeclarantName.Location = new System.Drawing.Point(95, 46);
            this.textBoxDeclarantName.Name = "textBoxDeclarantName";
            this.textBoxDeclarantName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeclarantName.TabIndex = 4;
            // 
            // textBoxDeclarantAdr
            // 
            this.textBoxDeclarantAdr.Location = new System.Drawing.Point(95, 75);
            this.textBoxDeclarantAdr.Name = "textBoxDeclarantAdr";
            this.textBoxDeclarantAdr.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeclarantAdr.TabIndex = 5;
            // 
            // textBoxDeclarantPhone
            // 
            this.textBoxDeclarantPhone.Location = new System.Drawing.Point(95, 105);
            this.textBoxDeclarantPhone.Name = "textBoxDeclarantPhone";
            this.textBoxDeclarantPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeclarantPhone.TabIndex = 6;
            // 
            // textBoxDeclarantIIN
            // 
            this.textBoxDeclarantIIN.Location = new System.Drawing.Point(95, 135);
            this.textBoxDeclarantIIN.Name = "textBoxDeclarantIIN";
            this.textBoxDeclarantIIN.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeclarantIIN.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID";
            // 
            // textBoxDeclarantID
            // 
            this.textBoxDeclarantID.Location = new System.Drawing.Point(95, 12);
            this.textBoxDeclarantID.Name = "textBoxDeclarantID";
            this.textBoxDeclarantID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeclarantID.TabIndex = 9;
            // 
            // buttonCreateDeclarant
            // 
            this.buttonCreateDeclarant.Location = new System.Drawing.Point(216, 10);
            this.buttonCreateDeclarant.Name = "buttonCreateDeclarant";
            this.buttonCreateDeclarant.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDeclarant.TabIndex = 10;
            this.buttonCreateDeclarant.Text = "Create";
            this.buttonCreateDeclarant.UseVisualStyleBackColor = true;
            this.buttonCreateDeclarant.Click += new System.EventHandler(this.buttonCreateDeclarant_Click);
            // 
            // buttonGetDeclarant
            // 
            this.buttonGetDeclarant.Location = new System.Drawing.Point(216, 38);
            this.buttonGetDeclarant.Name = "buttonGetDeclarant";
            this.buttonGetDeclarant.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDeclarant.TabIndex = 11;
            this.buttonGetDeclarant.Text = "GetById";
            this.buttonGetDeclarant.UseVisualStyleBackColor = true;
            this.buttonGetDeclarant.Click += new System.EventHandler(this.buttonGetDeclarant_Click);
            // 
            // buttonPutDeclarant
            // 
            this.buttonPutDeclarant.Location = new System.Drawing.Point(216, 67);
            this.buttonPutDeclarant.Name = "buttonPutDeclarant";
            this.buttonPutDeclarant.Size = new System.Drawing.Size(75, 23);
            this.buttonPutDeclarant.TabIndex = 12;
            this.buttonPutDeclarant.Text = "Update";
            this.buttonPutDeclarant.UseVisualStyleBackColor = true;
            this.buttonPutDeclarant.Click += new System.EventHandler(this.buttonPutDeclarant_Click);
            // 
            // buttonDeleteDeclarant
            // 
            this.buttonDeleteDeclarant.Location = new System.Drawing.Point(216, 96);
            this.buttonDeleteDeclarant.Name = "buttonDeleteDeclarant";
            this.buttonDeleteDeclarant.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDeclarant.TabIndex = 13;
            this.buttonDeleteDeclarant.Text = "Delete";
            this.buttonDeleteDeclarant.UseVisualStyleBackColor = true;
            this.buttonDeleteDeclarant.Click += new System.EventHandler(this.buttonDeleteDeclarant_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(318, 10);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(123, 173);
            this.textBoxResult.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.btnGetToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDeleteDeclarant;
        private System.Windows.Forms.Button buttonPutDeclarant;
        private System.Windows.Forms.Button buttonGetDeclarant;
        private System.Windows.Forms.Button buttonCreateDeclarant;
        private System.Windows.Forms.TextBox textBoxDeclarantID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDeclarantIIN;
        private System.Windows.Forms.TextBox textBoxDeclarantPhone;
        private System.Windows.Forms.TextBox textBoxDeclarantAdr;
        private System.Windows.Forms.TextBox textBoxDeclarantName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

