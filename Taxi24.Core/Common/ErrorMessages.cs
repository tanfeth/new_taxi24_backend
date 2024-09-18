﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Common
{
    public static class ErrorMessages
    {
        public const string UserNameOrCodeIsIncorrect = "Phone number or code Incorrect";
        public const string UserNameAlreadyExists = "UserNameAlreadyExists";
        public const string UserNameOrEmailAlreadyExists = "UserNameOrEmailAlreadyExists";
        public const string FaliedToSendSms = "FaliedToSendSmsPleaseTryAgain";
        public const string SomethingWentWrong = "SomethingWentWrongPleaseContactAdminstrator";
        public const string DriverNotExists = "DriverNotExists";
        public const string UserNotRegisterd = "UserNotRegisterd";
        public const string PointsNotCorrect = "PointsNotCorrect";
        public const string LocationAlreadyExists = "LocationAlreadyExists";
        public const string LocationNotRelatedToUser = "LocationNotRelatedToUser";
        public const string RiderNotExists = "RiderNotExistsOrNotRelatedToUser";
        public const string OrderNotExists = "OrderNotExistsOrOrderNotRelatedToUser";
        public const string CannotCancellOrder = "Cannot cancell order for status :";
        public const string UserNotExists = "UserNotExists";
        public const string FailedToSendSms = "FailedToSendSms";
        public const string RiderAlreadyExists = "RiderAlreadyExists";
        public const string PromoCodeIsRequired = "PromoCodeIsRequired";
        public const string PromoCodeExpiryDateGreaterThanNow = "PromoCode ExpiryDate Must BeGreater Than Today";
        public const string PromoCodeAlreadyExists = "PromoCodeAlreadyExists";
        public const string FailedToSendEmail = "FailedToSendEmail";
        public const string CodeIsIncorrect = "CodeIsIncorrect";
        public const string UserNotRelatedToDriver = "UserNotRelatedToDriver";
        public const string DriverLicenseMustBeGreaterThanNow = "DriverLicenseMustBeGreaterThanNow";
        public const string SaudiIdExpiryDateMustBeGreaterThanNow = "SaudiIdExpiryDateMustBeGreaterThanNow";
        public const string CarNotExists = "CarNotExists";
        public const string CarNotRelatedToDriver = "CarNotRelatedToDriver";
        public const string CarInsuranceExpiryDateOrRegistrationExpiryDateMustBeGraterthanNow = "CarInsuranceExpiryDateOrRegistrationExpiryDateMustBeGraterthanNow";
        public const string CarsMustBeGreaterThanTow = "CarsMustBeGreaterThanTow";
        public const string DriverDataIsMissing = "DriverDataIsMissing";
        public const string GenderAndDateOfBirthMissing = "GenderAndDateOfBirthMissing";
        public const string UserNameOrPasswordIsInCorrect = "UserNameOrPasswordIsInCorrect";
        public const string OldPasswordIsInCorrect = "Password is incorrect";
        public const string NoDriverAvailable = "NoDriverAvailable";
        public const string OrderNotExistsOrTakedFromOtherDrivers = "OrderNotExistsOrTakedFromOtherDrivers";
        public const string NotValidStatus = "NotValidStatus";
        public const string OrderNotRelatedToDriver = "OrderNotRelatedToDriver";
        public const string UserDoseNotHasWallet = "UserDoseNotHasWallet";
        public const string UserDoseNotHasAmount = "UserDoseNotHasAmount";
        public const string CardTokenIsNullOrEmpty = "CardTokenIsNullOrEmpty";
        public const string CardIsNotExists = "CardIsNotExists";
        public const string CardNotRelatedToUser = "CardNotRelatedToUser";
        public const string OrderNotRelatedToUser = "OrderNotRelatedToUser";
        public const string TripIdIsNullOrEmpty = "TripIdIsNullOrEmpty";
        public const string CardExpiryDateMustBeGreaterThanNow = "CardExpiryDateMustBeGreaterThanNow";
        public const string CardNumberAlreadyExists = "CardNumberAlreadyExists";
        public const string CardNotExistsOrCardNotRelatedToUser = "CardNotExistsOrCardNotRelatedToUser";
        public const string TrackIdInVaild = "TrackIdInVaild";
        public const string UserAlreadyInTrip = "UserAlreadyInTrip";
        public const string AccountNotExistsOrNotRelatedToUser = "AccountNotExistsOrNotRelatedToUser";
        public const string InValidRate = "InValidRate";
        public const string UserNotInTrip = "UserNotInTrip";
        public const string UserInActive = "PleaseContactAdministrationToActivateUser";
        public const string UserDoseNotHasEnoughWallet = "UserDoseNotHasEnoughWallet";
        public const string WalletMustBeLessThanZero = "WalletMustBeLessThanZero";
        public const string UserHasAccountPleaseDeleteOldAccountOrUpdate = "UserHasAccountPleaseDeleteOldAccountOrUpdate";
        public const string PercentageMustBeLessThan100 = "Percentage must be less than 100";
        public const string OrderNotExistsOrNotRelatedToDriver = "Order NotExists Or Order Not Related To Driver";
        public const string OrderStatusNotCompletedYet = "Order Status Not Completed yet";
        public const string AlreadyHasAccount = "Already has account";
        public const string WalletAmountMustBeLessThanOrderPrice = "Wallet Amount must be less than order price.";
        public const string WalletNotFound = "Wallet Not Found";
        public const string InsufficientFunds = "Insufficient Funds";
        public const string PromoCodeNotExists = "Promo code not exists";
        public const string OrderNotExistsOrNotRelatedToUser = "Order not exists or not related to user";
        public const string PriceNotValid = "Price not valid";
        public const string TempOrderNotExists = "Order temp not exists";
        public const string IdentityNumberAlreadyExists = "Identity number already exists";
        public const string InValidLocationSelectOtherLocation = "InValid location, please select other location";
        public const string GecodingIssues = "Please check geocoding config";
        public const string FileSizeExceed5MG = "File size exceed 5 MB";
        public const string CodeAlreadyExists = "Code already exists";
        public const string PhoneNumberNotExists = "Phone number not exists";
        public const string PhoneNumberAlreadyInUse = "Phone number already exists";
        public const string NameRequired = "Full name is required";
        public const string IdentityNumberRequired = "Identity number is required";
        public const string PhoneNumberRequired = "Phone number is required";
        public const string DateOfBirth = "Date of birth  is required";
        public const string AppEnumRequired = "App Enum is required";

        public const string PlateNumberIsRequired = "Plate Number is required";
        public const string PlateRightLetterRequired = "Plate right letter required";
        public const string PlateMiddleLetterRequired = "Plate middle letter required";
        public const string PlateLeftLetterRequired = "Plate left letter required";
        public const string CarModelRequired = "Car model required";
        public const string CarTypeRequired = "Car type required";
        public const string PlateTypeRequired = "Plate type  required";
        public const string CarInsuranceExpired = "Car insurance expired";
        public const string CarRegistrationExpired = "Car registration expired";
        public const string PleaseRegisterCar = "Please register car";

    }
}
