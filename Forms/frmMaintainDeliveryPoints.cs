using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS;
using ComponentFactory.Krypton.Toolkit;
namespace POCS
{
    public partial class frmMaintainDeliveryPoints : KryptonForm
    {
        #region Constructors

        public frmMaintainDeliveryPoints()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<DeliveryPoint> deliverypointList = new BindingList<DeliveryPoint>(DeliveryPoint.GetEntityList());
            dpBindingSource.DataSource = deliverypointList;
        }

        private void Save()
        {
            dpBindingSource.EndEdit();
            DeliveryPoint deliverypoint = dpBindingSource.Current as DeliveryPoint;
            //BindingList<DeliveryPoint> OrderList = (BindingList<DeliveryPoint>)userBindingSource.DataSource;
            //DeliveryPoint DeliveryPoint = OrderList[userBindingSource.Position];

            DeliveryPoint.SaveEntity(deliverypoint);

            BindingList<DeliveryPoint> orderList = new BindingList<DeliveryPoint>(DeliveryPoint.GetEntityList());
            dpBindingSource.DataSource = orderList;

            MessageBox.Show("Delivery Point was saved.");
        }

        private void Delete()
        {
            DeliveryPoint deliverypoint = dpBindingSource.Current as DeliveryPoint;
            // (BindingList<DeliveryPoint>)userBindingSource.DataSource;
            //DeliveryPoint deliverypoint = OrderList[userBindingSource.Position];

            decimal DeliveryPointID = deliverypoint.DeliveryPointID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete Delivery Point # {0}?", DeliveryPointID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                DeliveryPoint.DeleteEntity(deliverypoint);
                dpBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("DeliveryPoint # {0} was deleted.", DeliveryPointID.ToString()));
            }
        }

        #endregion

        #region Form Events

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolBtnFindOrderNumber_Click(object sender, EventArgs e)
        {
            List<DeliveryPoint> orderList = new List<DeliveryPoint>(dpBindingSource.DataSource as BindingList<DeliveryPoint>);
            DeliveryPointFilter userFilter = new DeliveryPointFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<DeliveryPoint> filterByOrderID = new Predicate<DeliveryPoint>(orderFilter.MatchesOrderID);
            Predicate<DeliveryPoint> filterByOrderID = new Predicate<DeliveryPoint>(userFilter.BeginsWithOrderID);
            DeliveryPoint deliverypoint = orderList.Find(filterByOrderID);
            if (deliverypoint == null)
                MessageBox.Show("No matching DeliveryPoint found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = dpBindingSource.IndexOf(deliverypoint);
                dpBindingSource.Position = index;
            }
        }

        private void toolTxtFindOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Digits are OK & Backspace key is OK.
            // Otherwise, swallow the invalid key 
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == '\b')))
                e.Handled = true;
        }
        
        #endregion

        #region DeliveryPointFilter Class

        private class DeliveryPointFilter
        {
            private int DeliveryPointID = 0;

            public DeliveryPointFilter(int DeliveryPointID)
            {
                this.DeliveryPointID = DeliveryPointID;
            }
            public bool MatchesOrderID(DeliveryPoint deliverypoint)
            {
                return deliverypoint.DeliveryPointID == DeliveryPointID;
            }
            public bool BeginsWithOrderID(DeliveryPoint deliverypoint)
            {
                return deliverypoint.DeliveryPointID.ToString().StartsWith(DeliveryPointID.ToString());
            }
        }

        #endregion

        private void Orders_CustomObjects_Load(object sender, EventArgs e)
        {

        }
    }
}          