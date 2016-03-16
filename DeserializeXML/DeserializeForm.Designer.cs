namespace DeserializeXML
{
    partial class DeserializeForm
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
            this.xmlDocLoc_txtBox = new System.Windows.Forms.TextBox();
            this.XMLDocumentLabel = new System.Windows.Forms.Label();
            this.xmlDocLoc_btn = new System.Windows.Forms.Button();
            this.gdbToSaveToLbl = new System.Windows.Forms.Label();
            this.gdbToSaveToTxtBox = new System.Windows.Forms.TextBox();
            this.gdbloc_btn = new System.Windows.Forms.Button();
            this.fcNameLbl = new System.Windows.Forms.Label();
            this.featureClass_txtbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.status_txtBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xmlDocLoc_txtBox
            // 
            this.xmlDocLoc_txtBox.Location = new System.Drawing.Point(15, 35);
            this.xmlDocLoc_txtBox.Name = "xmlDocLoc_txtBox";
            this.xmlDocLoc_txtBox.ReadOnly = true;
            this.xmlDocLoc_txtBox.Size = new System.Drawing.Size(464, 20);
            this.xmlDocLoc_txtBox.TabIndex = 0;
            // 
            // XMLDocumentLabel
            // 
            this.XMLDocumentLabel.AutoSize = true;
            this.XMLDocumentLabel.Location = new System.Drawing.Point(12, 19);
            this.XMLDocumentLabel.Name = "XMLDocumentLabel";
            this.XMLDocumentLabel.Size = new System.Drawing.Size(128, 13);
            this.XMLDocumentLabel.TabIndex = 1;
            this.XMLDocumentLabel.Text = "XML Document Location:";
            // 
            // xmlDocLoc_btn
            // 
            this.xmlDocLoc_btn.Location = new System.Drawing.Point(485, 33);
            this.xmlDocLoc_btn.Name = "xmlDocLoc_btn";
            this.xmlDocLoc_btn.Size = new System.Drawing.Size(113, 23);
            this.xmlDocLoc_btn.TabIndex = 2;
            this.xmlDocLoc_btn.Text = "Find XML Document";
            this.xmlDocLoc_btn.UseVisualStyleBackColor = true;
            this.xmlDocLoc_btn.Click += new System.EventHandler(this.xmlDocLoc_btn_Click);
            // 
            // gdbToSaveToLbl
            // 
            this.gdbToSaveToLbl.AutoSize = true;
            this.gdbToSaveToLbl.Location = new System.Drawing.Point(15, 79);
            this.gdbToSaveToLbl.Name = "gdbToSaveToLbl";
            this.gdbToSaveToLbl.Size = new System.Drawing.Size(89, 13);
            this.gdbToSaveToLbl.TabIndex = 3;
            this.gdbToSaveToLbl.Text = "GDB to Save To:";
            // 
            // gdbToSaveToTxtBox
            // 
            this.gdbToSaveToTxtBox.Location = new System.Drawing.Point(15, 96);
            this.gdbToSaveToTxtBox.Name = "gdbToSaveToTxtBox";
            this.gdbToSaveToTxtBox.ReadOnly = true;
            this.gdbToSaveToTxtBox.Size = new System.Drawing.Size(464, 20);
            this.gdbToSaveToTxtBox.TabIndex = 4;
            // 
            // gdbloc_btn
            // 
            this.gdbloc_btn.Location = new System.Drawing.Point(486, 92);
            this.gdbloc_btn.Name = "gdbloc_btn";
            this.gdbloc_btn.Size = new System.Drawing.Size(112, 23);
            this.gdbloc_btn.TabIndex = 5;
            this.gdbloc_btn.Text = "Find GDB";
            this.gdbloc_btn.UseVisualStyleBackColor = true;
            this.gdbloc_btn.Click += new System.EventHandler(this.gdbloc_btn_Click);
            // 
            // fcNameLbl
            // 
            this.fcNameLbl.AutoSize = true;
            this.fcNameLbl.Location = new System.Drawing.Point(15, 137);
            this.fcNameLbl.Name = "fcNameLbl";
            this.fcNameLbl.Size = new System.Drawing.Size(133, 13);
            this.fcNameLbl.TabIndex = 6;
            this.fcNameLbl.Text = "Feature Class Save Name:";
            // 
            // featureClass_txtbox
            // 
            this.featureClass_txtbox.Location = new System.Drawing.Point(18, 154);
            this.featureClass_txtbox.Name = "featureClass_txtbox";
            this.featureClass_txtbox.Size = new System.Drawing.Size(461, 20);
            this.featureClass_txtbox.TabIndex = 7;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(487, 207);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(112, 23);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status:";
            // 
            // status_txtBox
            // 
            this.status_txtBox.Location = new System.Drawing.Point(21, 209);
            this.status_txtBox.Name = "status_txtBox";
            this.status_txtBox.Size = new System.Drawing.Size(458, 20);
            this.status_txtBox.TabIndex = 10;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(268, 252);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Close Form";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // DeserializeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 298);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.status_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.featureClass_txtbox);
            this.Controls.Add(this.fcNameLbl);
            this.Controls.Add(this.gdbloc_btn);
            this.Controls.Add(this.gdbToSaveToTxtBox);
            this.Controls.Add(this.gdbToSaveToLbl);
            this.Controls.Add(this.xmlDocLoc_btn);
            this.Controls.Add(this.XMLDocumentLabel);
            this.Controls.Add(this.xmlDocLoc_txtBox);
            this.Name = "DeserializeForm";
            this.Text = "DeserializeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xmlDocLoc_txtBox;
        private System.Windows.Forms.Label XMLDocumentLabel;
        private System.Windows.Forms.Button xmlDocLoc_btn;
        private System.Windows.Forms.Label gdbToSaveToLbl;
        private System.Windows.Forms.TextBox gdbToSaveToTxtBox;
        private System.Windows.Forms.Button gdbloc_btn;
        private System.Windows.Forms.Label fcNameLbl;
        private System.Windows.Forms.TextBox featureClass_txtbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox status_txtBox;
        private System.Windows.Forms.Button exitBtn;
    }
}