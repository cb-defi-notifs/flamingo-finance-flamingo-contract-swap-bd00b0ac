using System.ComponentModel;
using System.Numerics;
using Neo;
using Neo.SmartContract.Framework;

namespace FlamingoSwapOrderBook
{
    public partial class FlamingoSwapOrderBookContract
    {
        /// <summary>
        /// When register orderbook
        /// </summary>
        [DisplayName("RegisterBook")]
        public static event RegisterBookEvent onRegisterBook;
        public delegate void RegisterBookEvent(UInt160 baseToken, UInt160 quoteToken, uint quoteDecimals);

        /// <summary>
        /// When remove orderbook
        /// </summary>
        [DisplayName("RemoveBook")]
        public static event RemoveBookEvent onRemoveBook;
        public delegate void RemoveBookEvent(UInt160 baseToken, UInt160 quoteToken);

        /// <summary>
        /// When deal order
        /// </summary>
        [DisplayName("DealOrder")]
        public static event DealOrderEvent onDealOrder;
        public delegate void DealOrderEvent(ByteString id, BigInteger price, BigInteger amount);

        /// <summary>
        /// When add order
        /// </summary>
        [DisplayName("AddOrder")]
        public static event AddOrderEvent onAddOrder;
        public delegate void AddOrderEvent(UInt160 baseToken, UInt160 quoteToken, ByteString id, bool isBuy, BigInteger price, BigInteger amount);

        /// <summary>
        /// When cancel order
        /// </summary>
        [DisplayName("CancelOrder")]
        public static event CancelOrderEvent onCancelOrder;
        public delegate void CancelOrderEvent(ByteString id, BigInteger price, BigInteger leftAmount);

        [DisplayName("Fault")]
        public static event FaultEvent onFault;
        public delegate void FaultEvent(string message, params object[] paras);
    }
}