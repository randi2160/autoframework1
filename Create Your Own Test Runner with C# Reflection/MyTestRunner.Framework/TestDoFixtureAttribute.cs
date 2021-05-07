using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestRunner.Tests
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TestDoFixtureAttribute : Attribute
    {
        public TestDoFixtureAttribute(string name) => this.Name = name;
        public string Name { get; }
    }

   
    
}
