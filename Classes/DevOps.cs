using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RackKeyV07.Classes
{
    public static class DevOps
    {
        /// <summary>
        /// Method Goal is to change component type from name to index number in data file
        /// </summary>
        public static void CorrectComponentTypes()
        {
            List<Component> allComp = Main.GetComponentsList();
            foreach (var item in allComp)
            {
                string sql = "Update Components Set ComponentType='" + item.ComponentType.ID.ToString() + "' Where ComponentID=" + item.ComponentID;
                Globs.DB.Update(sql);
            }
        }
    }
}
