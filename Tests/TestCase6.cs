using InsperityLibrary;
using System;
using System.Collections.Generic;
using Xunit;

namespace InsperityTests
{
    public class TestCase6
    {
        private ISorter _sorter;
        private IList<string> _inputs;
        private IList<string> _outputs;

        public TestCase6()
        {
            _sorter = new StringSorterByFrequencyAndLexical();

            this.prepare();
        }

        void prepare()
        {
            this._inputs = new List<string>(){
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys"
            };

            this._outputs = new List<string>(){
                "cqsxy",
                "abeox",
                "afkos",
                "bdilt",
                "grswy"
            };
        }

        [Fact]
        public void Case10Entries()
        {
            for (int i = 0; i < this._inputs.Count; i++)
            {
                string result = _sorter.sort(this._inputs[i]);
                Assert.Equal(this._outputs[i], result);
            }
        }
    }
}
