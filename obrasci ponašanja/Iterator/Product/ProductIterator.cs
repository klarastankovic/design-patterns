﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Product
{
    public class ProductIterator : IAbstractProductIterator
    {
        private Box box;
        private int currentPosition;
        public ProductIterator(Box box)
        {
            this.box = box;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.box.Count; } }
        public Product Current { get { return this.box[currentPosition]; } }
        public Product First()
        {
            return this.box[0];
        }
        public Product Next()
        {
            this.currentPosition++;
            if(this.IsDone)
            {
                return null;
            }
            else {
                return this.box[this.currentPosition];
            }
        }
    }
}
