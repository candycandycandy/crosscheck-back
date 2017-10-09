using System;

namespace app
{
    internal class Disaster
    {
        private int _id;

        public Disaster()
        {
        }

        internal bool IsSaved()
        {
            if (_id > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }

        internal void SetId(int id)
        {
            _id = id;
        }
    }
}