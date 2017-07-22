namespace oef1
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.BackColor = System.Drawing.Color.Red;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.Yellow;
            this.lblHello.Location = new System.Drawing.Point(11, 12);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(238, 171);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "label1";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(10, 245);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(172, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 201);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(237, 20);
            this.txtInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 280);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "Oefening1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInput;
    }
}

