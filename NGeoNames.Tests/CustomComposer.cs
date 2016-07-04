﻿using NGeoNames.Composers;
using NGeoNames.Tests;
using System.Text;

namespace NGeoNames
{
    internal class CustomComposer : BaseComposer<CustomEntity>
    {
        public CustomComposer(Encoding encoding, char fieldseparator)
        {
            this.Encoding = encoding;
            this.FieldSeparator = fieldseparator;
        }

        public override string Compose(CustomEntity value)
        {
            return string.Join(this.FieldSeparator.ToString(), value.Data);
        }
    }
}
