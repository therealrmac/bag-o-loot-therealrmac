using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace BagOLoot
{
    public class ToyManager
    {
        public List<int> GetAllChildrenWhoAreQualifiedForToys()
        {
            return new List<int>();
        }

        public List<int> GetEveryToyInOrderToGetEveryChild(int childId)
        {
            return new List<int>(){1,2,4,7,9};
        }
        public bool HasItBeenDelivered(int childId)
        {
            return true;
        }

    }

}