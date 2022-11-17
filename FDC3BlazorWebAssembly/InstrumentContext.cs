public class InstrumentID {
    public string? ticker { get; set; }
    public string? RIC { get; set; }

    public string? ISIN { get; set; }
}

public class InstrumentContext
{
    public string? type { get; set; }
    public string? name { get; set; }
    public InstrumentID? id { get; set; }
}
