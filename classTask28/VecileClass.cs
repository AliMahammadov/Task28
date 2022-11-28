using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTask28
{
    internal abstract class VecileClass
    {
        double _driveTime;
        double _drivePath;


        private double Drive;


        public double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if(value>0)
                _driveTime = value; 
            }
        }


        private double Path;

        public double DrivePath
        {
            get
            {
                return DrivePath;
            }
            set 
            {
                if (value > 0)
                    DrivePath = value;
            }
        }
        public void AverageSpeed()
        {
            Console.WriteLine(driveTime + path) / 2;
        }
    }

    
}


  