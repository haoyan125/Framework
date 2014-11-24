using HY.MiPlate.UI.Repository;

namespace HY.MiPlate.UI.Domain
{
    public class SampleDataDomain : ISampleDataDomain
    {
        private readonly ISampleDataRepository _sampleDataRepository;

        public SampleDataDomain(ISampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }

        public int GetNumber()
        {
            return 10;
        }
    }
}