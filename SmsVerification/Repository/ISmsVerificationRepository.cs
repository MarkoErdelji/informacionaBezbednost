﻿using IB_projekat.SmsVerification.Model;

namespace IB_projekat.SmsVerification.Repository
{
    public interface ISmsVerificationRepository
    {
        Task AddOne(SmsVerificationCode smsCode);
        Task DeleteOne(SmsVerificationCode smsCode);
        Task<SmsVerificationCode> GetByCode(string code);
        Task<List<SmsVerificationCode>> GetByUserId(int userId);

    }
}