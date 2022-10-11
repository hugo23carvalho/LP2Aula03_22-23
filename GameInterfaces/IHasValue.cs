using System;


namespace GameInterfaces
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        public float Value {get;}
    }
}