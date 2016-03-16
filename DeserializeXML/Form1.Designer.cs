namespace DeserializeXML
{
    partial class XMLSerialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLSerialization));
            this.deserialize_btn = new System.Windows.Forms.Button();
            this.serialize_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deserialize_btn
            // 
            this.deserialize_btn.Location = new System.Drawing.Point(12, 42);
            this.deserialize_btn.Name = "deserialize_btn";
            this.deserialize_btn.Size = new System.Drawing.Size(75, 23);
            this.deserialize_btn.TabIndex = 0;
            this.deserialize_btn.Text = "Deserialize";
            this.deserialize_btn.UseVisualStyleBackColor = true;
            this.deserialize_btn.Click += new System.EventHandler(this.deserialize_btn_Click);
            // 
            // serialize_btn
            // 
            this.serialize_btn.Location = new System.Drawing.Point(134, 42);
            this.serialize_btn.Name = "serialize_btn";
            this.serialize_btn.Size = new System.Drawing.Size(75, 23);
            this.serialize_btn.TabIndex = 1;
            this.serialize_btn.Text = "Serialize";
            this.serialize_btn.UseVisualStyleBackColor = true;
            this.serialize_btn.Click += new System.EventHandler(this.serialize_btn_Click);
            // 
            // XMLSerialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 98);
            this.Controls.Add(this.serialize_btn);
            this.Controls.Add(this.deserialize_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLSerialization";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deserialize_btn;
        private System.Windows.Forms.Button serialize_btn;
    }
}

