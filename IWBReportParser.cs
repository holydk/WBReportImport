﻿namespace WBImport
{
    public interface IWBReportParser
    {
        Task<IEnumerable<WBReportLine>> ParseAsync(Stream stream);
    }
}