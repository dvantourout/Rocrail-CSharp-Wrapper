using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RocrailLib_v4.Elements;

namespace RocrailLib_v4
{
    partial class CRocrail
    {
        // Accesseur rapide au liste d'objets du plan
        public List<ac> ListAc
        {
            get { return this._returnPropertyValue<ac>("aclist"); }
        }

        public List<bk> ListBk
        {
            get { return this._returnPropertyValue<bk>("bklist"); }
        }

        public List<booster> ListBooster
        {
            get { return this._returnPropertyValue<booster>("boosterlist"); }
        }

        public List<car> ListCar
        {
            get { return this._returnPropertyValue<car>("carlist"); }
        }

        public List<co> ListCo
        {
            get { return this._returnPropertyValue<co>("colist"); }
        }

        public List<dec> ListDec
        {
            get { return this._returnPropertyValue<dec>("Declist"); }
        }

        public List<digint> ListDigint
        {
            get { return this._returnPropertyValue<digint>("digintlist"); }
        }

        public List<fb> ListFb
        {
            get { return this._returnPropertyValue<fb>("fblist"); }
        }

        public List<lc> ListLc
        {
            get { return this._returnPropertyValue<lc>("lclist"); }
        }

        public List<link> ListLink
        {
            get { return this._returnPropertyValue<link>("linklist"); }
        }

        public List<location> ListLocation
        {
            get { return this._returnPropertyValue<location>("locationlist"); }
        }

        public List<mv> ListMv
        {
            get { return this._returnPropertyValue<mv>("mvlist"); }
        }

        public List<@operator> ListOperator
        {
            get { return this._returnPropertyValue<@operator>("operatorlist"); }
        }

        public List<sb> ListSb
        {
            get { return this._returnPropertyValue<sb>("sblist"); }
        }

        public List<sc> ListSc
        {
            get { return this._returnPropertyValue<sc>("sclist"); }
        }

        public List<seltab> ListSeltab
        {
            get { return this._returnPropertyValue<seltab>("seltablist"); }
        }

        public List<sg> ListSg
        {
            get { return this._returnPropertyValue<sg>("sglist"); }
        }

        public List<st> ListSt
        {
            get { return this._returnPropertyValue<st>("stlist"); }
        }

        public List<sw> ListSw
        {
            get { return this._returnPropertyValue<sw>("swlist"); }
        }

        public List<system> ListSystem
        {
            get { return this._returnPropertyValue<system>("systemlist"); }
        }

        public List<tk> ListTk
        {
            get { return this._returnPropertyValue<tk>("tklist"); }
        }

        public List<tour> ListTour
        {
            get { return this._returnPropertyValue<tour>("tourlist"); }
        }

        public List<traverser> ListTraverser
        {
            get { return this._returnPropertyValue<traverser>("traverserlist"); }
        }

        public List<tt> ListTt
        {
            get { return this._returnPropertyValue<tt>("ttlist"); }
        }

        public List<tx> ListTx
        {
            get { return this._returnPropertyValue<tx>("txlist"); }
        }

        public List<waybill> ListWayBill
        {
            get { return this._returnPropertyValue<waybill>("waybilllist"); }
        }

        public List<zlevel> ListZlevel
        {
            get { return this._returnPropertyValue<zlevel>("zlevellist"); }
        }
    }
}
