using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Client
{
    class JAFTCipher
    {
        class CipherKey
        {
            public char[] key;
            public CipherKey()
            {
                key = new char[16];
            }
        }

        //Rijndael Sbox
        private char[] sBox = new char[]    {  (char)0x63, (char)0x7C, (char)0x77, (char)0x7B, (char)0xF2, (char)0x6B, (char)0x6F, (char)0xC5, (char)0x30, (char)0x01, (char)0x67, (char)0x2B, (char)0xFE, (char)0xD7, (char)0xAB, (char)0x76,
                                               (char)0xCA, (char)0x82, (char)0xC9, (char)0x7D, (char)0xFA, (char)0x59, (char)0x47, (char)0xF0, (char)0xAD, (char)0xD4, (char)0xA2, (char)0xAF, (char)0x9C, (char)0xA4, (char)0x72, (char)0xC0,
                                               (char)0xB7, (char)0xFD, (char)0x93, (char)0x26, (char)0x36, (char)0x3F, (char)0xF7, (char)0xCC, (char)0x34, (char)0xA5, (char)0xE5, (char)0xF1, (char)0x71, (char)0xD8, (char)0x31, (char)0x15,
                                               (char)0x04, (char)0xC7, (char)0x23, (char)0xC3, (char)0x18, (char)0x96, (char)0x05, (char)0x9A, (char)0x07, (char)0x12, (char)0x80, (char)0xE2, (char)0xEB, (char)0x27, (char)0xB2, (char)0x75,
                                               (char)0x09, (char)0x83, (char)0x2C, (char)0x1A, (char)0x1B, (char)0x6E, (char)0x5A, (char)0xA0, (char)0x52, (char)0x3B, (char)0xD6, (char)0xB3, (char)0x29, (char)0xE3, (char)0x2F, (char)0x84,
                                               (char)0x53, (char)0xD1, (char)0x00, (char)0xED, (char)0x20, (char)0xFC, (char)0xB1, (char)0x5B, (char)0x6A, (char)0xCB, (char)0xBE, (char)0x39, (char)0x4A, (char)0x4C, (char)0x58, (char)0xCF,
                                               (char)0xD0, (char)0xEF, (char)0xAA, (char)0xFB, (char)0x43, (char)0x4D, (char)0x33, (char)0x85, (char)0x45, (char)0xF9, (char)0x02, (char)0x7F, (char)0x50, (char)0x3C, (char)0x9F, (char)0xA8,
                                               (char)0x51, (char)0xA3, (char)0x40, (char)0x8F, (char)0x92, (char)0x9D, (char)0x38, (char)0xF5, (char)0xBC, (char)0xB6, (char)0xDA, (char)0x21, (char)0x10, (char)0xFF, (char)0xF3, (char)0xD2,
                                               (char)0xCD, (char)0x0C, (char)0x13, (char)0xEC, (char)0x5F, (char)0x97, (char)0x44, (char)0x17, (char)0xC4, (char)0xA7, (char)0x7E, (char)0x3D, (char)0x64, (char)0x5D, (char)0x19, (char)0x73,
                                               (char)0x60, (char)0x81, (char)0x4F, (char)0xDC, (char)0x22, (char)0x2A, (char)0x90, (char)0x88, (char)0x46, (char)0xEE, (char)0xB8, (char)0x14, (char)0xDE, (char)0x5E, (char)0x0B, (char)0xDB,
                                               (char)0xE0, (char)0x32, (char)0x3A, (char)0x0A, (char)0x49, (char)0x06, (char)0x24, (char)0x5C, (char)0xC2, (char)0xD3, (char)0xAC, (char)0x62, (char)0x91, (char)0x95, (char)0xE4, (char)0x79,
                                               (char)0xE7, (char)0xC8, (char)0x37, (char)0x6D, (char)0x8D, (char)0xD5, (char)0x4E, (char)0xA9, (char)0x6C, (char)0x56, (char)0xF4, (char)0xEA, (char)0x65, (char)0x7A, (char)0xAE, (char)0x08,
                                               (char)0xBA, (char)0x78, (char)0x25, (char)0x2E, (char)0x1C, (char)0xA6, (char)0xB4, (char)0xC6, (char)0xE8, (char)0xDD, (char)0x74, (char)0x1F, (char)0x4B, (char)0xBD, (char)0x8B, (char)0x8A,
                                               (char)0x70, (char)0x3E, (char)0xB5, (char)0x66, (char)0x48, (char)0x03, (char)0xF6, (char)0x0E, (char)0x61, (char)0x35, (char)0x57, (char)0xB9, (char)0x86, (char)0xC1, (char)0x1D, (char)0x9E,
                                               (char)0xE1, (char)0xF8, (char)0x98, (char)0x11, (char)0x69, (char)0xD9, (char)0x8E, (char)0x94, (char)0x9B, (char)0x1E, (char)0x87, (char)0xE9, (char)0xCE, (char)0x55, (char)0x28, (char)0xDF,
                                               (char)0x8C, (char)0xA1, (char)0x89, (char)0x0D, (char)0xBF, (char)0xE6, (char)0x42, (char)0x68, (char)0x41, (char)0x99, (char)0x2D, (char)0x0F, (char)0xB0, (char)0x54, (char)0xBB, (char)0x16 };
        private String plainTeks;
        private char[] blockTeks = new char[16];
        private String jaftKey;
        private CipherKey[] blockKey = new CipherKey[7];

        private int shiftKey1, shiftKey7;

        // setter untuk plainteks dan key
        public void setPlainTeks(String teks)
        {
            plainTeks = teks;
        }

        public void setKey(String key)
        {
            jaftKey = key;

            // generate all the key
            generateKey(key);
        }

        private void generateKey(String key)
        {
            shiftKey1 = (int)jaftKey[0];

            for (int i = 0; i < blockKey[0].key.Length; i++)
            {
                if (i < key.Length) blockKey[0].key[i] = key[i];
                else blockKey[0].key[i] = ' ';
            }

            for (int i = 1; i < 7; i++)
            {
                blockKey[i] = new CipherKey();
                roundKey(i);
            }

            shiftKey7 = (int)blockKey[6].key[3];
        }

        // generate round key
        private void roundKey(int i)
        {
            char temp1, temp2;

            for (int j = 0; j < blockKey[i].key.Length; j += 4)
            {
                temp1 = (char)(blockKey[i-1].key[j] ^ blockKey[i-1].key[j + 3]);
                for (int k = 0; k < (j + 3); k++)
                {
                    temp2 = blockKey[i-1].key[k];
                    blockKey[i].key[k] = blockKey[i-1].key[k + 1];
                    blockKey[i].key[k + 1] = temp2;
                }
            }
        }

        // shift cell the block for encryption
        private void shiftCellForEncrypt(int shift)
        {
            int x = (shift % 15) + 1;
            char temp;

            for (int i = 0; i < x; i++)
            {
                for (int j = (blockTeks.Length - 1); j > 0; j--)
                {
                    temp = blockTeks[j];
                    blockTeks[j] = blockTeks[j - 1];
                    blockTeks[j - 1] = temp;
                }
            }
        }

        // shift cell the block for decryption
        private void shiftCellForDecrypt(int shift)
        {
            int x = (shift % 15) + 1;
            char temp;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < (blockTeks.Length - 1); j++)
                {
                    temp = blockTeks[j];
                    blockTeks[j] = blockTeks[j + 1];
                    blockTeks[j + 1] = temp;
                }
            }
        }

        // subtitute block from sBox for encryption
        private void subSBoxForEncrypt()
        {
            for (int i = 0; i < blockTeks.Length; i++)
            {
                char temp = blockTeks[i];
                blockTeks[i] = sBox[temp];
            }
        }

        // subtitute block from sBox for decryption
        private void subSBoxForDecrypt()
        {
            for (int i = 0; i < blockTeks.Length; i++)
            {
                char temp = blockTeks[i];
                int lok = findIndinSBox(temp);
                blockTeks[i] = (char)lok;
            }
        }

        // find x in sBox
        private int findIndinSBox(char x)
        {
            int lok = 0;
            bool found = false;
            int j = 0;

            while (!found)
            {
                if (sBox[j] == x)
                {
                    found = true;
                    lok = j;
                }
                j++;
            }

            return lok;
        }

        // shift the block's row for encryption
        private void shiftRowForEncrypt()
        {
            for (int i = 0; i < blockTeks.Length; i += 4)
            {
                char temp1, temp2, temp3, temp4;
                switch (i)
                {
                    // row 1 no shift
                    case 0: break;
                    // row 2 has 1 shift
                    case 4:
                        {
                            temp1 = blockTeks[4];
                            temp2 = blockTeks[5];
                            temp3 = blockTeks[6];
                            temp4 = blockTeks[7];
                            blockTeks[4] = temp4;
                            blockTeks[5] = temp1;
                            blockTeks[6] = temp2;
                            blockTeks[7] = temp3;
                        }
                        break;
                    // ros 3 has 2 shift
                    case 8:
                        {
                            temp1 = blockTeks[8];
                            temp2 = blockTeks[9];
                            temp3 = blockTeks[10];
                            temp4 = blockTeks[11];
                            blockTeks[8] = temp3;
                            blockTeks[9] = temp4;
                            blockTeks[10] = temp1;
                            blockTeks[11] = temp2;
                        }
                        break;
                    // row 4 has 3 shift
                    case 12:
                        {
                            temp1 = blockTeks[12];
                            temp2 = blockTeks[13];
                            temp3 = blockTeks[14];
                            temp4 = blockTeks[15];
                            blockTeks[12] = temp2;
                            blockTeks[13] = temp3;
                            blockTeks[14] = temp4;
                            blockTeks[15] = temp1;
                        }
                        break;
                }
            }
        }

        // shift the block's row for decryption
        private void shiftRowForDecrypt()
        {
            for (int i = 0; i < blockTeks.Length; i += 4)
            {
                char temp1, temp2, temp3, temp4;
                switch (i)
                {
                    // row 1 no shift
                    case 0: break;
                    // row 2 has 1 shift
                    case 4:
                        {
                            temp1 = blockTeks[4];
                            temp2 = blockTeks[5];
                            temp3 = blockTeks[6];
                            temp4 = blockTeks[7];
                            blockTeks[4] = temp2;
                            blockTeks[5] = temp3;
                            blockTeks[6] = temp4;
                            blockTeks[7] = temp1;
                        }
                        break;
                    // ros 3 has 2 shift
                    case 8:
                        {
                            temp1 = blockTeks[8];
                            temp2 = blockTeks[9];
                            temp3 = blockTeks[10];
                            temp4 = blockTeks[11];
                            blockTeks[8] = temp3;
                            blockTeks[9] = temp4;
                            blockTeks[10] = temp1;
                            blockTeks[11] = temp2;
                        }
                        break;
                    // row 4 has 3 shift
                    case 12:
                        {
                            temp1 = blockTeks[12];
                            temp2 = blockTeks[13];
                            temp3 = blockTeks[14];
                            temp4 = blockTeks[15];
                            blockTeks[12] = temp4;
                            blockTeks[13] = temp1;
                            blockTeks[14] = temp2;
                            blockTeks[15] = temp3;
                        }
                        break;
                }
            }
        }

        // adding round key to plainteks
        private void addRoundKey(int n)
        {
            for (int i = 0; i < blockTeks.Length; i++)
            {
                char temp = blockTeks[i];
                blockTeks[i] = (char)(temp ^ blockKey[n].key[i]);
            }
        }

        // Feistell for encryption
        private void feistellForEncrypt()
        {
            blockTeks[2] = sBox[blockTeks[2]];
            blockTeks[3] = sBox[blockTeks[3]];
            blockTeks[6] = sBox[blockTeks[6]];
            blockTeks[7] = sBox[blockTeks[7]];
            blockTeks[10] = sBox[blockTeks[10]];
            blockTeks[11] = sBox[blockTeks[11]];
            blockTeks[14] = sBox[blockTeks[14]];
            blockTeks[15] = sBox[blockTeks[15]];

            blockTeks[0] = (char)(blockTeks[0] ^ blockTeks[2]);
            blockTeks[1] = (char)(blockTeks[1] ^ blockTeks[3]);
            blockTeks[4] = (char)(blockTeks[4] ^ blockTeks[6]);
            blockTeks[5] = (char)(blockTeks[5] ^ blockTeks[7]);
            blockTeks[8] = (char)(blockTeks[8] ^ blockTeks[10]);
            blockTeks[9] = (char)(blockTeks[9] ^ blockTeks[11]);
            blockTeks[12] = (char)(blockTeks[12] ^ blockTeks[14]);
            blockTeks[13] = (char)(blockTeks[13] ^ blockTeks[15]);

            blockTeks[0] = sBox[blockTeks[0]];
            blockTeks[1] = sBox[blockTeks[1]];
            blockTeks[4] = sBox[blockTeks[4]];
            blockTeks[5] = sBox[blockTeks[5]];
            blockTeks[8] = sBox[blockTeks[8]];
            blockTeks[9] = sBox[blockTeks[9]];
            blockTeks[12] = sBox[blockTeks[12]];
            blockTeks[13] = sBox[blockTeks[13]];

            blockTeks[2] = (char)(blockTeks[2] ^ blockTeks[0]);
            blockTeks[3] = (char)(blockTeks[3] ^ blockTeks[1]);
            blockTeks[6] = (char)(blockTeks[6] ^ blockTeks[4]);
            blockTeks[7] = (char)(blockTeks[7] ^ blockTeks[5]);
            blockTeks[10] = (char)(blockTeks[10] ^ blockTeks[8]);
            blockTeks[11] = (char)(blockTeks[11] ^ blockTeks[9]);
            blockTeks[14] = (char)(blockTeks[14] ^ blockTeks[12]);
            blockTeks[15] = (char)(blockTeks[15] ^ blockTeks[13]);
        }

        // Feistell for decryption
        private void feistellForDecrypt()
        {
            blockTeks[0] = (char)findIndinSBox(blockTeks[0]);
            blockTeks[1] = (char)findIndinSBox(blockTeks[1]);
            blockTeks[4] = (char)findIndinSBox(blockTeks[4]);
            blockTeks[5] = (char)findIndinSBox(blockTeks[5]);
            blockTeks[8] = (char)findIndinSBox(blockTeks[8]);
            blockTeks[9] = (char)findIndinSBox(blockTeks[9]);
            blockTeks[12] = (char)findIndinSBox(blockTeks[12]);
            blockTeks[13] = (char)findIndinSBox(blockTeks[13]);

            blockTeks[2] = (char)(blockTeks[2] ^ blockTeks[0]);
            blockTeks[3] = (char)(blockTeks[3] ^ blockTeks[1]);
            blockTeks[6] = (char)(blockTeks[6] ^ blockTeks[4]);
            blockTeks[7] = (char)(blockTeks[7] ^ blockTeks[5]);
            blockTeks[10] = (char)(blockTeks[10] ^ blockTeks[8]);
            blockTeks[11] = (char)(blockTeks[11] ^ blockTeks[9]);
            blockTeks[14] = (char)(blockTeks[14] ^ blockTeks[12]);
            blockTeks[15] = (char)(blockTeks[15] ^ blockTeks[13]);

            blockTeks[2] = (char)findIndinSBox(blockTeks[2]);
            blockTeks[3] = (char)findIndinSBox(blockTeks[3]);
            blockTeks[6] = (char)findIndinSBox(blockTeks[6]);
            blockTeks[7] = (char)findIndinSBox(blockTeks[7]);
            blockTeks[10] = (char)findIndinSBox(blockTeks[10]);
            blockTeks[11] = (char)findIndinSBox(blockTeks[11]);
            blockTeks[14] = (char)findIndinSBox(blockTeks[14]);
            blockTeks[15] = (char)findIndinSBox(blockTeks[15]);

            blockTeks[0] = (char)(blockTeks[0] ^ blockTeks[2]);
            blockTeks[1] = (char)(blockTeks[1] ^ blockTeks[3]);
            blockTeks[4] = (char)(blockTeks[4] ^ blockTeks[6]);
            blockTeks[5] = (char)(blockTeks[5] ^ blockTeks[7]);
            blockTeks[8] = (char)(blockTeks[8] ^ blockTeks[10]);
            blockTeks[9] = (char)(blockTeks[9] ^ blockTeks[11]);
            blockTeks[12] = (char)(blockTeks[12] ^ blockTeks[14]);
            blockTeks[13] = (char)(blockTeks[13] ^ blockTeks[15]);
        }

        // encryption of the cipher
        public String encrypt()
        {
            String result = "";

            int i = 0;
            int counter = 0;
            int count;
            if (plainTeks.Length % 16 == 0)
            {
                count = plainTeks.Length / 16;
            }
            else
            {
                count = plainTeks.Length / 16 + 1;
            }

            while (i < count)
            {
                // set plainteks to blockteks
                for (int j = 0; j < blockTeks.Length; j++)
                {
                    if (counter < plainTeks.Length)
                    {
                        blockTeks[j] = plainTeks[counter]; counter++;
                    }
                    else blockTeks[j] = ' ';
                }

                // shift cell
                shiftCellForEncrypt(shiftKey1);

                // add with round key
                addRoundKey(0);

                int a = 0;
                while (a < 7) // loop for the cipher
                {
                    subSBoxForEncrypt();
                    shiftRowForEncrypt();
                    addRoundKey(a);
                    a++;
                }

                // shift cell
                shiftCellForEncrypt(shiftKey7);

                // do the feistell
                feistellForEncrypt();

                String temp = new String(blockTeks);
                result += temp;
                i++;
            }

            return result;
        }

        public String decrypt(String cipher)
        {
            String result = "";

            int i = 0;
            int counter = 0;
            int count;
            if (plainTeks.Length % 16 == 0)
            {
                count = plainTeks.Length / 16;
            }
            else
            {
                count = plainTeks.Length / 16 + 1;
            }

            plainTeks = cipher;

            while (i < count)
            {
                // set cipher to plainteks
                for (int j = 0; j < blockTeks.Length; j++)
                {
                    if (counter < plainTeks.Length)
                    {
                        blockTeks[j] = plainTeks[counter]; counter++;
                    }
                    else blockTeks[j] = ' ';
                }

                // do feistell for decrypt
                feistellForDecrypt();

                // shift cell
                shiftCellForDecrypt(shiftKey7);

                int a = 6;
                while (a >= 0) // loop for the decrypt
                {
                    addRoundKey(a);
                    shiftRowForDecrypt();
                    subSBoxForDecrypt();
                    a--;
                }

                // add with round key
                addRoundKey(0);

                // shift cell
                shiftCellForDecrypt(shiftKey1);

                String temp = new String(blockTeks);
                result += temp;
                i++;
            }

            return result;
        }

        public string encrypt1(String plain, String kunci)
        {
            String chip = "";
            for (int i = 0, j = 0; i < plain.Length; i++)
            {
                char c = plain[i];
                chip = chip + (char)((c + kunci[j]) % 256);
                j = ++j % kunci.Length;
            }
            chip = ToHexString(chip);
            return chip;
        }

        public String decrypt1(String chip, String kunci)
        {
            String plain = "";//plaintext
            chip = FromHexString(chip);
            for (int i = 0, j = 0; i < chip.Length; i++)
            {
                char c = chip[i];
                plain = plain + (char)((c - kunci[j]) % 256);
                j = ++j % kunci.Length;
            }
            return plain;
        }

        public static string ToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString(); 
        }

        public static string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes);
        }
    }
}
