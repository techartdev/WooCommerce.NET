using System;

namespace WooCommerce.NET.Base
{
    //Thanks to Stephan Brumme's Portable C++ Hashing Library.   http://create.stephan-brumme.com/hash-library/
    public class HmacSha256
    {
        const uint BLOCK_SIZE = 64;
        const uint HASH_BYTES = 32;

        ulong _mNumBytes, _mBufferSize;
        uint[] _mHash;
        byte[] _mBuffer;

        /// restart
        public HmacSha256()
        {
            _mNumBytes = 0;
            _mBufferSize = 0;

            _mHash = new uint[8];
            _mBuffer = new byte[BLOCK_SIZE];

            // according to RFC 1321
            _mHash[0] = 0x6a09e667;
            _mHash[1] = 0xbb67ae85;
            _mHash[2] = 0x3c6ef372;
            _mHash[3] = 0xa54ff53a;
            _mHash[4] = 0x510e527f;
            _mHash[5] = 0x9b05688c;
            _mHash[6] = 0x1f83d9ab;
            _mHash[7] = 0x5be0cd19;
        }

        uint Rotate(uint a, int c)
        {
            return (a >> c) | (a << (32 - c));
        }

        uint Swap(uint x)
        {

            return (x >> 24) |
                  ((x >> 8) & 0x0000FF00) |
                  ((x << 8) & 0x00FF0000) |
                   (x << 24);
        }

        // mix functions for processBlock()
        uint F1(uint e, uint f, uint g)
        {
            uint term1 = Rotate(e, 6) ^ Rotate(e, 11) ^ Rotate(e, 25);
            uint term2 = (e & f) ^ (~e & g); //(g ^ (e & (f ^ g)))
            return term1 + term2;
        }

        uint F2(uint a, uint b, uint c)
        {
            uint term1 = Rotate(a, 2) ^ Rotate(a, 13) ^ Rotate(a, 22);
            uint term2 = ((a | b) & c) | (a & b); //(a & (b ^ c)) ^ (b & c);
            return term1 + term2;
        }



