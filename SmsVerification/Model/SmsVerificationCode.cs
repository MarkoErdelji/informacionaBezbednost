﻿namespace IB_projekat.SmsVerification.Model
{
    public class SmsVerificationCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Expires { get; set; }
        public int UserId { get; set; }
    }
}
