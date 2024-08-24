using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_2_AbstractOrnek
{
    public abstract class BaseValidator
    {
        protected object _model;
        public bool IsValid { get; protected set; }
        public string ValidationMessage { get; protected set; }

        public BaseValidator(object model)
        {
            this._model = model;
            string result = Validate();

            IsValid = string.IsNullOrEmpty(result);
            ValidationMessage = result;

        }

        protected abstract string Validate();
    }
}