        /// process 64 bytes
        void ProcessBlock(byte[] data)
        {
            // get last hash
            uint a = _mHash[0];
            uint b = _mHash[1];
            uint c = _mHash[2];
            uint d = _mHash[3];
            uint e = _mHash[4];
            uint f = _mHash[5];
            uint g = _mHash[6];
            uint h = _mHash[7];

            // data represented as 16x 32-bit words
            uint[] input = new uint[16];
            int i;
            for (i = 0; i < 16; i++)
                input[i] = BitConverter.ToUInt32(data, i * 4);

            // convert to big endian
            uint[] words = new uint[64];

            for (i = 0; i < 16; i++)
                words[i] = Swap(input[i]);

            uint x, y; // temporaries

            // first round
            x = h + F1(e, f, g) + 0x428a2f98 + words[0]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0x71374491 + words[1]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0xb5c0fbcf + words[2]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0xe9b5dba5 + words[3]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0x3956c25b + words[4]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0x59f111f1 + words[5]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0x923f82a4 + words[6]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0xab1c5ed5 + words[7]; y = F2(b, c, d); e += x; a = x + y;

            // secound round
            x = h + F1(e, f, g) + 0xd807aa98 + words[8]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0x12835b01 + words[9]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0x243185be + words[10]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0x550c7dc3 + words[11]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0x72be5d74 + words[12]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0x80deb1fe + words[13]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0x9bdc06a7 + words[14]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0xc19bf174 + words[15]; y = F2(b, c, d); e += x; a = x + y;

            // extend to 24 words
            for (; i < 24; i++)
                words[i] = words[i - 16] +
                           (Rotate(words[i - 15], 7) ^ Rotate(words[i - 15], 18) ^ (words[i - 15] >> 3)) +
                           words[i - 7] +
                           (Rotate(words[i - 2], 17) ^ Rotate(words[i - 2], 19) ^ (words[i - 2] >> 10));

            // third round
            x = h + F1(e, f, g) + 0xe49b69c1 + words[16]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0xefbe4786 + words[17]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0x0fc19dc6 + words[18]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0x240ca1cc + words[19]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0x2de92c6f + words[20]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0x4a7484aa + words[21]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0x5cb0a9dc + words[22]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0x76f988da + words[23]; y = F2(b, c, d); e += x; a = x + y;

            // extend to 32 words
            for (; i < 32; i++)
                words[i] = words[i - 16] +
                           (Rotate(words[i - 15], 7) ^ Rotate(words[i - 15], 18) ^ (words[i - 15] >> 3)) +
                           words[i - 7] +
                           (Rotate(words[i - 2], 17) ^ Rotate(words[i - 2], 19) ^ (words[i - 2] >> 10));

            // fourth round
            x = h + F1(e, f, g) + 0x983e5152 + words[24]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0xa831c66d + words[25]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0xb00327c8 + words[26]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0xbf597fc7 + words[27]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0xc6e00bf3 + words[28]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0xd5a79147 + words[29]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0x06ca6351 + words[30]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0x14292967 + words[31]; y = F2(b, c, d); e += x; a = x + y;

            // extend to 40 words
            for (; i < 40; i++)
                words[i] = words[i - 16] +
                           (Rotate(words[i - 15], 7) ^ Rotate(words[i - 15], 18) ^ (words[i - 15] >> 3)) +
                           words[i - 7] +
                           (Rotate(words[i - 2], 17) ^ Rotate(words[i - 2], 19) ^ (words[i - 2] >> 10));

            // fifth round
            x = h + F1(e, f, g) + 0x27b70a85 + words[32]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0x2e1b2138 + words[33]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0x4d2c6dfc + words[34]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0x53380d13 + words[35]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0x650a7354 + words[36]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0x766a0abb + words[37]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0x81c2c92e + words[38]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0x92722c85 + words[39]; y = F2(b, c, d); e += x; a = x + y;

            // extend to 48 words
            for (; i < 48; i++)
                words[i] = words[i - 16] +
                           (Rotate(words[i - 15], 7) ^ Rotate(words[i - 15], 18) ^ (words[i - 15] >> 3)) +
                           words[i - 7] +
                           (Rotate(words[i - 2], 17) ^ Rotate(words[i - 2], 19) ^ (words[i - 2] >> 10));

            // sixth round
            x = h + F1(e, f, g) + 0xa2bfe8a1 + words[40]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0xa81a664b + words[41]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0xc24b8b70 + words[42]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0xc76c51a3 + words[43]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0xd192e819 + words[44]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0xd6990624 + words[45]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0xf40e3585 + words[46]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0x106aa070 + words[47]; y = F2(b, c, d); e += x; a = x + y;

            // extend to 56 words
            for (; i < 56; i++)
                words[i] = words[i - 16] +
                           (Rotate(words[i - 15], 7) ^ Rotate(words[i - 15], 18) ^ (words[i - 15] >> 3)) +
                           words[i - 7] +
                           (Rotate(words[i - 2], 17) ^ Rotate(words[i - 2], 19) ^ (words[i - 2] >> 10));

            // seventh round
            x = h + F1(e, f, g) + 0x19a4c116 + words[48]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0x1e376c08 + words[49]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0x2748774c + words[50]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0x34b0bcb5 + words[51]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0x391c0cb3 + words[52]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0x4ed8aa4a + words[53]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0x5b9cca4f + words[54]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0x682e6ff3 + words[55]; y = F2(b, c, d); e += x; a = x + y;

            // extend to 64 words
            for (; i < 64; i++)
                words[i] = words[i - 16] +
                           (Rotate(words[i - 15], 7) ^ Rotate(words[i - 15], 18) ^ (words[i - 15] >> 3)) +
                           words[i - 7] +
                           (Rotate(words[i - 2], 17) ^ Rotate(words[i - 2], 19) ^ (words[i - 2] >> 10));

            // eigth round
            x = h + F1(e, f, g) + 0x748f82ee + words[56]; y = F2(a, b, c); d += x; h = x + y;
            x = g + F1(d, e, f) + 0x78a5636f + words[57]; y = F2(h, a, b); c += x; g = x + y;
            x = f + F1(c, d, e) + 0x84c87814 + words[58]; y = F2(g, h, a); b += x; f = x + y;
            x = e + F1(b, c, d) + 0x8cc70208 + words[59]; y = F2(f, g, h); a += x; e = x + y;
            x = d + F1(a, b, c) + 0x90befffa + words[60]; y = F2(e, f, g); h += x; d = x + y;
            x = c + F1(h, a, b) + 0xa4506ceb + words[61]; y = F2(d, e, f); g += x; c = x + y;
            x = b + F1(g, h, a) + 0xbef9a3f7 + words[62]; y = F2(c, d, e); f += x; b = x + y;
            x = a + F1(f, g, h) + 0xc67178f2 + words[63]; y = F2(b, c, d); e += x; a = x + y;

            // update hash
            _mHash[0] += a;
            _mHash[1] += b;
            _mHash[2] += c;
            _mHash[3] += d;
            _mHash[4] += e;
            _mHash[5] += f;
            _mHash[6] += g;
            _mHash[7] += h;
        }


