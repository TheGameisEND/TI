using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenKey
{
    public class RSA
    {
        public long P { get; set; }
        public long Q { get; set; }
        public long N { get; set; }
        public long Phi { get; set; }
        public long KO { get; set; } // Открытая экспонента e
        public long KC { get; set; } // Закрытая экспонента d

        // Инициализация параметров
        public bool Initialize(long p, long q, long kc)
        {
            P = p;
            Q = q;
            N = P * Q;
            Phi = (P - 1) * (Q - 1);
            KC = kc;

            // Проверка на взаимную простоту KC и Phi
            if (!MathTools.IsRelativelyPrime(KC, Phi))
            {
                MessageBox.Show("Закрытый ключ KC должен быть взаимно простым с φ(n)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Вычисление открытого ключа KO (e)
            // d * e ≡ 1 (mod Phi)  => e = d^(-1) mod Phi
            KO = MathTools.ModInverse(KC, Phi);

            // Доп. проверка: если KO < 0, приводим к положительному
            if (KO < 0) KO += Phi;

            return true;
        }

        // Шифрование байта
        private ushort EncryptByte(byte data)
        {
            // C = M^KO mod N
            // Так как N может быть большим, используем long
            return (ushort)MathTools.FastExp(data, KO, N);
        }

        // Расшифрование ushort в байт
        private byte DecryptUshort(ushort data)
        {
            // M = C^KC mod N
            return (byte)MathTools.FastExp(data, KC, N);
        }

        // Побайтовое шифрование файла
        public byte[] EncryptData(byte[] srcData)
        {
            if (srcData == null) return null;

            // Результат будет в 2 раза больше по размеру, т.к. байт -> ushort (2 байта)
            byte[] result = new byte[srcData.Length * 2];

            for (int i = 0; i < srcData.Length; i++)
            {
                ushort encryptedValue = EncryptByte(srcData[i]);
                byte[] bytes = BitConverter.GetBytes(encryptedValue);

                result[2 * i] = bytes[0];
                result[2 * i + 1] = bytes[1];
            }

            return result;
        }

        // Расшифрование файла (блоками по 16 бит)
        public byte[] DecryptData(byte[] srcData)
        {
            if (srcData == null || srcData.Length % 2 != 0)
            {
                MessageBox.Show("Файл поврежден или имеет нечетный размер!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            byte[] result = new byte[srcData.Length / 2];

            for (int i = 0; i < result.Length; i++)
            {
                ushort encryptedValue = BitConverter.ToUInt16(srcData, 2 * i);
                result[i] = DecryptUshort(encryptedValue);
            }

            return result;
        }
    }
}