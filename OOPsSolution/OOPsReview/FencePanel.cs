using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //by default all class are private
    //for this class to be used by an outside user
    //   you must alter the permission for this class
    //   you will use public
    // outside users are anything outside the object parameter

    public class FencePanel
    {

        //properties
        // property is associated with a single piece of data.
        // it has 2 sub components get and set
        //         get returns a value to the calling client/outside user
        //         set receives a value from the calling client/outside user
        // a keyword 'value' is used to hold the incoming data to the property
        // the property has a 'return' data type (rdt) to specify the type of data that is allowed.
        // The property syntax does NOT allow for a property parameter


        // Auto Implemented property
        // This style does not need a private data member
        // The system will create an internal data member of the rdt specified in the property definition

        public double Length { get; set; }
        public double Width { get; set; }
        public string Color { get; set; }
        public string Finish { get; set; }

        // public double Height { get; set; } what about negative numbers?
        // Assuming you wish to validate your data you should be using a fully implemented property
        // for example, Height must have a positive non zero value
        // Height must not be greater than 8 ft


        private double _Height;

        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value > 0 && value <= 8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid Height, please enter a value greater then 0 and less than 8");
                }
            }
        }

        // Fully Implemented Properties
        // This style NEEDS a private data member
        // The private data member will store the incoming data value
        // usually this form of property is used when additional coding is required for the incoming data
        // such as validation of the data

        // Example: the string 'data' (<-string name) CAN NOT be an empty string it can be null, it can have characters but it can't be empty.
        private string _Brand;
        public string Brand
        {
            get
            {
                //returns the stored data value
                return _Brand;
            }
            set
            {
                //stores the incoming 'value' in the private member for storage
                if (string.IsNullOrEmpty(value))
                {
                    _Brand = null;
                }
                else
                {
                    _Brand = value;
                }
            }
        }

        // nullable numeric property for a double
        // use question mark to symbolize the data type can have a null value
        // Only 2 possibilities
        // Data is missing: null
        // Data is present and of the right data type


        public double? Price { get; set; }


    }
}
