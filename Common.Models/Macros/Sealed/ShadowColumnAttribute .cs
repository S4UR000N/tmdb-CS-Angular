using System;
using System.ComponentModel.DataAnnotations.Schema;

[System.AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public sealed class ShadowColumnAttribute : ColumnAttribute
{
    public ShadowColumnAttribute() { }
    public ShadowColumnAttribute(string name) : base(name) { }
}