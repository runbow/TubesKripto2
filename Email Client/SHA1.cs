using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Client
{
    class SHA1
    {
        private static int rol(int num, int cnt)
        {
            return unchecked((num << cnt) | ((int)((uint)num >> (32 - cnt))));
        }


        public string encode(string str)
        {

            sbyte[] x = str.GetBytes();
            int[] blks = new int[(((x.Length + 8) >> 6) + 1) * 16];
            int i;

            for (i = 0; i < x.Length; i++)
            {
                blks[i >> 2] |= x[i] << (24 - (i % 4) * 8);
            }

            blks[i >> 2] |= 0x80 << (24 - (i % 4) * 8);
            blks[blks.Length - 1] = x.Length * 8;

            int[] w = new int[80];

            int a = 1732584193;
            int b = -271733879;
            int c = -1732584194;
            int d = 271733878;
            int e = -1009589776;

            for (i = 0; i < blks.Length; i += 16)
            {
                int olda = a;
                int oldb = b;
                int oldc = c;
                int oldd = d;
                int olde = e;

                for (int j = 0; j < 80; j++)
                {
                    w[j] = (j < 16) ? blks[i + j] : (rol(w[j - 3] ^ w[j - 8] ^ w[j - 14] ^ w[j - 16], 1));

                    int t = unchecked(rol(a, 5) + e + w[j] + ((j < 20) ? 1518500249 + ((b & c) | ((~b) & d)) : (j < 40) ? 1859775393 + (b ^ c ^ d) : (j < 60) ? -1894007588 + ((b & c) | (b & d) | (c & d)) : -899497514 + (b ^ c ^ d)));
                    e = d;
                    d = c;
                    c = rol(b, 30);
                    b = a;
                    a = t;
                }

                a = unchecked(a + olda);
                b = unchecked(b + oldb);
                c = unchecked(c + oldc);
                d = unchecked(d + oldd);
                e = unchecked(e + olde);
            }

            int[] words = new int[] { a, b, c, d, e, 0 };
            sbyte[] base64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".GetBytes();
            sbyte[] result = new sbyte[28];
            for (i = 0; i < 27; i++)
            {
                int start = i * 6;
                int word = start >> 5;
                int offset = start & 0x1f;

                if (offset <= 26)
                {
                    result[i] = base64[(words[word] >> (26 - offset)) & 0x3F];
                }
                else if (offset == 28)
                {
                    result[i] = base64[(((words[word] & 0x0F) << 2) | ((words[word + 1] >> 30) & 0x03)) & 0x3F];
                }
                else
                {
                    result[i] = base64[(((words[word] & 0x03) << 4) | ((words[word + 1] >> 28) & 0x0F)) & 0x3F];
                }
            }
            result[27] = (sbyte)'=';

            string base6 = StringHelperClass.NewString(result);
            byte[] decByte = Convert.FromBase64String(base6);

            string hex = BitConverter.ToString(decByte).Replace("-", string.Empty);

            return hex;
        }

    }

    internal static class StringHelperClass
    {

        internal static string SubstringSpecial(this string self, int start, int end)
        {
            return self.Substring(start, end - start);
        }

        internal static bool StartsWith(this string self, string prefix, int toffset)
        {
            return self.IndexOf(prefix, toffset, System.StringComparison.Ordinal) == toffset;
        }

        internal static string[] Split(this string self, string regexDelimiter, bool trimTrailingEmptyStrings)
        {
            string[] splitArray = System.Text.RegularExpressions.Regex.Split(self, regexDelimiter);

            if (trimTrailingEmptyStrings)
            {
                if (splitArray.Length > 1)
                {
                    for (int i = splitArray.Length; i > 0; i--)
                    {
                        if (splitArray[i - 1].Length > 0)
                        {
                            if (i < splitArray.Length)
                                System.Array.Resize(ref splitArray, i);

                            break;
                        }
                    }
                }
            }

            return splitArray;
        }

        internal static string NewString(sbyte[] bytes)
        {
            return NewString(bytes, 0, bytes.Length);
        }
        internal static string NewString(sbyte[] bytes, int index, int count)
        {
            return System.Text.Encoding.UTF8.GetString((byte[])(object)bytes, index, count);
        }
        internal static string NewString(sbyte[] bytes, string encoding)
        {
            return NewString(bytes, 0, bytes.Length, encoding);
        }
        internal static string NewString(sbyte[] bytes, int index, int count, string encoding)
        {
            return System.Text.Encoding.GetEncoding(encoding).GetString((byte[])(object)bytes, index, count);
        }

        internal static sbyte[] GetBytes(this string self)
        {
            return GetSBytesForEncoding(System.Text.Encoding.UTF8, self);
        }
        internal static sbyte[] GetBytes(this string self, string encoding)
        {
            return GetSBytesForEncoding(System.Text.Encoding.GetEncoding(encoding), self);
        }
        private static sbyte[] GetSBytesForEncoding(System.Text.Encoding encoding, string s)
        {
            sbyte[] sbytes = new sbyte[encoding.GetByteCount(s)];
            encoding.GetBytes(s, 0, s.Length, (byte[])(object)sbytes, 0);
            return sbytes;
        }
    }
}
