using System;
using System.Collections.Generic;
using System.Text;

namespace POCS
{
    public class DPDetails
    {
        private decimal deliveryPointId;
        public decimal DeliveryPointId
        {
            get
            {
                return deliveryPointId;
            }
            set
            {
                deliveryPointId = value;
            }
        }

        private string deliveryPointName;
        public string DeliveryPointName
        {
            get
            {
                return deliveryPointName;
            }
            set
            {
                deliveryPointName = value;
            }
        }

        private string deliveryPointAddress;
        public string DeliveryPointAddress
        {
            get
            {
                return deliveryPointAddress;
            }
            set
            {
                deliveryPointAddress = value;
            }
        }

        public DPDetails(decimal DeliveryPointId, string DeliveryPointName, string DeliveryPointAddress)
        {
            this.DeliveryPointId = DeliveryPointId;
            this.DeliveryPointName = DeliveryPointName;
            this.DeliveryPointAddress = DeliveryPointAddress;
        }
    }

}
