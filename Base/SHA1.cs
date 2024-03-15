using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerce.NET.Base
{
    //Thanks to Michael Leonhard's SHA1 project. http://www.tamale.net/sha1/
    public class Sha1
    {
        uint _h0, _h1, _h2, _h3, _h4, _unprocessedBytes, _size;
        byte[] _bytes = new byte[64];

        public Sha1(string message)
        {
            // initialize
            _h0 = 0x67452301;
            _h1 = 0xefcdab89;
            _h2 = 0x98badcfe;
            _h3 = 0x10325476;
            _h4 = 0xc3d2e1f0;
            _unprocessedBytes = 0;
            _size = 0;

            byte[] data = Encoding.UTF8.GetBytes(message);
            AddBytes(data, (uint)data.Length);
        }

        // circular left bit rotation.  MSB wraps around to LSB
        uint Lrot(uint x, int bits)
        {
            return (x << bits) | (x >> (32 - bits));
        }

        // Save a 32-bit unsigned integer to memory, in big-endian order
        void StoreBigEndianUint32(byte[] data, uint pos, uint num)
        {
            data[pos + 0] = (byte)(num >> 24);
            data[pos + 1] = (byte)(num >> 16);
            data[pos + 2] = (byte)(num >> 8);
            data[pos + 3] = (byte)num;
        }

        // process ***********************************************************
        void Process()
        {
            uint a, b, c, d, e, k, f, t;
            uint[] w = new uint[80];
            // starting values
            a = _h0;
            b = _h1;
            c = _h2;
            d = _h3;
            e = _h4;
            // copy and expand the message block
            for (t = 0; t < 16; t++)
                w[t] = (uint)((_bytes[t * 4] << 24) + (_bytes[t * 4 + 1] << 16) + (_bytes[t * 4 + 2] << 8) + _bytes[t * 4 + 3]);
            for (; t < 80; t++)
                w[t] = Lrot(w[t - 3] ^ w[t - 8] ^ w[t - 14] ^ w[t - 16], 1);

            /* main loop */
            uint temp;
            for (t = 0; t < 80; t++)
            {
                if (t < 20)
                {
                    k = 0x5a827999;
                    f = (b & c) | ((b ^ 0xFFFFFFFF) & d);//TODO: try using ~
                }
                else if (t < 40)
                {
                    k = 0x6ed9eba1;
                    f = b ^ c ^ d;
                }
                else if (t < 60)
                {
                    k = 0x8f1bbcdc;
                    f = (b & c) | (b & d) | (c & d);
                }
                else
                {
                    k = 0xca62c1d6;
                    f = b ^ c ^ d;
                }
                temp = Lrot(a, 5) + f + e + w[t] + k;
                e = d;
                d = c;
                c = Lrot(b, 30);
                b = a;
                a = temp;
            }
            /* add variables */
            _h0 += a;
            _h1 += b;
            _h2 += c;
            _h3 += d;
            _h4 += e;

            /* all bytes have been processed */
            _unprocessedBytes = 0;
        }

        // addBytes **********************************************************
        void AddBytes(byte[] data, uint num)
        {
            // add these bytes to the running total
            _size += num;
            // repeat until all data is processed
            while (num > 0)
            {
                // number of bytes required to complete block
                uint needed = 64 - _unprocessedBytes;
                //assert( needed > 0 );
                // number of bytes to copy (use smaller of two)
                uint toCopy = (num < needed) ? num : needed;
                // Copy the bytes
                //memcpy( bytes + unprocessedBytes, data, toCopy );
                for (int i = 0; i < toCopy; i++)
                    _bytes[_unprocessedBytes + i] = data[i];

                // Bytes have been copied
                num -= toCopy;
                //data += toCopy;
                _unprocessedBytes += toCopy;

                // there is a full block
                if (_unprocessedBytes == 64) Process();
            }
        }

        // digest ************************************************************
        public string GetHash()
        {
            // save the message size
            uint totalBitsL = _size << 3;
            uint totalBitsH = _size >> 29;
            // add 0x80 to the message
            AddBytes(new byte[] { 0x80 }, 1);

            byte[] footer = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            // block has no room for 8-byte filesize, so finish it
            if (_unprocessedBytes > 56)
                AddBytes(footer, 64 - _unprocessedBytes);
            //assert( unprocessedBytes <= 56 );
            // how many zeros do we need
            uint neededZeros = 56 - _unprocessedBytes;
            // store file size (in bits) in big-endian format
            StoreBigEndianUint32(footer, neededZeros, totalBitsH);
            StoreBigEndianUint32(footer, neededZeros + 4, totalBitsL);
            // finish the final block
            AddBytes(footer, neededZeros + 8);
            // allocate memory for the digest bytes
            byte[] digest = new byte[20];
            // copy the digest bytes
            StoreBigEndianUint32(digest, 0, _h0);
            StoreBigEndianUint32(digest, 4, _h1);
            StoreBigEndianUint32(digest, 8, _h2);
            StoreBigEndianUint32(digest, 12, _h3);
            StoreBigEndianUint32(digest, 16, _h4);
            // return the digest

            string sbinary = "";

            for (int i = 0; i < digest.Length; i++)
            {
                sbinary += digest[i].ToString("X2"); // hex format
            }
            return sbinary.ToLower();
        }
    }
}
