﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace KMA.APRZP2019.TextEditorProject.Tools
{
    public static class Encryptor
    {
        /// <summary>
        /// Encrypts <paramref name="text"/> with md5
        /// </summary>
        /// <param name="text">Text to encrypt</param>
        /// <returns>Encrypted text</returns>
        public static string GetMd5HashForString(string text)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            var hashValue = md5Hasher.ComputeHash(ConvertStringToByteArray(text));
            var hashData = BitConverter.ToString(hashValue);
            hashData = hashData.Replace("-", "");
            var result = hashData;
            return result;
        }
        private static byte[] ConvertStringToByteArray(string data)
        {
            return new UnicodeEncoding().GetBytes(data);
        }
    }
}
