using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HardCodingAutoChanger
{
    public partial class MainForm : Form
    {
        #region Field

        /// <summary>
        /// 키워드 리스트 딕셔너리
        /// </summary>
        KeywordListDictionary keywordListDictionary = null;

        /// <summary>
        /// 키워드 리스트
        /// </summary>
        /// <remarks>키워드 리스트 박스 데이터를 표시합니다.</remarks>
        List<Keyword> keywordList = null;

        /// <summary>
        /// 이전 키워드
        /// </summary>
        private Keyword currentKeyword = null;

        /// <summary>
        /// 
        /// </summary>
        private  string quote = "\"";

        string subKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion";
        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine;
        
        #endregion

        #region MainForm

        /// <summary>
        /// 생성자
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // RichTextBox 에 검색된 인덱스 표시할 경우 윈도우 10 은 +1 을 해야하고 7은 하지않는다.
            Microsoft.Win32.RegistryKey skey = key.OpenSubKey(subKey);
            string name = skey.GetValue("ProductName").ToString();
            
            if (name.Contains("7"))
            {
                Constant.PlusIndex = 0;
            }

            this.textRichTextBox.Text = @"
using System.Collections.Generic;
 
public class HardCoding
{
    #region Test
 
    /// <summary>
    /// Test
    /// </summary>
    /// <param name=""source1"">소스 1</param>
    /// <param name=""source2"">소스 2</param>
    /// <returns>비교 결과</returns>
    public int Test(string source1, string source2)
    {
        if(source1 == ""DATATYPE"")
        {
            return 0;
        }
        else if(source1 == ""AREATYPE"")
        {
            return 1;
        }
        else if(source2 == ""REGION"")
        {
            // ""REGION"" 일 때 -1 을 반환합니다.
            return -1;
        }
        else if((soruce2 == ""LOCATION_DATA"")
        {
            // ""LOCATION_DATA"" 일 때 -2 를 반환합니다.
            return -2;
        }
    }
 
    #endregion

    #region Test2
 
    /// <summary>
    /// Test
    /// </summary>
    /// <param name=""source1"">소스 1</param>
    /// <param name=""source2"">소스 2</param>
    /// <returns>비교 결과</returns>
    public int Test2(string source1, string source2)
    {
        if(source1 == ""DATATYPE"")
        {
            return 0;
        }
        else if(source1 == ""AREATYPE"")
        {
            return 1;
        }
        else if(source2 == ""REGION"")
        {
            // ""REGION"" 일 때 -1 을 반환합니다.
            return -1;
        }
        else if((soruce2 == ""LOCATION_DATA"")
        {
            // ""LOCATION_DATA"" 일 때 -2 를 반환합니다.
            return -2;
        }
    }
 
    #endregion

}";

            this.searchButton.Click += searchButton_Click;
            this.keywordListBox.SelectedIndexChanged += keywordListBox_SelectedIndexChanged;
            this.deleteItemButton.Click += deleteItemButton_Click;

            this.makeFieldButton.Click += MakeFieldButton_Click;
            this.changeButton.Click += ChangeButton_Click;
            this.keywordListBox.KeyDown += KeywordListBox_KeyDown;
        }
        #endregion

        // Event Method
        #region searchButton_Click

        /// <summary>
        /// 조회 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            #region 정규식을 구한다.

            string regularExpression = this.regularExpressionTextBox.Text.Trim();

            if(string.IsNullOrEmpty(regularExpression))
            {
                MessageBox.Show(this, "정규식을 입력해 주시기 바랍니다.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.regularExpressionTextBox.Focus();

                return;
            }

            #endregion
            #region 텍스트를 구한다.

            string text = this.textRichTextBox.Text.Trim();

            if(string.IsNullOrEmpty(text))
            {
                MessageBox.Show(this, "텍스트를 입력해 주시기 바랍니다.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textRichTextBox.Focus();

                return;
            }

            #endregion
            #region 텍스트 리치 텍스트 박스 데이터 스타일을 지운다.

            this.textRichTextBox.SelectAll();

            this.textRichTextBox.SelectionFont      = this.textRichTextBox.Font;
            this.textRichTextBox.SelectionColor     = this.textRichTextBox.ForeColor;
            this.textRichTextBox.SelectionBackColor = this.textRichTextBox.BackColor;

            this.textRichTextBox.Select(0, 0);

            #endregion
            #region 키워드 리스트 딕셔너리를 설정한다.

            if(this.keywordListDictionary != null)
            {
                this.keywordListDictionary.ClearData();
            }

            this.keywordListDictionary = GetKeywordListDictionary(regularExpression, text);

            #endregion
            #region 키워드 리스트 박스 데이터를 지운다.

            this.keywordListBox.Items.Clear();

            #endregion
            #region 키워드 리스트를 설정한다.

            if(this.keywordList != null)
            {
                this.keywordList.Clear();
            }

            this.keywordList = GetKeywordList(this.keywordListDictionary);

            #endregion
            #region 키워드 리스트 박스 데이터를 추가한다.

            foreach(Keyword keyword in this.keywordList)
            {
                this.keywordListBox.Items.Add(keyword);
            }

            #endregion
            #region 텍스트 리치 텍스트 박스에서 해당 단어를 표시한다.

            foreach(KeyValuePair<string, List<Keyword>> keyValuePair in this.keywordListDictionary)
            {
                List<Keyword> keywordList = keyValuePair.Value;

                foreach(Keyword keyword in keywordList)
                {
                    this.textRichTextBox.Select(keyword.Index, keyword.Length);
 
                    this.textRichTextBox.SelectionColor     = Color.Red;
                    this.textRichTextBox.SelectionBackColor = Color.Yellow;
                }
            }

            #endregion
        }

        #endregion
        #region keywordListBox_SelectedIndexChanged

        /// <summary>
        /// 키워드 리스트 박스 선택 인덱스 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void keywordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.currentKeyword != null)
            {
                this.textRichTextBox.Select(this.currentKeyword.Index, this.currentKeyword.Length);

                this.textRichTextBox.SelectionFont = this.textRichTextBox.Font;
            }

            if (this.keywordListBox.SelectedIndex == -1)
            {
                this.currentKeyword = null;
            }
            else
            {
                Keyword keyword = this.keywordListBox.SelectedItem as Keyword;

                this.textRichTextBox.Select(keyword.Index, keyword.Length);

                this.textRichTextBox.SelectionFont = new Font(this.textRichTextBox.Font, FontStyle.Underline | FontStyle.Bold);

                this.textRichTextBox.ScrollToCaret();

                this.currentKeyword = keyword;
            }
        }

        #endregion
        #region KeywordListBox_KeyDown
        private void KeywordListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.deleteItemButton.PerformClick();
            }
        }
        #endregion
        #region deleteItemButton_Click

        /// <summary>
        /// 항목 삭제 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if(this.keywordListBox.SelectedIndex == -1)
            {
                return;
            }

            Keyword keyword = this.keywordListBox.Items[this.keywordListBox.SelectedIndex] as Keyword;

            this.textRichTextBox.Select(keyword.Index, keyword.Length);
            this.textRichTextBox.SelectionColor     = this.textRichTextBox.ForeColor;
            this.textRichTextBox.SelectionBackColor = this.textRichTextBox.BackColor;

            this.keywordListBox.Items.RemoveAt(this.keywordListBox.SelectedIndex);
            this.keywordList.Remove(keyword);

            this.keywordListDictionary.RemoveItem(keyword);
        }

        #endregion
        #region MakeFieldButton_Click
        private void MakeFieldButton_Click(object sender, EventArgs e)
        {
            if (this.keywordListBox.Items == null || this.keywordListBox.Items.Count == 0) return;

            string csCode = string.Empty;
            List<string> fieldNameList = new List<string>();

            csCode += $@"
public class {this.classNameTextBox.Text}" + @"
{";

            foreach (var item in this.keywordListBox.Items)
            {
                Keyword keyword = item as Keyword;
                string fieldName = $"{this.prefixTextBox.Text}{keyword.Text.Replace(quote, "").Replace("/","")}";

                if (!fieldNameList.Contains(fieldName))
                {
                    csCode += $@"
        /// <summary>
        /// {keyword.Text}
        /// </summary>
        public static readonly string {fieldName} = {keyword.Text};";

                    fieldNameList.Add(fieldName);
                }
            }

            csCode += @"
}";

            Form form = new Form() { Width = 800, Height = 600 };
            form.WindowState = FormWindowState.Normal;
            RichTextBox textBox = new RichTextBox() { Multiline = true, Dock = DockStyle.Fill };
            textBox.Text = csCode;
            textBox.ScrollBars = RichTextBoxScrollBars.Both;
            form.Controls.Add(textBox);
            //form.Select();
            form.Show();

        }
        #endregion
        #region ChangeButton_Click
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (this.keywordListBox.Items == null || this.keywordListBox.Items.Count == 0) return;

            RichTextBox ritchTextBox = new RichTextBox() { Multiline = true, Dock = DockStyle.Fill };
            ritchTextBox.Text = this.textRichTextBox.Text;

            for (int index = this.keywordListBox.Items.Count - 1; index >= 0; index--)
            {
                Keyword keyword = this.keywordListBox.Items[index] as Keyword;
                string fieldName = $"{this.prefixTextBox.Text}{keyword.Text.Replace(quote, "").Replace("/", "")}";
                ritchTextBox.Select(keyword.Index, keyword.Length);
                ritchTextBox.SelectionColor = Color.White;
                ritchTextBox.SelectionBackColor = Color.Black;

                ritchTextBox.SelectedText = $"{this.classNameTextBox.Text}.{fieldName}";

                //ritchTextBox.Text.Insert(ritchTextBox.SelectionStart, $"{this.classNameTextBox.Text}.{this.prefixTextBox.Text}{keyword.Text.Replace(quote, "")}");
            }

            Form form = new Form();
            form.WindowState = FormWindowState.Maximized;
            ritchTextBox.ScrollBars = RichTextBoxScrollBars.Both;
            form.Controls.Add(ritchTextBox);

            form.Show();
        }
        #endregion

        // Method
        #region GetKeywordListDictionary

        /// <summary>
        /// 키워드 리스트 딕셔너리 구하기
        /// </summary>
        /// <param name="regularExpression">정규식</param>
        /// <param name="text">텍스트</param>
        private KeywordListDictionary GetKeywordListDictionary(string regularExpression, string text)
        {
            KeywordListDictionary dictionary = new KeywordListDictionary();

            Regex regex = new Regex(regularExpression);

            MatchCollection matchCollection = regex.Matches(text);

            foreach(Match match in matchCollection)
            {
                Keyword keyword = new Keyword(match);

                if (text.Substring(keyword.Index, keyword.Length + 1).Contains(">")) continue;

                string originalText = keyword.Text.Replace(quote, "");

                if (originalText.Trim().Length == 0) continue;

                if (originalText.Contains(",") || originalText.Contains(":") || originalText.Contains("."))
                {
                    continue;
                }

                dictionary.AddItem(keyword);
            }

            return dictionary;
        }

        #endregion
        #region GetKeywordList

        /// <summary>
        /// 키워드 리스트 구하기
        /// </summary>
        /// <param name="dictionary">딕셔너리</param>
        /// <returns>키워드 리스트</returns>
        private List<Keyword> GetKeywordList(KeywordListDictionary dictionary)
        {
            List<Keyword> targetList = new List<Keyword>();

            foreach(KeyValuePair<string, List<Keyword>> keyValuePair in dictionary)
            {
                List<Keyword> keywordList = keyValuePair.Value;

                foreach(Keyword keyword in keywordList)
                {
                    targetList.Add(keyword);
                }
            }

            targetList = targetList.OrderBy(c => c.Index).ToList();

            return targetList;
        }

        #endregion
        #region ClearKeywordListBoxData

        /// <summary>
        /// 키워드 리스트 박스 데이터 지우기
        /// </summary>
        private void ClearKeywordListBoxData()
        {
            this.keywordListBox.Items.Clear();
        }

        #endregion
    }
}