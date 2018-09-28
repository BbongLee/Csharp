namespace BaseContainer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계단식배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가로배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.세로배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일fToolStripMenuItem,
            this.창WToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일fToolStripMenuItem
            // 
            this.파일fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새창NToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료XToolStripMenuItem});
            this.파일fToolStripMenuItem.Name = "파일fToolStripMenuItem";
            this.파일fToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일fToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새창NToolStripMenuItem
            // 
            this.새창NToolStripMenuItem.Name = "새창NToolStripMenuItem";
            this.새창NToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.새창NToolStripMenuItem.Text = "새 창(&N)";
            this.새창NToolStripMenuItem.Click += new System.EventHandler(this.새창NToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            // 
            // 창WToolStripMenuItem
            // 
            this.창WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계단식배열ToolStripMenuItem,
            this.가로배열ToolStripMenuItem,
            this.세로배열ToolStripMenuItem});
            this.창WToolStripMenuItem.Name = "창WToolStripMenuItem";
            this.창WToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.창WToolStripMenuItem.Text = "창(&W)";
            // 
            // 계단식배열ToolStripMenuItem
            // 
            this.계단식배열ToolStripMenuItem.Name = "계단식배열ToolStripMenuItem";
            this.계단식배열ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.계단식배열ToolStripMenuItem.Text = "계단식 배열";
            this.계단식배열ToolStripMenuItem.Click += new System.EventHandler(this.계단식배열ToolStripMenuItem_Click);
            // 
            // 가로배열ToolStripMenuItem
            // 
            this.가로배열ToolStripMenuItem.Name = "가로배열ToolStripMenuItem";
            this.가로배열ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.가로배열ToolStripMenuItem.Text = "가로 배열";
            this.가로배열ToolStripMenuItem.Click += new System.EventHandler(this.가로배열ToolStripMenuItem_Click);
            // 
            // 세로배열ToolStripMenuItem
            // 
            this.세로배열ToolStripMenuItem.Name = "세로배열ToolStripMenuItem";
            this.세로배열ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.세로배열ToolStripMenuItem.Text = "세로 배열";
            this.세로배열ToolStripMenuItem.Click += new System.EventHandler(this.세로배열ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계단식배열ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가로배열ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 세로배열ToolStripMenuItem;
    }
}

