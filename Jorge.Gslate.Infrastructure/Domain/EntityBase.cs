﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jorge.Gslate.Infrastructure.Domain
{
    public abstract class EntityBase
    {
        private readonly List<BusinessRule> _brokenRules = new List<BusinessRule>();

        protected abstract void Validate();


        public IEnumerable<BusinessRule> GetBrokenRules()
        {
            _brokenRules.Clear();
            Validate();
            return _brokenRules;
        }        

        protected void AddBrokenRule(BusinessRule businessRule)
        {            
            _brokenRules.Add(businessRule);
        }

        public bool IsValid()
        {            
            return !GetBrokenRules().Any();
        }
    }
}
