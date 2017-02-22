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

        /// TODO: Are the following test cases sufficient, to prove your code works
        /// as expected? If not either write more test cases and/or describe what
        /// other tests cases would be needed.
        /// I added an empty test case condition to test guard clauses (trival)
        /// I also added a very long sequence to test performance and bit math, and everything checked ok

        /// TODO: What limitations does your algorithm have (if any)?
        /// The biggest limitation is the presentation. Having to loop through a map reduced subset of the original could be eliminated
        ///The advantage of using a dictionary is the look up time, preserving order and duplicates, and easy incrementation of values by taking advantage bit math.
        ///The draw back is the presentation of the results as it has be to looped through again. While this is subset,
        ///One could try and to combine the presentation after it recognized that a new sequence has begun.
        /// 
        /// 
        ///Also by incrementing the dictionary value directly, it will fail if the key does not exist in the dictionary because I do not use TryGet, this is ok because of the logic.

        /// TODO: What do you think about the efficiency of this algorithm for encoding data?
        ///I have to loop, through but want to only once since order matters
        ///This runs O(n) which I am happy about, but as mentioned the presentation looping through the subset could be eliminated, however the complexity of 
        ///understanding the algorithm could go up, which means that while it runs faster it is harder to read and understand.
        ///For example if you try and combine the presentation of the array and the calculation of the dictionary values, not only do you
        /// violate single responsibility and modularity and readability, but you are plagued with edge cases that have be intricately handled leading to brittle code with
        /// additional potential for failure in production. In this challenge, performance is only a consideration and not a main design driver.

        //Design Thought Process:
        //Collection because I want to enumerate and I have no idea how long or short the end result will be. Do not neet index look up from list.
        // Case one initializer.
        // Note this link exists : http://stackoverflow.com/questions/1932691/how-to-do-rle-run-length-encoding-in-c-sharp-on-a-byte-array
        //but is against the spirit of the challenge.
        //Now making it a dictionary because I want the look up performance of a hashset, and also utitlize the counter logic.
        //The issue with this is the presentation, as I have to conver to an array afterwards, granted it is a SMALLER subset of the original logic, so this
        //will be less then O(n^2) since the second collection has been map reduced from the original array.

        public byte[] Encode(byte[] original)
        {
            if (original.Length == 0) return original;

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
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x01, 0x02, 0x02}, new byte[]{0x02, 0x01, 0x02, 0x02}),
                    //My Test Cases - I always like having guard clauses to defend against clients.
                    new Tuple<byte[], byte[]>(new byte[0], new byte[0]),
                    new Tuple<byte[], byte[]>(new byte[]{0x04, 0x04, 0x03, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01}, new byte[]{0x02, 0x04, 0x01, 0x03, (byte)41, 0x01}),
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
