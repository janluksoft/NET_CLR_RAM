using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sProjFood4
{
    internal class CFood
    {
        public int Id;
        public string Name;
        public int iCalories;
        public bool isFluid;
        public char cQuality;
        public byte bExpires;
        public int[] tBox; // = new int[5] { 1, 2, 3, 4, 5 };
        public CFactory cFactory;
        public CfPackage sPackage;

        public CFood(int id, string name, int iCalories, bool isFluid, char cQuality, byte bExpires, int[] tBox, CFactory cFactory)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            this.iCalories = iCalories;
            this.isFluid = isFluid;
            this.cQuality = cQuality;
            this.bExpires = bExpires;
            this.tBox = tBox ?? throw new ArgumentNullException(nameof(tBox));
            this.cFactory = cFactory ?? throw new ArgumentNullException(nameof(cFactory));
        }

        public CFood()
        {
            int aj = 0;
            Id = 0;
            Name = "None";
            this.iCalories = 200;
            this.isFluid = false;
            this.cQuality = 'Q';
            this.bExpires = 3;
            this.tBox = new int[] { 1, 2, 3 };
            this.cFactory = new CFactory();
            SetPack(0, 20.2f, 'R');
        }

        public void SetPack(int id, float length, char cPackType)
        {
            sPackage.Id = id; // fill structure
            sPackage.Length = length;
            sPackage.cPackType = cPackType;
        }


        public float Energy(float xWeight_g)
        {
            float _energy = xWeight_g * iCalories;
            return (_energy);
        }
    }
}