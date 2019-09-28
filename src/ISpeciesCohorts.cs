
using Landis.Core;
using System.Collections.Generic;

namespace Landis.Library.AgeOnlyCohorts
{
    /// <summary>
    /// The age cohorts for a particular species at a site.
    /// </summary>
    public interface ISpeciesCohorts
        : Landis.Cohorts.ISpeciesCohorts<ICohort>
    {
    }
}
