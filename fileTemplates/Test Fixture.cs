using NUnit.Framework;

namespace TycheEngineUnitTests.GridTests.ExecutionPhaseTests
{
    /// <summary>
    /// Tests of the <see cref="$fixture_name$"/> class.
    /// </summary>
    [TestFixture]
    public sealed class $fixture_name$Tests
    {
        [Test]
        public void $test_name$()
        {
            // Arrange a new dictionary source.
            var mClient = new Mock<INetworkClient>();
            var reports = new TycheReports();
            using(var dictionarySource = ManyToOneTcpDictionary<byte>.CreateSource((writer, value) => writer.Write(value), mClient.Object, 0, reports))
            {
                // Act by trying to get, and assert it throws.
                Assert.That(() => dictionarySource[5], Throws.InvalidOperationException, "Trying to get an item from a tcp dictionary source object should result in an invalid operation exception.");
            }
        }
    }
}