namespace MemorySonic
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			this.btnFree = new System.Windows.Forms.Button();
			this.chkFree = new System.Windows.Forms.CheckBox();
			this.lstLog = new System.Windows.Forms.ListBox();
			this.tmrFree = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnFree
			// 
			this.btnFree.Location = new System.Drawing.Point(12, 12);
			this.btnFree.Name = "btnFree";
			this.btnFree.Size = new System.Drawing.Size(294, 23);
			this.btnFree.TabIndex = 0;
			this.btnFree.Text = "사용하지 않는 메모리 공간 비우기";
			this.btnFree.UseVisualStyleBackColor = true;
			this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
			// 
			// chkFree
			// 
			this.chkFree.AutoSize = true;
			this.chkFree.Location = new System.Drawing.Point(12, 41);
			this.chkFree.Name = "chkFree";
			this.chkFree.Size = new System.Drawing.Size(121, 15);
			this.chkFree.TabIndex = 1;
			this.chkFree.Text = "15분에 한번씩 정리";
			this.chkFree.UseVisualStyleBackColor = true;
			this.chkFree.CheckedChanged += new System.EventHandler(this.chkFree_CheckedChanged);
			// 
			// lstLog
			// 
			this.lstLog.FormattingEnabled = true;
			this.lstLog.ItemHeight = 11;
			this.lstLog.Location = new System.Drawing.Point(12, 62);
			this.lstLog.Name = "lstLog";
			this.lstLog.Size = new System.Drawing.Size(294, 70);
			this.lstLog.TabIndex = 2;
			// 
			// tmrFree
			// 
			this.tmrFree.Interval = 900000;
			this.tmrFree.Tick += new System.EventHandler(this.tmrFree_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 11);
			this.label1.TabIndex = 3;
			this.label1.Text = "※주의 : 잦은 비우기 작업은 시스템을 느리게 합니다.";
			// 
			// Main
			// 
			this.AcceptButton = this.btnFree;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(318, 165);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstLog);
			this.Controls.Add(this.chkFree);
			this.Controls.Add(this.btnFree);
			this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "다람 메모리 클리너";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFree;
		private System.Windows.Forms.CheckBox chkFree;
		private System.Windows.Forms.ListBox lstLog;
		private System.Windows.Forms.Timer tmrFree;
		private System.Windows.Forms.Label label1;
	}
}

