using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenKey
{
    public partial class fMain : Form
    {
        private Checker _checker;
        private RSA _rsa;
        private Model _model;

        public fMain()
        {
            InitializeComponent();
            _checker = new Checker();
            _rsa = new RSA();
            _model = new Model();

            

            // Начальное состояние
            btnEncryption.Enabled = false;
            btnDecryption.Enabled = false;
        }

        private void btnAcceptP_Click(object sender, EventArgs e)
        {
            // Проверка P
            if (!_checker.IsValidPrime(tbP.Text, "P")) return;

            // Проверка Q (используем cbG.Text для ввода Q)
            if (string.IsNullOrEmpty(tbQ.Text))
            {
                MessageBox.Show("Введите простое число Q!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_checker.IsValidPrime(tbQ.Text, "Q")) return;

            long p = long.Parse(tbP.Text);
            long q = long.Parse(tbQ.Text);

            if (p == q)
            {
                MessageBox.Show("P и Q должны быть разными простыми числами!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long n = p * q;
            long phi = (p - 1) * (q - 1);

            // KC из tbX
            if (!_checker.IsValidKC(tbKC.Text, phi)) return;
            long kc = long.Parse(tbKC.Text);

            if (_rsa.Initialize(p, q, kc))
            {
                lYValue.Text = _rsa.KO.ToString();
                lEilerValue.Text = phi.ToString();

                btnEncryption.Enabled = true;
                btnDecryption.Enabled = true;

                MessageBox.Show($"Параметры вычислены!\n\nP = {p}\nQ = {q}\nМодуль n = {n}\nφ(n) = {phi}\nЗакрытый ключ KC = {kc}\nОткрытый ключ KO = {_rsa.KO}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenSourceFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _model.SourceDataBytes = File.ReadAllBytes(openFileDialog.FileName);
                    tbOpenedFile.Text = string.Join(" ", _model.SourceDataBytes.Select(b => b.ToString()));
                }
                catch
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpenEncryptedFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _model.SourceDataBytes = File.ReadAllBytes(openFileDialog.FileName);

                    var sb = new StringBuilder();
                    for (int i = 0; i < _model.SourceDataBytes.Length; i += 2)
                    {
                        if (i + 1 < _model.SourceDataBytes.Length)
                        {
                            ushort val = BitConverter.ToUInt16(_model.SourceDataBytes, i);
                            sb.Append(val + " ");
                        }
                    }
                    tbOpenedFile.Text = sb.ToString();
                }
                catch
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            if (_model.SourceDataBytes == null)
            {
                MessageBox.Show("Откройте файл для шифрования!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model.ResultDataBytes = _rsa.EncryptData(_model.SourceDataBytes);

            var sb = new StringBuilder();
            for (int i = 0; i < _model.ResultDataBytes.Length; i += 2)
            {
                ushort val = BitConverter.ToUInt16(_model.ResultDataBytes, i);
                sb.Append(val + " ");
            }
            tbResult.Text = sb.ToString();
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            if (_model.SourceDataBytes == null)
            {
                MessageBox.Show("Откройте зашифрованный файл!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model.ResultDataBytes = _rsa.DecryptData(_model.SourceDataBytes);

            if (_model.ResultDataBytes != null)
            {
                tbResult.Text = string.Join(" ", _model.ResultDataBytes.Select(b => b.ToString()));
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (_model.ResultDataBytes == null)
            {
                MessageBox.Show("Нет данных для сохранения!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog.FileName, _model.ResultDataBytes);
                    MessageBox.Show("Файл сохранен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}