        /// add arbitrary number of bytes
        void Add(byte[] data, uint numBytes)
        {
            //const uint8_t* current = (const uint8_t*) data;
            uint index = 0;
            if (_mBufferSize > 0)
            {
                while (numBytes > 0 && _mBufferSize < BLOCK_SIZE)
                {
                    _mBuffer[_mBufferSize++] = data[index];
                    index++;
                    numBytes--;
                }
            }

            // full buffer
            if (_mBufferSize == BLOCK_SIZE)
            {
                ProcessBlock(_mBuffer);
                _mNumBytes += BLOCK_SIZE;
                _mBufferSize = 0;
            }

            // no more data ?
            if (numBytes == 0)
                return;

            // process full blocks
            byte[] processData = new byte[BLOCK_SIZE];
            while (numBytes >= BLOCK_SIZE)
            {
                Array.Copy(data, (int)index * 64, processData, 0, (int)BLOCK_SIZE);
                ProcessBlock(processData);
                index++;
                _mNumBytes += BLOCK_SIZE;
                numBytes -= BLOCK_SIZE;
            }

            // keep remaining bytes in buffer
            while (numBytes > 0)
            {
                _mBuffer[_mBufferSize++] = data[data.Length - numBytes];
                index++;
                numBytes--;
            }
        }


        /// process final block, less than 64 bytes
        void ProcessBuffer()
        {
            // the input bytes are considered as bits strings, where the first bit is the most significant bit of the byte

            // - append "1" bit to message
            // - append "0" bits until message length in bit mod 512 is 448
            // - append length as 64 bit integer

            // number of bits
            ulong paddedLength = _mBufferSize * 8;

            // plus one bit set to 1 (always appended)
            paddedLength++;

            // number of bits must be (numBits % 512) = 448
            ulong lower11Bits = paddedLength & 511;
            if (lower11Bits <= 448)
                paddedLength += 448 - lower11Bits;
            else
                paddedLength += 512 + 448 - lower11Bits;
            // convert from bits to bytes
            paddedLength /= 8;

            // only needed if additional data flows over into a second block
            byte[] extra = new byte[BLOCK_SIZE];

            // append a "1" bit, 128 => binary 10000000
            if (_mBufferSize < BLOCK_SIZE)
                _mBuffer[_mBufferSize] = 128;
            else
                extra[0] = 128;

            ulong i;
            for (i = _mBufferSize + 1; i < BLOCK_SIZE; i++)
                _mBuffer[i] = 0;
            for (; i < paddedLength; i++)
                extra[i - BLOCK_SIZE] = 0;

            // add message length in bits as 64 bit number
            ulong msgBits = 8 * (_mNumBytes + _mBufferSize);
            // find right position

            ulong addLength;
            byte[] temp;
            if (paddedLength < BLOCK_SIZE)
            {
                temp = _mBuffer;
                addLength = paddedLength;
            }
            else
            {
                temp = extra;
                addLength = paddedLength - BLOCK_SIZE;
            }

            // must be big endian
            temp[addLength++] = (byte)((msgBits >> 56) & 0xFF);
            temp[addLength++] = (byte)((msgBits >> 48) & 0xFF);
            temp[addLength++] = (byte)((msgBits >> 40) & 0xFF);
            temp[addLength++] = (byte)((msgBits >> 32) & 0xFF);
            temp[addLength++] = (byte)((msgBits >> 24) & 0xFF);
            temp[addLength++] = (byte)((msgBits >> 16) & 0xFF);
            temp[addLength++] = (byte)((msgBits >> 8) & 0xFF);
            temp[addLength] = (byte)(msgBits & 0xFF);

            // process blocks
            ProcessBlock(_mBuffer);
            // flowed over into a second block ?
            if (paddedLength > BLOCK_SIZE)
                ProcessBlock(extra);
        }

