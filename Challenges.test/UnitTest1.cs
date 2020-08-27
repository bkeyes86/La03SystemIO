using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Challenges.test
{
    public class UnitTest1
    {
        [Fact]
        public static void Input_a_string_of_numbers_return_product_of_all_numbers()
        {
            int[] array = new[] { 1, 2, 3 };
            int[] productArray = new int [1 * 2 * 3];

            int[] result = Program.StartSequence(array, productArray);

            Assert.Equal(new int[] { 6 }, result);



        }
    }
}
