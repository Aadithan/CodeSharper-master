﻿
using System.Linq;
using CodeSharper.UI.Analyzer.Specifications;

namespace CodeSharper.UI.Analyzer.Rules.CSharp
{
    public class ObsoleteContentSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string codeLine)
        {
            return Constants.ObsoleteContent.Any(codeLine.Contains);
        }
    }
}
