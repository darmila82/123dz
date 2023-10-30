namespace _123dz
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
            this.Soap_text = new System.Windows.Forms.TextBox();
            this.Shampoo_text = new System.Windows.Forms.TextBox();
            this.Teeth_pasta_text = new System.Windows.Forms.TextBox();
            this.check_create = new System.Windows.Forms.Button();
            this.Balance_text = new System.Windows.Forms.TextBox();
            this.balance_check = new System.Windows.Forms.Button();
            this.Balance_input = new System.Windows.Forms.TextBox();
            this.hide_balance = new System.Windows.Forms.Button();
            this.input_your_balance = new System.Windows.Forms.Label();
            this.balance_input_button = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.But_button = new System.Windows.Forms.Button();
            this.Product_buy_input = new System.Windows.Forms.TextBox();
            this.Product_buy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Soap_text
            // 
            this.Soap_text.Location = new System.Drawing.Point(92, 64);
            this.Soap_text.Multiline = true;
            this.Soap_text.Name = "Soap_text";
            this.Soap_text.ReadOnly = true;
            this.Soap_text.Size = new System.Drawing.Size(109, 20);
            this.Soap_text.TabIndex = 0;
            // 
            // Shampoo_text
            // 
            this.Shampoo_text.Location = new System.Drawing.Point(92, 112);
            this.Shampoo_text.Multiline = true;
            this.Shampoo_text.Name = "Shampoo_text";
            this.Shampoo_text.ReadOnly = true;
            this.Shampoo_text.Size = new System.Drawing.Size(109, 20);
            this.Shampoo_text.TabIndex = 1;
            // 
            // Teeth_pasta_text
            // 
            this.Teeth_pasta_text.Location = new System.Drawing.Point(92, 156);
            this.Teeth_pasta_text.Multiline = true;
            this.Teeth_pasta_text.Name = "Teeth_pasta_text";
            this.Teeth_pasta_text.ReadOnly = true;
            this.Teeth_pasta_text.Size = new System.Drawing.Size(109, 20);
            this.Teeth_pasta_text.TabIndex = 2;
            // 
            // check_create
            // 
            this.check_create.Location = new System.Drawing.Point(92, 282);
            this.check_create.Name = "check_create";
            this.check_create.Size = new System.Drawing.Size(109, 23);
            this.check_create.TabIndex = 3;
            this.check_create.Text = "Перевірити склад";
            this.check_create.UseVisualStyleBackColor = true;
            this.check_create.Click += new System.EventHandler(this.check_create_Click);
            // 
            // Balance_text
            // 
            this.Balance_text.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_text.Location = new System.Drawing.Point(749, 13);
            this.Balance_text.Multiline = true;
            this.Balance_text.Name = "Balance_text";
            this.Balance_text.ReadOnly = true;
            this.Balance_text.Size = new System.Drawing.Size(130, 20);
            this.Balance_text.TabIndex = 4;
            this.Balance_text.Text = "*********************";
            // 
            // balance_check
            // 
            this.balance_check.Location = new System.Drawing.Point(749, 282);
            this.balance_check.Name = "balance_check";
            this.balance_check.Size = new System.Drawing.Size(130, 23);
            this.balance_check.TabIndex = 5;
            this.balance_check.Text = "Перевірити баланс";
            this.balance_check.UseVisualStyleBackColor = true;
            this.balance_check.Click += new System.EventHandler(this.balance_check_Click);
            // 
            // Balance_input
            // 
            this.Balance_input.Location = new System.Drawing.Point(364, 155);
            this.Balance_input.Multiline = true;
            this.Balance_input.Name = "Balance_input";
            this.Balance_input.Size = new System.Drawing.Size(245, 21);
            this.Balance_input.TabIndex = 6;
            this.Balance_input.Visible = false;
            // 
            // hide_balance
            // 
            this.hide_balance.Location = new System.Drawing.Point(749, 311);
            this.hide_balance.Name = "hide_balance";
            this.hide_balance.Size = new System.Drawing.Size(130, 23);
            this.hide_balance.TabIndex = 7;
            this.hide_balance.Text = "Приховати баланс";
            this.hide_balance.UseVisualStyleBackColor = true;
            this.hide_balance.Click += new System.EventHandler(this.hide_balance_Click);
            // 
            // input_your_balance
            // 
            this.input_your_balance.AutoSize = true;
            this.input_your_balance.Location = new System.Drawing.Point(361, 139);
            this.input_your_balance.Name = "input_your_balance";
            this.input_your_balance.Size = new System.Drawing.Size(253, 13);
            this.input_your_balance.TabIndex = 8;
            this.input_your_balance.Text = "Введіть ваш баланс(тільки числа,будь - ласка)    ";
            this.input_your_balance.Visible = false;
            // 
            // balance_input_button
            // 
            this.balance_input_button.Location = new System.Drawing.Point(749, 340);
            this.balance_input_button.Name = "balance_input_button";
            this.balance_input_button.Size = new System.Drawing.Size(130, 23);
            this.balance_input_button.TabIndex = 9;
            this.balance_input_button.Text = "Ввести баланс";
            this.balance_input_button.UseVisualStyleBackColor = true;
            this.balance_input_button.Click += new System.EventHandler(this.balance_input_button_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(416, 182);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(130, 23);
            this.Enter.TabIndex = 10;
            this.Enter.Text = "Ввести баланс";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Visible = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Продукт - ціна за шт.";
            this.label1.Visible = false;
            // 
            // But_button
            // 
            this.But_button.Location = new System.Drawing.Point(416, 340);
            this.But_button.Name = "But_button";
            this.But_button.Size = new System.Drawing.Size(130, 23);
            this.But_button.TabIndex = 12;
            this.But_button.Text = "Купівля";
            this.But_button.UseVisualStyleBackColor = true;
            this.But_button.Click += new System.EventHandler(this.But_button_Click);
            // 
            // Product_buy_input
            // 
            this.Product_buy_input.Location = new System.Drawing.Point(364, 256);
            this.Product_buy_input.Multiline = true;
            this.Product_buy_input.Name = "Product_buy_input";
            this.Product_buy_input.Size = new System.Drawing.Size(245, 21);
            this.Product_buy_input.TabIndex = 13;
            this.Product_buy_input.Visible = false;
            // 
            // Product_buy
            // 
            this.Product_buy.Location = new System.Drawing.Point(320, 195);
            this.Product_buy.Multiline = true;
            this.Product_buy.Name = "Product_buy";
            this.Product_buy.ReadOnly = true;
            this.Product_buy.Size = new System.Drawing.Size(329, 55);
            this.Product_buy.TabIndex = 14;
            this.Product_buy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.Product_buy);
            this.Controls.Add(this.Product_buy_input);
            this.Controls.Add(this.But_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.balance_input_button);
            this.Controls.Add(this.input_your_balance);
            this.Controls.Add(this.hide_balance);
            this.Controls.Add(this.Balance_input);
            this.Controls.Add(this.balance_check);
            this.Controls.Add(this.Balance_text);
            this.Controls.Add(this.check_create);
            this.Controls.Add(this.Teeth_pasta_text);
            this.Controls.Add(this.Shampoo_text);
            this.Controls.Add(this.Soap_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Soap_text;
        private System.Windows.Forms.TextBox Shampoo_text;
        private System.Windows.Forms.TextBox Teeth_pasta_text;
        private System.Windows.Forms.Button check_create;
        private System.Windows.Forms.TextBox Balance_text;
        private System.Windows.Forms.Button balance_check;
        private System.Windows.Forms.TextBox Balance_input;
        private System.Windows.Forms.Button hide_balance;
        private System.Windows.Forms.Label input_your_balance;
        private System.Windows.Forms.Button balance_input_button;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_button;
        private System.Windows.Forms.TextBox Product_buy_input;
        private System.Windows.Forms.TextBox Product_buy;
    }
}

