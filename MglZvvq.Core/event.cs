using System;
using System.Collections.Generic;
using System.Text;

namespace MglZvvq.Core
{
    public class Event
    {
        public Guid EntityId { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class CreatedGaojian : Event
    {
       // public CurrencyCode Currency { get; set; }
    }

    public class UpdateGaojian : Event
    {
        public decimal By { get; set; }
    }

    public class AutoUpdateGaojian  : Event { }

    public class DeleteGaojian : Event
    {
        public decimal Amount { get; set; }
        public Guid BranchId { get; set; }
    }

    /// <summary>
    /// 废弃稿件
    /// </summary>
    public class DiscardGaojian : Event
    {
        public string Beneficiary { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }

        public decimal DebitedAmount { get; set; }
        public string Reference { get; set; }
    }

    public class TransforGaojian : Event
    {
        public decimal Amount { get; }
        public string Description { get; }
    }

    public class SubmitVerfyGaojian : Event
    {
        public decimal Amount { get; }
        public string Description { get; }
    }

    public class VerifyGaojian : Event
    {
        public decimal Amount { get; }
        public string Description { get; }
    }

    public class copyGaojian : Event
    {
        public decimal Amount { get; }
        public string Description { get; }
    }

  public  class UseGaojian : Event
    {
        public decimal Amount { get; }
        public string Description { get; }
    }

}
