using System.Text.RegularExpressions;

namespace HardCodingAutoChanger
{
    public class Keyword
    {
        /// <summary>
        /// 텍스트
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 인덱스
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 길이
        /// </summary>
        public int Length { get; set; }

        #region Keyword

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="match">매치</param>
        public Keyword(Match match)
        {
            Text   = match.Value;
            Index  = match.Index + 1;
            Length = match.Length;
        }

        #endregion

        // override
        #region ToString

        /// <summary>
        /// 문자열 구하기
        /// </summary>
        /// <returns>문자열</returns>
        public override string ToString()
        {
            return Text;
        }

        #endregion
    }
}