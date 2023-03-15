namespace WinFormsExample
{
    internal class textBox1
    {
        private int val;

        public textBox1(int val)
        {
            this.val = val;
        }

        internal class Text
        {
            private int val;
            private string text;

            public Text(int val)
            {
                this.val = val;
            }

            public Text(string text)
            {
                this.text = text;
            }
        }
    }
}