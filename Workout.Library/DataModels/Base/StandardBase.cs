using System;

namespace Workout.Library.DataModels.Base;

public class StandardBase
{
    public string UpdatedBy { get; set; } = "";
    public byte[] ConcurrencyKey { get; set; } = new byte[8];
}

public class ByteIdBase : StandardBase
{
    public byte Id {get; set;} = 0;
}

public class ShortIdBase : StandardBase
{
    public short Id {get; set;} = 0;
}

public class IntIdBase : StandardBase 
{
    public int Id { get; set; } = 0;
}

public class LongIdBase : StandardBase 
{
    public long Id { get; set; } = 0;
}

public class StringIdBase : StandardBase
{
    public string Id {get; set;} = "";
}

public class GuidIdBase : StandardBase
{
    public Guid Id { get; set; } = Guid.NewGuid();
}