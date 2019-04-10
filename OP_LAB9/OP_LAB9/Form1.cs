using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace OP_LAB9
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string Text;
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if(file.ShowDialog() == DialogResult.OK)
            {
                Text = File.ReadAllText(file.FileName);
            }
            Text = Regex.Replace(Text, @"[^\w\s]", "");


            char[] letters;
            letters = Text.ToCharArray();
            SortedList<char, int> sortedLetters = new SortedList<char, int>();
            int tmp;

            foreach(char letter in letters)
            {               
                if (!sortedLetters.ContainsKey(letter))
                {
                   
                    sortedLetters.Add(letter, 0);
                    
                }
                if (sortedLetters.ContainsKey(letter))
                {
                    tmp = sortedLetters[letter];
                    sortedLetters.Remove(letter);
                    sortedLetters.Add(letter, tmp + 1);
                    tmp = 0;
                }
            }
            
            string[] words;
            words = Text.Split();
            SortedList<string, int> sortedWords = new SortedList<string, int>();

            foreach (string word in words)
            {
                if (!sortedWords.ContainsKey(word))
                {

                    sortedWords.Add(word, 0);

                }
                if (sortedWords.ContainsKey(word))
                {
                    tmp = sortedWords[word];
                    sortedWords.Remove(word);
                    sortedWords.Add(word, tmp + 1);
                    tmp = 0;
                }
            }

            foreach(var el in sortedWords)
            {
                textBox1.Text += el.Key + " : " + el.Value + "\r\n";
            }


        }
        
        public class Letter
        {
            public char symbol;
            public  int amount;

            public Letter(char symbol, int amount)
            {
                this.symbol = symbol;
                this.amount = amount;
            }
        }

        public class Word
        {
            public string body;
            public int amount;

            public Word(string body, int amount)
            {
                this.body = body;
                this.amount = amount;
            }
        }
    }
}
