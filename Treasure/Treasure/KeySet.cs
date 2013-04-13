﻿namespace Treasure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class KeySet
    {
        private IList<int> keys;

        public KeySet()
        {
            this.keys = new List<int>();
        }

        public KeySet(IEnumerable<int> keys)
        {
            this.keys = new List<int>(keys);
        }

        public KeySet Add(int key)
        {
            var newkeys = new List<int>(this.keys);
            newkeys.Add(key);
            return new KeySet(newkeys);
        }

        public KeySet Remove(int key)
        {
            var newkeys = new List<int>(this.keys);
            newkeys.Remove(key);
            return new KeySet(newkeys);
        }

        public IEnumerable<int> Keys { get { return this.keys; } }
    }
}
