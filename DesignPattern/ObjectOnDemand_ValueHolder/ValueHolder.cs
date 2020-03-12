using System;

namespace ObjectOnDemand_ValueHolder
{
    public class ValueHolder<T>
    {
        private T _value;
        private readonly Func<object, T> _valueRetrieval;

        // Constructor
        public ValueHolder(Func<object, T> valueRetrieval)
        {
            _valueRetrieval = valueRetrieval;
        }

        // We'll use the signature "GetValue" for convention
        public T GetValue(object parameter)
        {
            if (_value == null)
                _value = _valueRetrieval(parameter);
            return _value;
        }
    }
}
