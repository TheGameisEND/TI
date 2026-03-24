using Cryptography.En_Decryption.Transposition;
using Cryptography.En_Decryption.Vigener;
using Cryptography.FileUtils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Cryptography.En_Decryption;
using Cryptography.En_Decryption.Transposition;
using Cryptography.En_Decryption.Vigener;

namespace Cryptography {
    public partial class Encryptor : Form {
        private readonly FileManager _textFileManager;
        private readonly FileManager _ciphertextFileManager;

        public Encryptor() {
            InitializeComponent();
            cbLanguage.SelectedIndex = 0;
            cbEncryptMethod.SelectedIndex = 0;
            StartPosition = FormStartPosition.CenterScreen;

            const string filter = @"Text files (*.txt)|*.txt";
            var fileService = new TextFileService();
            _textFileManager = new FileManager(tbInitTextFileName, tbInitText, fileService, filter);
            _ciphertextFileManager = new FileManager(tbCiphertextFileName, tbCiphertext, fileService, filter);
            
            dgvKey.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void butNewInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.Create();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butNewCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.Create();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butOpenInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.Open();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butOpenCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.Open();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butSaveAsInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveAsCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
 
        private void cbEncryptMethod_SelectedIndexChanged(object sender, EventArgs e) {
            cbLanguage.Enabled = true;
            cbLanguage.SelectedIndex = 0;
            
            switch (cbEncryptMethod.SelectedIndex) {
                case 0:  // Transposition - один ключ
                    ShowInputKeyComponents(InputMask.Tb1);
                    break;
                case 1:
                    ShowInputKeyComponents(new[] {InputMask.Tb1}.CreateMask());
                    break;
                case 2: 
                    ShowInputKeyComponents(new[] {InputMask.Dvg, InputMask.LbSize, InputMask.NudSize}.CreateMask());
                    break;
                case 6: 
                    ShowInputKeyComponents(new[] {InputMask.Tb1, InputMask.Tb2, InputMask.Tb3, InputMask.Tb4}.CreateMask());
                    cbLanguage.Enabled = false;
                    break;
                default:
                    ShowInputKeyComponents(InputMask.Tb1);
                    break;
            }
        }
        
        private void ShowInputKeyComponents(InputMask mask) {
            tbKey1.Visible = mask.HasFlag(InputMask.Tb1);
            tbKey2.Visible = mask.HasFlag(InputMask.Tb2);
            tbKey3.Visible = mask.HasFlag(InputMask.Tb3);
            tbKey4.Visible = mask.HasFlag(InputMask.Tb4);
            dgvKey.Visible = mask.HasFlag(InputMask.Dvg);
            lbSize.Visible = mask.HasFlag(InputMask.LbSize);
            nudSize.Visible = mask.HasFlag(InputMask.NudSize);
        }

        private void butEncrypt_Click(object sender, EventArgs e) {
            tbErrors.Text = string.Empty;
            
            try {
                var (cipher, keys) = GetCipher();
                tbCiphertext.Text = cipher.Encrypt(tbInitText.Text, keys);
            }
            catch (ArgumentException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butDecrypt_Click(object sender, EventArgs e) {
            tbErrors.Text = string.Empty;
            
            try {
                var (cipher, keys) = GetCipher();
                tbInitText.Text = cipher.Decrypt(tbCiphertext.Text, keys);
            }
            catch (ArgumentException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private (Cipher cipher, IEnumerable<string> keys) GetCipher()
        {
            Alphabet textAlphabet = GetTextAlphabet();
            switch (cbEncryptMethod.SelectedIndex)
            {
                case 0:  // Transposition Method (столбцовый метод)
                    return (new TranspositionCipher(textAlphabet, textAlphabet), new[] { tbKey1.Text});
                case 1:  // Vigenere Method (Progressive key)
                    return (new VigenerCipher(new ProgressiveKeyFactory(textAlphabet)), new[] { tbKey1.Text });
                default:
                    throw new ArgumentException("Encryption method is not selected.");
            }
        }

        private Alphabet GetTextAlphabet() {
            return cbLanguage.SelectedIndex switch {
                0 => Alphabets.EnAlphabet,
                1 => Alphabets.RuAlphabet,
                _ => throw new ArgumentException("Language is not selected.")
            };
        }

        private readonly Color zero = Color.White;
        private readonly Color one = Color.Aquamarine;
        
        private string GetDvgKey() {
            StringBuilder stringBuilder = new StringBuilder(dgvKey.Rows.Count * dgvKey.Columns.Count);

            for (int i = 0; i < dgvKey.Rows.Count; i++) {
                for (int j = 0; j < dgvKey.Columns.Count; j++) {
                    stringBuilder.Append(dgvKey.Rows[i].Cells[j].Style.BackColor == one ? '1' : '0');
                }
            }

            return stringBuilder.ToString();
        }
        
        private void dgvKey_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            DataGridViewCell cell = dgvKey.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            cell.Style.BackColor = cell.Style.BackColor == one ? zero : one;
            
            dgvKey.ClearSelection();
        }

        
        private void nudSize_ValueChanged(object sender, EventArgs e) {
            int newSize = (int)nudSize.Value;
            dgvKey.RowCount = newSize;
            dgvKey.ColumnCount = newSize;
            
            foreach (DataGridViewColumn column in dgvKey.Columns)
            {
                column.Width = dgvKey.RowTemplate.Height;
            }
        }

        private void lbKey_Click(object sender, EventArgs e)
        {

        }

        private void lbSize_Click(object sender, EventArgs e)
        {

        }

        private void Encryptor_Load(object sender, EventArgs e)
        {

        }
    }
}