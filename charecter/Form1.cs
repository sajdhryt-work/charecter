using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charecter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text == "" || txtInputChar.Text == "")
            {
                MessageBox.Show("فیلد هارا پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int countWord = 0;
                    string text = txtInputText.Text;
                    char character = char.Parse(txtInputChar.Text);

                    string[] word = text.Split(' ');
                    for (int i = 0; i < word.Length; i++)
                    {
                        string wordTemp = word[i];
                        for (int j = 0; j < wordTemp.Length; j++)
                        {
                            if (wordTemp[j] == character)
                            {
                                countWord++;
                                break;
                            }
                        }
                    }

                    MessageBox.Show("count :" + countWord);
                }
                catch
                {
                    MessageBox.Show("در فیلد دوم فقط یک کاراکتر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCharCount_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text == "" || txtInputChar.Text == "")
            {
                MessageBox.Show("فیلد هارا پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int countChar = 0;
                    string text = txtInputText.Text;
                    char character = char.Parse(txtInputChar.Text);

                    for (int j = 0; j < text.Length; j++)
                    {
                        if (text[j] == character)
                        {
                            countChar++;
                        }
                    }

                    MessageBox.Show("count :" + countChar);
                }
                catch
                {
                    MessageBox.Show("در فیلد دوم فقط یک کاراکتر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnWordList_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text == "" || txtInputChar.Text == "")
            {
                MessageBox.Show("فیلد هارا پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string words = "";
                    string text = txtInputText.Text;
                    char character = char.Parse(txtInputChar.Text);

                    string[] word = text.Split(' ');
                    for (int i = 0; i < word.Length; i++)
                    {
                        string wordTemp = word[i];
                        for (int j = 0; j < wordTemp.Length; j++)
                        {
                            if (wordTemp[j] == character)
                            {
                                words += wordTemp + " ";
                                break;
                            }
                        }
                    }
                    MessageBox.Show("words :" + words);
                }
                catch 
                {
                    MessageBox.Show("در فیلد دوم فقط یک کاراکتر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
