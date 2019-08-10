﻿using System;

namespace StagWare.FanControl.Configurations
{
    public enum RegisterWriteMode
    {
        Set,
        And,
        Or
    }

    public enum RegisterWriteOccasion
    {
        OnWriteFanSpeed,
        OnInitialization
    }

    public class RegisterWriteConfiguration : ICloneable
    {
        #region Properties

        public RegisterWriteMode WriteMode { get; set; }
        public RegisterWriteOccasion WriteOccasion { get; set; }
        public int Register { get; set; }
        public int Value { get; set; }
        public bool ResetRequired { get; set; }
        public int ResetValue { get; set; }
        public RegisterWriteMode ResetWriteMode { get; set; }
        public string Description { get; set; }

        #endregion

        #region ICloneable implementation

        public object Clone()
        {
            return new RegisterWriteConfiguration()
            {
                WriteMode = this.WriteMode,
                WriteOccasion = this.WriteOccasion,
                Register = this.Register,
                Value = this.Value,
                ResetRequired = this.ResetRequired,
                ResetValue = this.ResetValue,
                ResetWriteMode = this.ResetWriteMode,
                Description = this.Description
            };
        }

        #endregion
    }
}
