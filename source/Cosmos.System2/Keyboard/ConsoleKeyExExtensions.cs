using System;

namespace Cosmos.System
{
    /// <summary>
    /// Provides extension methods to the <see cref="ConsoleKeyEx"/> enumeration type.
    /// </summary>
    public static class ConsoleKeyExExtensions
    {
        /// <summary>
        /// Converts the <see cref="ConsoleKeyEx"/> enumeration value to a
        /// standard .NET <see cref="ConsoleKey"/> value.
        /// </summary>
        /// <param name="keyEx">The key value to convert.</param>
        /// <returns>The translated enumeration value..</returns>
        /// <exception cref="NotImplementedException">Thrown if the given enumeration value is unrecognized.</exception>
        public static ConsoleKey ToConsoleKey(this ConsoleKeyEx keyEx)
        {
            return keyEx switch {
                ConsoleKeyEx.NoName => ConsoleKey.NoName,
                ConsoleKeyEx.Escape => ConsoleKey.Escape,
                ConsoleKeyEx.F1 => ConsoleKey.F1,
                ConsoleKeyEx.F2 => ConsoleKey.F2,
                ConsoleKeyEx.F3 => ConsoleKey.F3,
                ConsoleKeyEx.F4 => ConsoleKey.F4,
                ConsoleKeyEx.F5 => ConsoleKey.F5,
                ConsoleKeyEx.F6 => ConsoleKey.F6,
                ConsoleKeyEx.F7 => ConsoleKey.F7,
                ConsoleKeyEx.F8 => ConsoleKey.F8,
                ConsoleKeyEx.F9 => ConsoleKey.F9,
                ConsoleKeyEx.F10 => ConsoleKey.F10,
                ConsoleKeyEx.F11 => ConsoleKey.F11,
                ConsoleKeyEx.F12 => ConsoleKey.F12,
                ConsoleKeyEx.PrintScreen => ConsoleKey.PrintScreen,
                ConsoleKeyEx.D1 => ConsoleKey.D1,
                ConsoleKeyEx.D2 => ConsoleKey.D2,
                ConsoleKeyEx.D3 => ConsoleKey.D3,
                ConsoleKeyEx.D4 => ConsoleKey.D4,
                ConsoleKeyEx.D5 => ConsoleKey.D5,
                ConsoleKeyEx.D6 => ConsoleKey.D6,
                ConsoleKeyEx.D7 => ConsoleKey.D7,
                ConsoleKeyEx.D8 => ConsoleKey.D8,
                ConsoleKeyEx.D9 => ConsoleKey.D9,
                ConsoleKeyEx.D0 => ConsoleKey.D0,
                ConsoleKeyEx.Backspace => ConsoleKey.Backspace,
                ConsoleKeyEx.Tab => ConsoleKey.Tab,
                ConsoleKeyEx.Q => ConsoleKey.Q,
                ConsoleKeyEx.W => ConsoleKey.W,
                ConsoleKeyEx.E => ConsoleKey.E,
                ConsoleKeyEx.R => ConsoleKey.R,
                ConsoleKeyEx.T => ConsoleKey.T,
                ConsoleKeyEx.Y => ConsoleKey.Y,
                ConsoleKeyEx.U => ConsoleKey.U,
                ConsoleKeyEx.I => ConsoleKey.I,
                ConsoleKeyEx.O => ConsoleKey.O,
                ConsoleKeyEx.P => ConsoleKey.P,
                ConsoleKeyEx.Enter => ConsoleKey.Enter,
                ConsoleKeyEx.A => ConsoleKey.A,
                ConsoleKeyEx.S => ConsoleKey.S,
                ConsoleKeyEx.D => ConsoleKey.D,
                ConsoleKeyEx.F => ConsoleKey.F,
                ConsoleKeyEx.G => ConsoleKey.G,
                ConsoleKeyEx.H => ConsoleKey.H,
                ConsoleKeyEx.J => ConsoleKey.J,
                ConsoleKeyEx.K => ConsoleKey.K,
                ConsoleKeyEx.L => ConsoleKey.L,
                ConsoleKeyEx.Z => ConsoleKey.Z,
                ConsoleKeyEx.X => ConsoleKey.X,
                ConsoleKeyEx.C => ConsoleKey.C,
                ConsoleKeyEx.V => ConsoleKey.V,
                ConsoleKeyEx.B => ConsoleKey.B,
                ConsoleKeyEx.N => ConsoleKey.N,
                ConsoleKeyEx.M => ConsoleKey.M,
                ConsoleKeyEx.Spacebar => ConsoleKey.Spacebar,
                ConsoleKeyEx.Insert => ConsoleKey.Insert,
                ConsoleKeyEx.Home => ConsoleKey.Home,
                ConsoleKeyEx.PageUp => ConsoleKey.PageUp,
                ConsoleKeyEx.Delete => ConsoleKey.Delete,
                ConsoleKeyEx.End => ConsoleKey.End,
                ConsoleKeyEx.PageDown => ConsoleKey.PageDown,
                ConsoleKeyEx.UpArrow => ConsoleKey.UpArrow,
                ConsoleKeyEx.DownArrow => ConsoleKey.DownArrow,
                ConsoleKeyEx.LeftArrow => ConsoleKey.LeftArrow,
                ConsoleKeyEx.RightArrow => ConsoleKey.RightArrow,
                ConsoleKeyEx.Sleep => ConsoleKey.Sleep,
                ConsoleKeyEx.BiggerThan or ConsoleKeyEx.ExclamationPoint or ConsoleKeyEx.Period => ConsoleKey.OemPeriod,
                ConsoleKeyEx.LowerThan or ConsoleKeyEx.Comma => ConsoleKey.OemComma,
                ConsoleKeyEx.NumPeriod => ConsoleKey.Decimal,
                ConsoleKeyEx.NumEnter => ConsoleKey.Enter,
                ConsoleKeyEx.Num0 => ConsoleKey.D0,
                ConsoleKeyEx.Num1 => ConsoleKey.D1,
                ConsoleKeyEx.Num2 => ConsoleKey.D2,
                ConsoleKeyEx.Num3 => ConsoleKey.D3,
                ConsoleKeyEx.Num4 => ConsoleKey.D4,
                ConsoleKeyEx.Num5 => ConsoleKey.D5,
                ConsoleKeyEx.Num6 => ConsoleKey.D6,
                ConsoleKeyEx.Num7 => ConsoleKey.D7,
                ConsoleKeyEx.Num8 => ConsoleKey.D8,
                ConsoleKeyEx.Num9 => ConsoleKey.D9,
                ConsoleKeyEx.NumDivide => ConsoleKey.Divide,
                ConsoleKeyEx.NumMultiply => ConsoleKey.Multiply,
                ConsoleKeyEx.NumMinus => ConsoleKey.OemMinus,
                ConsoleKeyEx.NumPlus => ConsoleKey.OemPlus,
                ConsoleKeyEx.Backslash => ConsoleKey.Oem5,
                ConsoleKeyEx.LBracket => ConsoleKey.Oem4,
                ConsoleKeyEx.RBracket => ConsoleKey.Oem6,
                ConsoleKeyEx.Minus => ConsoleKey.OemMinus,
                ConsoleKeyEx.Apostrophe => ConsoleKey.Oem7,
                ConsoleKeyEx.Slash => ConsoleKey.Oem2,
                ConsoleKeyEx.Equal => ConsoleKey.OemPlus,
                ConsoleKeyEx.Backquote => ConsoleKey.Oem3,
                ConsoleKeyEx.Semicolon or ConsoleKeyEx.Colon => ConsoleKey.Oem1,
                ConsoleKeyEx.OEM102 => ConsoleKey.Oem102,
                ConsoleKeyEx.LWin => ConsoleKey.LeftWindows,
                ConsoleKeyEx.RWin => ConsoleKey.RightWindows,
                _ => throw new Exception($"The given key enumeration value '{keyEx}' is unrecognized or cannot be converted to a ConsoleKey."),
            };
        }
    }
}
