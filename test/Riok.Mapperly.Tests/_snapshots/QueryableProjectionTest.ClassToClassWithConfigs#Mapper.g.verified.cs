﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    private partial global::System.Linq.IQueryable<global::B> Map(global::System.Linq.IQueryable<global::A> source)
    {
#nullable disable
        return System.Linq.Queryable.Select(source, x => new global::B() { StringValue2 = x.StringValue, NestedValue = new global::D() { IntValue = (int)x.NestedValue.LongValue, NestedValue = new global::F() { ShortValue = x.NestedValue.NestedValue.ShortValue } } });
#nullable enable
    }

    private partial global::B MapToB(global::A source)
    {
        var target = new global::B();
        target.StringValue2 = source.StringValue;
        target.NestedValue = MapToD(source.NestedValue);
        return target;
    }

    private partial global::D MapToD(global::C source)
    {
        var target = new global::D();
        target.IntValue = (int)source.LongValue;
        target.NestedValue = MapToF(source.NestedValue);
        return target;
    }

    private global::F MapToF(global::E source)
    {
        var target = new global::F();
        target.ShortValue = source.ShortValue;
        return target;
    }
}
