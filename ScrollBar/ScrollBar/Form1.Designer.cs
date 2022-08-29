namespace ScrollBar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DLLLoadBt = new System.Windows.Forms.Button();
            this.UserCtrlPanel = new System.Windows.Forms.Panel();
            this.UserCtrlBackground = new ScrollBar.UserCtrl();
            this.PropertiesNameList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.DLLOutputValue = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.PropertyBind = new System.Windows.Forms.ComboBox();
            this.PropertyValue = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PropertyBindingTitle = new System.Windows.Forms.TextBox();
            this.PropertityTips = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DLLUnLoadBt = new System.Windows.Forms.Button();
            this.ScrollBarCtrl = new SrollBarControl.LScrollBar();
            this.UserCtrlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DLLLoadBt
            // 
            this.DLLLoadBt.Location = new System.Drawing.Point(408, 461);
            this.DLLLoadBt.Name = "DLLLoadBt";
            this.DLLLoadBt.Size = new System.Drawing.Size(75, 23);
            this.DLLLoadBt.TabIndex = 4;
            this.DLLLoadBt.Text = "LoadDll";
            this.DLLLoadBt.UseVisualStyleBackColor = true;
            this.DLLLoadBt.Click += new System.EventHandler(this.DLLLoadBt_Click);
            // 
            // UserCtrlPanel
            // 
            this.UserCtrlPanel.Controls.Add(this.UserCtrlBackground);
            this.UserCtrlPanel.Location = new System.Drawing.Point(607, 26);
            this.UserCtrlPanel.Name = "UserCtrlPanel";
            this.UserCtrlPanel.Size = new System.Drawing.Size(689, 360);
            this.UserCtrlPanel.TabIndex = 5;
            // 
            // UserCtrlBackground
            // 
            this.UserCtrlBackground.Location = new System.Drawing.Point(0, 0);
            this.UserCtrlBackground.Name = "UserCtrlBackground";
            this.UserCtrlBackground.Size = new System.Drawing.Size(842, 360);
            this.UserCtrlBackground.TabIndex = 0;
            this.UserCtrlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.UserCtrlPanel_Onpaint);
            // 
            // PropertiesNameList
            // 
            this.PropertiesNameList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PropertiesNameList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertiesNameList.Location = new System.Drawing.Point(17, 27);
            this.PropertiesNameList.Multiline = true;
            this.PropertiesNameList.Name = "PropertiesNameList";
            this.PropertiesNameList.Size = new System.Drawing.Size(159, 68);
            this.PropertiesNameList.TabIndex = 6;
            this.PropertiesNameList.Text = "names...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.DLLOutputValue);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.InputValue);
            this.panel1.Controls.Add(this.PropertyBind);
            this.panel1.Controls.Add(this.PropertyValue);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.PropertyBindingTitle);
            this.panel1.Controls.Add(this.PropertityTips);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.PropertiesNameList);
            this.panel1.Location = new System.Drawing.Point(391, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 431);
            this.panel1.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.Location = new System.Drawing.Point(17, 334);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 16);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "DLLOutput:";
            // 
            // DLLOutputValue
            // 
            this.DLLOutputValue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.DLLOutputValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DLLOutputValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DLLOutputValue.Location = new System.Drawing.Point(17, 356);
            this.DLLOutputValue.Name = "DLLOutputValue";
            this.DLLOutputValue.Size = new System.Drawing.Size(159, 23);
            this.DLLOutputValue.TabIndex = 18;
            this.DLLOutputValue.Text = "value…";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Location = new System.Drawing.Point(17, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 16);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Input:";
            // 
            // InputValue
            // 
            this.InputValue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.InputValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InputValue.Location = new System.Drawing.Point(17, 290);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(159, 23);
            this.InputValue.TabIndex = 16;
            this.InputValue.Text = "value…";
            this.InputValue.TextChanged += new System.EventHandler(this.propertyValueChanged);
            // 
            // PropertyBind
            // 
            this.PropertyBind.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PropertyBind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertyBind.FormattingEnabled = true;
            this.PropertyBind.Location = new System.Drawing.Point(17, 238);
            this.PropertyBind.Name = "PropertyBind";
            this.PropertyBind.Size = new System.Drawing.Size(159, 20);
            this.PropertyBind.TabIndex = 15;
            this.PropertyBind.SelectedIndexChanged += new System.EventHandler(this.PropertyBind_SelectedIndexChanged);
            // 
            // PropertyValue
            // 
            this.PropertyValue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PropertyValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PropertyValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertyValue.Location = new System.Drawing.Point(17, 175);
            this.PropertyValue.Name = "PropertyValue";
            this.PropertyValue.Size = new System.Drawing.Size(159, 23);
            this.PropertyValue.TabIndex = 13;
            this.PropertyValue.Text = "value…";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox7.Location = new System.Drawing.Point(17, 153);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 16);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "PorpertyValues:";
            // 
            // PropertyBindingTitle
            // 
            this.PropertyBindingTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PropertyBindingTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyBindingTitle.Font = new System.Drawing.Font("宋体", 10F);
            this.PropertyBindingTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertyBindingTitle.Location = new System.Drawing.Point(17, 216);
            this.PropertyBindingTitle.Name = "PropertyBindingTitle";
            this.PropertyBindingTitle.Size = new System.Drawing.Size(141, 16);
            this.PropertyBindingTitle.TabIndex = 14;
            this.PropertyBindingTitle.Text = "PropertyBind:";
            // 
            // PropertityTips
            // 
            this.PropertityTips.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PropertityTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PropertityTips.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertityTips.Location = new System.Drawing.Point(17, 127);
            this.PropertityTips.Name = "PropertityTips";
            this.PropertityTips.Size = new System.Drawing.Size(159, 23);
            this.PropertityTips.TabIndex = 11;
            this.PropertityTips.Text = "tips…";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(17, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 16);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "PropertyTips:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(17, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 16);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Property_Types:";
            // 
            // DLLUnLoadBt
            // 
            this.DLLUnLoadBt.Location = new System.Drawing.Point(492, 461);
            this.DLLUnLoadBt.Name = "DLLUnLoadBt";
            this.DLLUnLoadBt.Size = new System.Drawing.Size(75, 23);
            this.DLLUnLoadBt.TabIndex = 26;
            this.DLLUnLoadBt.Text = "UnloadDll";
            this.DLLUnLoadBt.UseVisualStyleBackColor = true;
            this.DLLUnLoadBt.Click += new System.EventHandler(this.DLLUnLoadBt_Click);
            // 
            // ScrollBarCtrl
            // 
            this.ScrollBarCtrl.L_BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScrollBarCtrl.L_BarSize = 15;
            this.ScrollBarCtrl.L_CtrlLen = 200F;
            this.ScrollBarCtrl.L_CtrlShowLen = 10F;
            this.ScrollBarCtrl.L_IsRound = true;
            this.ScrollBarCtrl.L_Orientation = SrollBarControl.OrientationScrollBar.Horizontal;
            this.ScrollBarCtrl.L_ScrollInterval = 10F;
            this.ScrollBarCtrl.L_ShowPosition = -10F;
            this.ScrollBarCtrl.L_ShowPositionPercent = -0.05263158F;
            this.ScrollBarCtrl.L_SliderColor = System.Drawing.Color.LimeGreen;
            this.ScrollBarCtrl.L_SliderMiniSize = 20F;
            this.ScrollBarCtrl.L_SliderMouseInColor = System.Drawing.Color.Green;
            this.ScrollBarCtrl.Location = new System.Drawing.Point(607, 411);
            this.ScrollBarCtrl.Name = "ScrollBarCtrl";
            this.ScrollBarCtrl.Size = new System.Drawing.Size(689, 15);
            this.ScrollBarCtrl.TabIndex = 1;
            this.ScrollBarCtrl.Text = "ScrollBarCtrl";
            this.ScrollBarCtrl.Visible = false;
            this.ScrollBarCtrl.LScrolled += new SrollBarControl.LScrollBar.LScrolledEventHandler(this.ScrollBar_LScrolled);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 496);
            this.Controls.Add(this.DLLUnLoadBt);
            this.Controls.Add(this.UserCtrlPanel);
            this.Controls.Add(this.DLLLoadBt);
            this.Controls.Add(this.ScrollBarCtrl);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 39);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_OnDraged);
            this.UserCtrlPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SrollBarControl.LScrollBar ScrollBarCtrl;
        private System.Windows.Forms.Button DLLLoadBt;
        private UserCtrl UserCtrlBackground;
        private System.Windows.Forms.Panel UserCtrlPanel;
        private System.Windows.Forms.TextBox PropertiesNameList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PropertyValue;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox PropertityTips;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DLLUnLoadBt;
        private System.Windows.Forms.TextBox PropertyBindingTitle;
        private System.Windows.Forms.ComboBox PropertyBind;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox InputValue;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox DLLOutputValue;
    }
}

