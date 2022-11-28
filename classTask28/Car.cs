using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTask28
{
    internal class Car
    {
        int _doorCount;
        string _pedalKind;
        double _wingLength;


        private int Count;

        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                _doorCount = value;
            }
        }

        private string Pedal;

        public string PedalKind
        {
            get { return PedalKind; }
            set { PedalKind = value; }
        }

    }
    private int _wingLength;

    public int MyProperty
    {
        get { return _wingLength; }
        set { _wingLength = value; }
    }



}
