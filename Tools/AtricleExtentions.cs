using System;
using System.Linq;
using Tools.Models;

namespace Tools
{
    public static class AtricleExtentions
    {
        public static string[] GetSentences(this Article article)
            => article.Text?.Split('.', StringSplitOptions.RemoveEmptyEntries);

        public static string GetFirstSentence(this Article article)
            => GetSentences(article)?.FirstOrDefault()?.Trim();
        public static string GetLastSentence(this Article article)
            => article.GetSentences()?.LastOrDefault()?.Trim();

        public static string GetCapitalTitle(this Article article) => TextTool.ToCapital(article.Title);

        public static bool TitleIsNotEmpty(this Article article) => !string.IsNullOrWhiteSpace(article.Title);
        public static bool TextIsNotEmpty(this Article article) => !string.IsNullOrWhiteSpace(article.Text);
        public static bool HasText(this Article article, string text) => TextTool.FindPosition(article.Text, text) >= 0;
        
        public static bool TryReplaceText(this Article article, string oldText, string newText)
        {
            bool hasText = article.HasText(oldText);
            if (hasText)
                article.Text?.Replace(oldText, newText);
            return hasText;
        }
    }

}
