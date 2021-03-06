﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsSDK
{
    public class retrieval
    {
        public int? retrieval_id { get; set; }
        public int? company_id { get; set; }
        public int? location_id { get; set; }
        public int? user_master_id { get; set; }
        public string provider { get; set; }

        public int? bank_account_id { get; set; }
        public string bank_account_type { get; set; }
        public string bank_account_routing_number { get; set; }
        public string bank_account_account_number { get; set; }
        public string bank_account_company_name { get; set; } // NULLABLE
        public string bank_account_first_name { get; set; } // NULLABLE
        public string bank_account_last_name { get; set; } // NULLABLE
        public string bank_account_address_1 { get; set; }
        public string bank_account_address_2 { get; set; } // NULLABLE
        public string bank_account_city { get; set; }
        public string bank_account_state { get; set; }
        public string bank_account_postal_code { get; set; }
        public string bank_account_country { get; set; }
        public string bank_account_phone_country_code { get; set; }
        public string bank_account_phone { get; set; }

        public decimal? retrieval_amount { get; set; }
        public decimal? fee_amount { get; set; }
        public decimal? net_amount { get; set; }
        public DateTime? ledger_after { get; set; }
        public int? ledgered { get; set; }
        public string ledger_guid { get; set; }
        public string provider_status { get; set; }
        public string provider_status_code { get; set; }
        public string provider_status_message { get; set; }
        public string provider_capture_state { get; set; }
        public string provider_transaction_state { get; set; }
        public string settlement_transaction_token { get; set; }
        public string notes { get; set; }
        public DateTime? created { get; set; }
        public DateTime? last_update { get; set; }
    }
}
