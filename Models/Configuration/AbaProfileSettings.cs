using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Creator.ABA.Models.Configuration
{
    public class AbaProfileSettings : INotifyPropertyChanged
    {
        private PaymentSender _activePayer;
        private List<PaymentSender> _payers;
        private List<PaymentRecipient> _payees;

        [Required, MinLength(1, ErrorMessage = "At least one payer must be configured")]
        public List<PaymentSender> Payers { 
            get => _payers; 
            set {
                if (_payers != value)
                {
                    _payers = value;
                    OnPropertyChanged(nameof(Payers));
                }
            }
        }

        [Required]
        public List<PaymentRecipient> Payees
        {
            get => _payees;
            set
            {
                if (_payees != value)
                {
                    _payees = value;
                    OnPropertyChanged(nameof(Payees));
                }
            }
        }

        [Required(ErrorMessage = "An active payer must be set")]
        public PaymentSender ActivePayer
        {
            get => _activePayer;
            set
            {
                if (_activePayer != value)
                {
                    _activePayer = value;
                    OnPropertyChanged(nameof(ActivePayer));
                }
            }
        }

        public AbaProfileSettings()
        {
            Payers = new List<PaymentSender>();
            Payees = new List<PaymentRecipient>();
            ActivePayer = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
