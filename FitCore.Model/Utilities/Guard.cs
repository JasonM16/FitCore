using System;
using System.Collections.Generic;
using System.Text;

namespace FitCore.Model.Utilities
{
    public interface IGuardClause { }
    public class Guard : IGuardClause
    {
        public static IGuardClause Against { get; } = new Guard();

        private Guard() { }
    }
}
