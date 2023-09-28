using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        // fields
        private string _brand; // this cell phone brand.
        private string _model; // this cell phone model.
        private decimal _price; // cell phone retail price.
        public CellPhone() // constructor.
        {
        _brand="";
        _model="";
       _price=0m;
            }
    public string Brand // Brand property.
    {
        get { return _brand; }
        set { _brand = value; }
    }
    public string Model// Model property.
    {
        get { return _model; }
        set { _model = value; }
    }
    public decimal Price // Price property.
    {
        get { return _price; }
        set { _price = value; }

    }
    }
    }

