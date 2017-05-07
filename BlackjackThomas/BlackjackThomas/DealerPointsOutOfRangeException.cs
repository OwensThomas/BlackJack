using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackThomas
{
    [Serializable()]
    public class DealerPointsOutOfRangeException : Exception
    {
        public DealerPointsOutOfRangeException() : base() { MessageBox.Show("IL BANCO HA SBALLATO\n    !!!  HAI VINTO   !!!", "IL BANCO HA SBALLATO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        public DealerPointsOutOfRangeException(string message) : base(message) { }
        public DealerPointsOutOfRangeException(string message, Exception inner) : base(message, inner) { }

        protected DealerPointsOutOfRangeException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
