using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBSPos.UI.Reports;
using OBS.Pos.UI.Products;
using OBS.Pos.UI.Security;
using OBS.Pos.UI.Sales;
using OBS.Pos.UI.Stock;
using OBS.Pos.UI.Suppliers;
using OBS.Pos.UI.Customers;

namespace OBS.Pos.UI.Shared
{
    public static class MenuManager
    {

        #region Report Menu
        private static frmReportViewer _frmReportViewer = new frmReportViewer();
        public static frmReportViewer ReportViewer
        {
            get
            {
                if (_frmReportViewer.IsDisposed)
                {
                    _frmReportViewer = new frmReportViewer();
                }
                return _frmReportViewer;
            }
        }
        #endregion

        #region Product Menus
        private static frmProducts _frmProducts = new frmProducts();
        public static frmProducts ProductRegister
        {
            get
            {
                if (_frmProducts.IsDisposed)
                {
                    _frmProducts = new frmProducts();
                }
                return _frmProducts;
            }
        }

        private static frmCategories _frmCategory = new frmCategories();
        public static frmCategories CategoryRegister
        {
            get
            {
                if (_frmCategory.IsDisposed)
                {
                    _frmCategory = new frmCategories();
                }
                return _frmCategory;
            }
        }
        private static frmUOM _frmUOM = new frmUOM();
        public static frmUOM UOMRegister
        {
            get
            {
                if (_frmUOM.IsDisposed)
                {
                    _frmUOM = new frmUOM();
                }
                return _frmUOM;
            }
        }
        #endregion

        #region Sales Menu
        private static frmSales _frmSales = new frmSales();
        public static frmSales SalesRegister
        {
            get
            {
                if (_frmSales.IsDisposed)
                {
                    _frmSales = new frmSales();
                }
                return _frmSales;
            }
        }
        private static frmTaxes _frmTaxes = new frmTaxes();
        public static frmTaxes TaxRegister
        {
            get
            {
                if (_frmTaxes.IsDisposed)
                {
                    _frmTaxes = new frmTaxes();
                }
                return _frmTaxes;
            }
        }
        private static frmShifts _frmShifts = new frmShifts();
        public static frmShifts ShiftRegister
        {
            get
            {
                if (_frmShifts.IsDisposed)
                {
                    _frmShifts = new frmShifts();
                }
                return _frmShifts;
            }
        }
        private static frmPayments _frmPayments = new frmPayments();
        public static frmPayments PaymentsRegister
        {
            get
            {
                if (_frmPayments.IsDisposed)
                {
                    _frmPayments = new frmPayments();
                }
                return _frmPayments;
            }
        }
        #endregion

        #region Supplier Menu
        private static frmSuppliers _frmSuppliers = new frmSuppliers();
        public static frmSuppliers SupplierRegister
        {
            get
            {
                if (_frmSuppliers.IsDisposed)
                {
                    _frmSuppliers = new frmSuppliers();
                }
                return _frmSuppliers;
            }
        }
        #endregion

        #region Customer Menu
        private static frmCustomer _frmCustomer = new frmCustomer();
        public static frmCustomer CustomerRegister
        {
            get
            {
                if (_frmCustomer.IsDisposed)
                {
                    _frmCustomer = new frmCustomer();
                }
                return _frmCustomer;
            }
        }
        #endregion

        #region Shared Menu
        private static frmCurrency _frmCurrency = new frmCurrency();
        public static frmCurrency CurrencyRegister
        {
            get
            {
                if (_frmCurrency.IsDisposed)
                {
                    _frmCurrency = new frmCurrency();
                }
                return _frmCurrency;
            }
        }
        private static frmPaymentModes _frmPaymentModes = new frmPaymentModes();
        public static frmPaymentModes PaymentModeRegister
        {
            get
            {
                if (_frmPaymentModes.IsDisposed)
                {
                    _frmPaymentModes = new frmPaymentModes();
                }
                return _frmPaymentModes;
            }
        }

        #endregion

        #region Stock menu
        private static frmLocations _frmLocations = new frmLocations();
        public static frmLocations LocationRegister
        {
            get
            {
                if (_frmLocations.IsDisposed)
                {
                    _frmLocations = new frmLocations();
                }
                return _frmLocations;
            }
        }
        private static frmStockCount _frmStockCount = new frmStockCount();
        public static frmStockCount StockCountRun
        {
            get
            {
                if (_frmStockCount.IsDisposed)
                {
                    _frmStockCount = new frmStockCount();
                }
                return _frmStockCount;
            }
        }
        private static frmStockFreeze _frmStockFreeze = new frmStockFreeze();
        public static frmStockFreeze StockFreeze
        {
            get
            {
                if (_frmStockFreeze.IsDisposed)
                {
                    _frmStockFreeze = new frmStockFreeze();
                }
                return _frmStockFreeze;
            }
        }
        private static frmStockRecieve _frmStockRecieve = new frmStockRecieve();
        public static frmStockRecieve StockRecieve
        {
            get
            {
                if (_frmStockRecieve.IsDisposed)
                {
                    _frmStockRecieve = new frmStockRecieve();
                }
                return _frmStockRecieve;
            }
        }
        private static frmStockRemove _frmStockRemove = new frmStockRemove();
        public static frmStockRemove StockRemove
        {
            get
            {
                if (_frmStockRemove.IsDisposed)
                {
                    _frmStockRemove = new frmStockRemove();
                }
                return _frmStockRemove;
            }
        }
        private static frmStockReturn _frmStockReturn = new frmStockReturn();
        public static frmStockReturn StockReturn
        {
            get
            {
                if (_frmStockReturn.IsDisposed)
                {
                    _frmStockReturn = new frmStockReturn();
                }
                return _frmStockReturn;
            }
        }
        private static frmStockTransfer _frmStockTransfer = new frmStockTransfer();
        public static frmStockTransfer StockTranfer
        {
            get
            {
                if (_frmStockTransfer.IsDisposed)
                {
                    _frmStockTransfer = new frmStockTransfer();
                }
                return _frmStockTransfer;
            }
        }
        #endregion

        #region User Menu
        private static frmUsers _frmUsers = new frmUsers();
        public static frmUsers UserRegister
        {
            get
            {
                if (_frmUsers.IsDisposed)
                {
                    _frmUsers = new frmUsers();
                }
                return _frmUsers;
            }
        }
        #endregion

    }
}
