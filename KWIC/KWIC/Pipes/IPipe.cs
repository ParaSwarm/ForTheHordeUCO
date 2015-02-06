using System.Collections.Generic;

namespace Homework_1
{
    public interface IPipe
    {
        Filter Pump { get; set; }
        Filter Drain { get; set; }
        List<List<string>> Data { get; set; }

        void AttachFilter(Filter pumpFilter, Filter sinkFilter);
    }
}
