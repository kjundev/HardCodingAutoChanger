using System.Collections.Generic;

namespace HardCodingAutoChanger
{
    public class KeywordListDictionary : Dictionary<string, List<Keyword>>
    {
        #region AddItem(keyword)

        /// <summary>
        /// 항목 추가하기
        /// </summary>
        /// <param name="keyword">키워드</param>
        public void AddItem(Keyword keyword)
        {
            if(ContainsKey(keyword.Text))
            {
                List<Keyword> keywordList = this[keyword.Text];

                keywordList.Add(keyword);
            }
            else
            {
                List<Keyword> keywordList = new List<Keyword>();

                keywordList.Add(keyword);

                Add(keyword.Text, keywordList);
            }
        }

        #endregion
        #region RemoveItem(keyword)

        /// <summary>
        /// 항목 지우기
        /// </summary>
        /// <param name="keyword">키워드</param>
        public void RemoveItem(Keyword keyword)
        {
            if(ContainsKey(keyword.Text))
            {
                List<Keyword> keywordList = this[keyword.Text];

                keywordList.Clear();

                Remove(keyword.Text);
            }            
        }

        #endregion
        #region ClearData()

        /// <summary>
        /// 데이터 지우기
        /// </summary>
        public void ClearData()
        {
            foreach(KeyValuePair<string, List<Keyword>> keyValuePair in this)
            {
                List<Keyword> keywordList = keyValuePair.Value;

                keywordList.Clear();
            }

            Clear();
        }

        #endregion
    }
}