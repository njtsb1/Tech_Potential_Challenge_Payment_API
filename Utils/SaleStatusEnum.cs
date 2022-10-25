using System.ComponentModel;

namespace Tech_Potential_Challenge_Payment_API.Utils
{
    public enum SaleStatusEnum
    {
        [Description("Awaiting payment")]
        awaitingPayment,
        [Description("Payment accept")]
        paymentAccept,
        [Description("Sent to carrier")]
        sentToCarrier,
        [Description("Delivered")]
        delivered,
        [Description("Canceled")]
        canceled
    }
}