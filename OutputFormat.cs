namespace ThermoRawFileParser
{
    public enum OutputFormat
    {
        MGF,
        MzML,
        IndexMzML,
        Parquet,
        NONE
    }

    public enum MetadataFormat
    {
        JSON,
        TXT,
        PARQUET,
        NONE
    }

    public enum SpectrumMode
    {
        PROFILE, CENTROID
    }
}