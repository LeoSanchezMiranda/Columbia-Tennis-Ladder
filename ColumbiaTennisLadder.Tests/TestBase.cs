using NUnit.Framework;
using System;


namespace ColumbiaTennisLadder.Tests
{
    public class TestBase
    {
        protected virtual void Arrange() {

        }

        protected virtual void Act() {
            this.Arrange();
        }
    }
}
