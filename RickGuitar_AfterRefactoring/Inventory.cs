using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitar_BeforeRefactoring
{
   public class Inventory
    {
        private IList<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price,
                      String builder, String model,
                      String type, String backWood, String topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(String serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public Guitar search(Guitar searchGuitar)
        {
            foreach (var guitar in guitars)
            {
                String builder = searchGuitar.getBuilder();
                if ((builder != null) && (!builder.Equals("")) &&
                    (!builder.Equals(guitar.getBuilder())))
                    continue;
                String model = searchGuitar.getModel();
                if ((model != null) && (!model.Equals("")) &&
                    (!model.Equals(guitar.getModel())))
                    continue;
                String type = searchGuitar.getType();
                if ((type != null) && (!searchGuitar.Equals("")) &&
                    (!type.Equals(guitar.getType())))
                    continue;
                String backWood = searchGuitar.getBackWood();
                if ((backWood != null) && (!backWood.Equals("")) &&
                    (!backWood.Equals(guitar.getBackWood())))
                    continue;
                String topWood = searchGuitar.getTopWood();
                if ((topWood != null) && (!topWood.Equals("")) &&
                    (!topWood.Equals(guitar.getTopWood())))
                    continue;
                return guitar;
            }

            return null;
        }
    }
}
