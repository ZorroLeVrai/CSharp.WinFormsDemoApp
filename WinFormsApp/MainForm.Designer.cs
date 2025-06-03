namespace WinFormsApp
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            Options = new Label();
            option1ComboBox = new ComboBox();
            actionButton = new Button();
            label3 = new Label();
            option2ComboBox = new ComboBox();
            loadingLabel = new Label();
            serverButton = new Button();
            label4 = new Label();
            serverComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 18);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Dialog Demo";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(335, 55);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(136, 23);
            nameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 58);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Nom";
            // 
            // Options
            // 
            Options.AutoSize = true;
            Options.Location = new Point(266, 97);
            Options.Name = "Options";
            Options.Size = new Size(58, 15);
            Options.TabIndex = 3;
            Options.Text = "Options 1";
            // 
            // option1ComboBox
            // 
            option1ComboBox.Enabled = false;
            option1ComboBox.FormattingEnabled = true;
            option1ComboBox.Location = new Point(335, 94);
            option1ComboBox.Name = "option1ComboBox";
            option1ComboBox.Size = new Size(136, 23);
            option1ComboBox.TabIndex = 4;
            // 
            // actionButton
            // 
            actionButton.Location = new Point(325, 158);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(154, 38);
            actionButton.TabIndex = 5;
            actionButton.Text = "Action";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 246);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Options 2";
            // 
            // option2ComboBox
            // 
            option2ComboBox.Enabled = false;
            option2ComboBox.FormattingEnabled = true;
            option2ComboBox.Location = new Point(335, 243);
            option2ComboBox.Name = "option2ComboBox";
            option2ComboBox.Size = new Size(136, 23);
            option2ComboBox.TabIndex = 7;
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Location = new Point(374, 213);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(59, 15);
            loadingLabel.TabIndex = 8;
            loadingLabel.Text = "loading ...";
            loadingLabel.Visible = false;
            // 
            // serverButton
            // 
            serverButton.AutoEllipsis = true;
            serverButton.Location = new Point(325, 287);
            serverButton.Name = "serverButton";
            serverButton.Size = new Size(154, 44);
            serverButton.TabIndex = 9;
            serverButton.Text = "Chargement serveur";
            serverButton.UseVisualStyleBackColor = true;
            serverButton.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 375);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 10;
            label4.Text = "Données serveur";
            // 
            // serverComboBox
            // 
            serverComboBox.Enabled = false;
            serverComboBox.FormattingEnabled = true;
            serverComboBox.Location = new Point(330, 369);
            serverComboBox.Name = "serverComboBox";
            serverComboBox.Size = new Size(146, 23);
            serverComboBox.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(serverComboBox);
            Controls.Add(label4);
            Controls.Add(serverButton);
            Controls.Add(loadingLabel);
            Controls.Add(option2ComboBox);
            Controls.Add(label3);
            Controls.Add(actionButton);
            Controls.Add(option1ComboBox);
            Controls.Add(Options);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Async Demo Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private Label label2;
        private Label Options;
        private ComboBox option1ComboBox;
        private Button actionButton;
        private Label label3;
        private ComboBox option2ComboBox;
        private Label loadingLabel;
        private Button serverButton;
        private Label label4;
        private ComboBox serverComboBox;
    }
}
