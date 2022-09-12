using Common.Models.Macros.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

[ComplexType]
public class EFLongCollection : EFPrimitiveCollection<long>
{
    public override long ConvertFromString(string value) => long.Parse(value);
    public override string ConvertToString(long value) => value.ToString();
}