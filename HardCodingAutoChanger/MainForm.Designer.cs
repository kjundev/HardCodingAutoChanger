namespace HardCodingAutoChanger
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.regularExpressionLabel = new System.Windows.Forms.Label();
            this.regularExpressionTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.keywordListBox = new System.Windows.Forms.ListBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.sourcePanel = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.antiPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.makeFieldButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.sourcePanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.antiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textRichTextBox.Location = new System.Drawing.Point(0, 23);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(912, 574);
            this.textRichTextBox.TabIndex = 0;
            this.textRichTextBox.Text = "";
            this.textRichTextBox.WordWrap = false;
            // 
            // regularExpressionLabel
            // 
            this.regularExpressionLabel.Location = new System.Drawing.Point(17, 17);
            this.regularExpressionLabel.Name = "regularExpressionLabel";
            this.regularExpressionLabel.Size = new System.Drawing.Size(60, 23);
            this.regularExpressionLabel.TabIndex = 0;
            this.regularExpressionLabel.Text = "Regex";
            this.regularExpressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regularExpressionTextBox
            // 
            this.regularExpressionTextBox.Location = new System.Drawing.Point(77, 17);
            this.regularExpressionTextBox.Name = "regularExpressionTextBox";
            this.regularExpressionTextBox.Size = new System.Drawing.Size(320, 26);
            this.regularExpressionTextBox.TabIndex = 1;
            this.regularExpressionTextBox.Text = "\"([^\\\\\"]|\\\\\")*\"";
            // 
            // textLabel
            // 
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(912, 23);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Source";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(407, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // keywordListBox
            // 
            this.keywordListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.keywordListBox.FormattingEnabled = true;
            this.keywordListBox.IntegralHeight = false;
            this.keywordListBox.ItemHeight = 18;
            this.keywordListBox.Location = new System.Drawing.Point(0, 0);
            this.keywordListBox.Name = "keywordListBox";
            this.keywordListBox.Size = new System.Drawing.Size(400, 430);
            this.keywordListBox.TabIndex = 5;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(5, 6);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(126, 30);
            this.deleteItemButton.TabIndex = 6;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.regularExpressionLabel);
            this.topPanel.Controls.Add(this.regularExpressionTextBox);
            this.topPanel.Controls.Add(this.searchButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1315, 52);
            this.topPanel.TabIndex = 7;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.sourcePanel);
            this.bottomPanel.Controls.Add(this.splitter2);
            this.bottomPanel.Controls.Add(this.actionPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 52);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1315, 597);
            this.bottomPanel.TabIndex = 8;
            // 
            // sourcePanel
            // 
            this.sourcePanel.Controls.Add(this.textRichTextBox);
            this.sourcePanel.Controls.Add(this.textLabel);
            this.sourcePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePanel.Location = new System.Drawing.Point(3, 0);
            this.sourcePanel.Name = "sourcePanel";
            this.sourcePanel.Size = new System.Drawing.Size(912, 597);
            this.sourcePanel.TabIndex = 7;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 597);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.antiPanel);
            this.actionPanel.Controls.Add(this.splitter1);
            this.actionPanel.Controls.Add(this.keywordListBox);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionPanel.Location = new System.Drawing.Point(915, 0);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(400, 597);
            this.actionPanel.TabIndex = 8;
            // 
            // antiPanel
            // 
            this.antiPanel.Controls.Add(this.label2);
            this.antiPanel.Controls.Add(this.prefixTextBox);
            this.antiPanel.Controls.Add(this.label1);
            this.antiPanel.Controls.Add(this.classNameTextBox);
            this.antiPanel.Controls.Add(this.changeButton);
            this.antiPanel.Controls.Add(this.makeFieldButton);
            this.antiPanel.Controls.Add(this.deleteItemButton);
            this.antiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.antiPanel.Location = new System.Drawing.Point(0, 433);
            this.antiPanel.Name = "antiPanel";
            this.antiPanel.Size = new System.Drawing.Size(400, 164);
            this.antiPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prefix";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(9, 120);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(302, 26);
            this.prefixTextBox.TabIndex = 11;
            this.prefixTextBox.Text = "Test_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Class Name";
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(9, 71);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(302, 26);
            this.classNameTextBox.TabIndex = 9;
            this.classNameTextBox.Text = "TestClass";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(269, 6);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(126, 30);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // makeFieldButton
            // 
            this.makeFieldButton.Location = new System.Drawing.Point(137, 6);
            this.makeFieldButton.Name = "makeFieldButton";
            this.makeFieldButton.Size = new System.Drawing.Size(126, 30);
            this.makeFieldButton.TabIndex = 7;
            this.makeFieldButton.Text = "Make Field";
            this.makeFieldButton.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 430);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(400, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1315, 649);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HardCoding Auto Changer";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.sourcePanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.antiPanel.ResumeLayout(false);
            this.antiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.Label regularExpressionLabel;
        private System.Windows.Forms.TextBox regularExpressionTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox keywordListBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel sourcePanel;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Panel antiPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button makeFieldButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prefixTextBox;
    }
}

