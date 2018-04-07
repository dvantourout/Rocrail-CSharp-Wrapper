using System;

namespace RocrailLib_v4
{
    public partial class CRocrail
    {
        public event EventHandler ConnectionLost;
        public event EventHandler Connected;
        public event EventHandler PlanLoaded;

        public event EventHandler<ElementEventArgs> ElementReceived;
        public event EventHandler<ElementEventArgs> ElementUpdated;
        public event EventHandler<ElementEventArgs> ElementAdded;

        public event EventHandler<TrameEventArgs> TrameSend;
        public event EventHandler<TrameEventArgs> TrameReceived;
    }
}
