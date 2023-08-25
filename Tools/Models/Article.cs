namespace Tools.Models
{
    public class Article    // Стаття
    {
        public User Autor { get; set; }
        public User Editor { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public Article() { }
        public Article(User autor) { Autor = autor ?? User.Undefined; }
        public Article(string title, User autor = null) : this(autor) { Title = title; }
        public Article(string title, string text, User autor = null) : this(title, autor) { Text = text; }


        public void UpdateTitle(string title) => Title = title;
        public void UpdateText(string text, User editor = null)
        {
            Text = text;
            Editor = editor ?? User.Undefined;
        }
        public void AppendText(string newText, User editor = null) => UpdateText(Text + newText, editor);
        public void AppendLine(string newText, User editor = null) => AppendText(newText + '\n', editor);

        public bool HasTitle => Title != null;
        public bool HasText => Text != null;

    }

}
