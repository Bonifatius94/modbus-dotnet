﻿namespace PL.Modbus
{
    /// <summary>
    /// Modbus interface.
    /// </summary>
    public enum Interface { Serial, Network }

    /// <summary>
    /// Modbus protocol.
    /// </summary>
    public enum Protocol { Rtu, Ascii, Tcp }
    
    /// <summary>
    /// Modbus function code.
    /// </summary>
    public enum FunctionCode : byte
    {
        ReadCoils = 1,
        ReadDiscreteInputs = 2,
        ReadHoldingRegisters = 3,
        ReadInputRegisters = 4,
        WriteSingleCoil = 5,
        WriteSingleHoldingRegister = 6,
        WriteMultipleCoils = 15,
        WriteMultipleHoldingRegisters = 16
    }
}
