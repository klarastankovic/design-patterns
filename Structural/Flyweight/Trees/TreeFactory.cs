using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Trees
{
    public class TreeFactory
    {
        static Dictionary<String, TreeSpecies> treeTypes = new Dictionary<String, TreeSpecies>();
        public static TreeSpecies GetTreeType(String name, String color, String otherTreeData)
        {
            TreeSpecies result = null;
            try
            {
                result = treeTypes[name];
            }
            catch(KeyNotFoundException e)
            {
                result = new TreeSpecies(name, color, otherTreeData);
                treeTypes.Add(name,result);
            }
            return result;
        }
    }
}
