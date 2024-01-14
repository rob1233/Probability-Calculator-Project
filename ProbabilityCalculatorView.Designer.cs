namespace Probability_Calculator
{
    partial class ProbabilityCalculatorView
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
            lblTitle = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResult = new TextBox();
            btnCombined = new Button();
            btnEither = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblErrorMessage = new Label();
            lblError = new Label();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Probability Calculator";
            // 
            // txtA
            // 
            txtA.Location = new Point(40, 139);
            txtA.Name = "txtA";
            txtA.Size = new Size(248, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(43, 180);
            txtB.Name = "txtB";
            txtB.Size = new Size(246, 23);
            txtB.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(224, 304);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(97, 23);
            txtResult.TabIndex = 3;
            // 
            // btnCombined
            // 
            btnCombined.Location = new Point(167, 222);
            btnCombined.Name = "btnCombined";
            btnCombined.Size = new Size(95, 34);
            btnCombined.TabIndex = 4;
            btnCombined.Text = "Combined";
            btnCombined.UseVisualStyleBackColor = true;
            // 
            // btnEither
            // 
            btnEither.Location = new Point(57, 222);
            btnEither.Name = "btnEither";
            btnEither.Size = new Size(95, 34);
            btnEither.TabIndex = 5;
            btnEither.Text = "Either";
            btnEither.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 142);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 183);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 7;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 286);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Result:";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(57, 286);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 15);
            lblErrorMessage.TabIndex = 9;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(40, 275);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 10;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Location = new Point(19, 275);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 15);
            lblErrorMsg.TabIndex = 11;
            lblErrorMsg.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ProbabilityCalculatorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 339);
            Controls.Add(lblErrorMsg);
            Controls.Add(lblError);
            Controls.Add(lblErrorMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEither);
            Controls.Add(btnCombined);
            Controls.Add(txtResult);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblTitle);
            Name = "ProbabilityCalculatorView";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtResult;
        private Button btnCombined;
        private Button btnEither;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblErrorMessage;
        private Label lblError;
        private Label lblErrorMsg;
    }
}