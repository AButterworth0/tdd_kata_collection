namespace wardrobe.tests
{
    public class UnitTest1
    {
        // test that a a fitting combinations is returned 
        [Theory]
        [InlineData(new int[] {200, 50})]
        public void GivenASingleFittingCombinationThenReturnSingleCombination(int[] wardrobes)
        {
            //arrange
            string expected = "200,50";

            //act
            string actual = DressingRoom.GetFittingWardrobeCombinations(wardrobes);

            //assert
            Assert.Equal(expected, actual);

        }

        // test that multiple fitting combinations are returned

        // test that no fitting combinations are returned


    }
}