        /// return latest hash as bytes
        byte[] GetHash(byte[] buffer)
        {
            // save old hash if buffer is partially filled
            int hashValues = 8;
            uint[] oldHash = new uint[hashValues];
            for (int i = 0; i < hashValues; i++)
                oldHash[i] = _mHash[i];

            // process remaining bytes
            ProcessBuffer();

            //unsigned char* current = buffer;
            int index = 0;
            for (int i = 0; i < hashValues; i++)
            {
                buffer[index++] = (byte)((_mHash[i] >> 24) & 0xFF);
                buffer[index++] = (byte)((_mHash[i] >> 16) & 0xFF);
                buffer[index++] = (byte)((_mHash[i] >> 8) & 0xFF);
                buffer[index++] = (byte)(_mHash[i] & 0xFF);

                // restore old hash
                _mHash[i] = oldHash[i];
            }

            return buffer;
        }

        public static string Hmac(byte[] data, byte[] key)
        {
            // initialize key with zeros
            //unsigned char usedKey[HashMethod::BlockSize] = {0};
            uint numDataBytes = (uint)data.Length;
            uint numKeyBytes = (uint)key.Length;
            byte[] usedKey = new byte[BLOCK_SIZE];

            // adjust length of key: must contain exactly blockSize bytes
            if (numKeyBytes <= BLOCK_SIZE)
            {
                // copy key
                //memcpy(usedKey, key, numKeyBytes);
                usedKey = key;
                Array.Resize(ref usedKey, (int)BLOCK_SIZE);
            }
            else
            {
                // shorten key: usedKey = hashed(key)
                HmacSha256 keyHasher = new HmacSha256();
                keyHasher.Add(key, numKeyBytes);
                keyHasher.GetHash(usedKey);
            }

            // create initial XOR padding
            for (int i = 0; i < BLOCK_SIZE; i++)
                usedKey[i] ^= 0x36;

            // inside = hash((usedKey ^ 0x36) + data)
            byte[] inside = new byte[HASH_BYTES];
            HmacSha256 insideHasher = new HmacSha256();
            insideHasher.Add(usedKey, BLOCK_SIZE);
            insideHasher.Add(data, numDataBytes);
            inside = insideHasher.GetHash(inside);

            // undo usedKey's previous 0x36 XORing and apply a XOR by 0x5C
            for (int i = 0; i < BLOCK_SIZE; i++)
                usedKey[i] ^= 0x5C ^ 0x36;

            // hash((usedKey ^ 0x5C) + hash((usedKey ^ 0x36) + data))
            HmacSha256 finalHasher = new HmacSha256();
            finalHasher.Add(usedKey, BLOCK_SIZE);
            finalHasher.Add(inside, HASH_BYTES);

            byte[] buffer = new byte[32];

            return Convert.ToBase64String(finalHasher.GetHash(buffer));
        }
    }
}
