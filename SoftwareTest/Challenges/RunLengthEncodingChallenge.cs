using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTest.Challenges.Interfaces;

namespace SoftwareTest.Challenges
{

    /// <summary>
    /// Challenge Due - Run Length Encoding
    ///
    /// RLE is a simple compression scheme that encodes runs of data into
    /// a single data value and a count. It's useful for data that has lots
    /// of contiguous values (for example it was used in fax machines), but
    /// also has lots of downsides.
    ///
    /// For example, aaaaaaabbbbccccddddd would be encoded as
    ///
    /// 7a4b4c5d
    ///
    /// You can find out more about RLE here...
    /// http://en.wikipedia.org/wiki/Run-length_encoding
    ///
    /// In this exercise you will need to write an RLE **Encoder** which will take
    /// a byte array and return an RLE encoded byte array.
    /// </summary>
    public class RunLengthEncodingChallenge : IChallenge
    {

        /// <summary>
        /// Ok dont sort because order matters.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>



        public byte[] Encode(byte[] original)
        {
            if (original.Length == 0) return original;

            // TODO: Are the following test cases sufficient, to prove your code works
            // as expected? If not either write more test cases and/or describe what
            // other tests cases would be needed.
            // TODO: What limitations does your algorithm have (if any)?
            // TODO: What do you think about the efficiency of this algorithm for encoding data?
            //I have to loop, through but want to only once since order matters
            //
            //Collection because I want to enumerate and I have no idea how long or short the end result will be. Do not neet index look up from list.
            // Case one initializer.
            // Note this link exists : http://stackoverflow.com/questions/1932691/how-to-do-rle-run-length-encoding-in-c-sharp-on-a-byte-array
            //but is against the spirit of the challenge.
            //Making it a dictionary because I want the look up performance of a hashset, and also utitlize the counter logic.
            //The issue with this is the presentation, as I have to conver to an array afterwards, granted it is a SMALLER subset of the original logic, so this
            //will be less then O(n^2) since the second collection has been map reduced from the original array.

            var encodedArray = new Dictionary<byte,byte>();
            for (int i = 0; i < original.Length; i++)
            {
                if (i == 0 || original[i - 1] != original[i])
                {
                    encodedArray.Add(original[i], 0x01);
                }
                else
                {
                    encodedArray[original[i]]++;
                }
                
            }

            var result = new List<byte>();
            foreach (var pair in encodedArray)
            {
                result.Add(pair.Value);
                result.Add(pair.Key);
            }

            return result.ToArray();
        }

        public bool Winner()
        {
            var testCases = new[]
            {
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x02, 0x03, 0x04}, new byte[]{0x01, 0x01, 0x01, 0x02, 0x01, 0x03, 0x01, 0x04}),
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x01, 0x01, 0x01}, new byte[]{0x04, 0x01}),
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x01, 0x02, 0x02}, new byte[]{0x02, 0x01, 0x02, 0x02})
            };

            foreach (var testCase in testCases)
            {
                var encoded = Encode(testCase.Item1);
                var isCorrect = encoded.SequenceEqual(testCase.Item2);

                if (!isCorrect)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
