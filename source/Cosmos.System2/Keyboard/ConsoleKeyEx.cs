namespace Cosmos.System
{
    /// <summary>
    /// Specifies the recognized virtual console keys, that are independent
    /// from physical keyboard scan-codes.
    /// </summary>
    public enum ConsoleKeyEx
    {
        /// <summary>
        /// An unknown, undefined, or otherwise unrecognized key.
        /// </summary>
        NoName,

        Escape,

        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,

        PrintScreen,
        ScrollLock,
        PauseBreak,

        Backquote,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        D0,
        Minus,
        Equal,
        Backslash,
        Backspace,

        Tab,
        Q,
        W,
        E,
        R,
        T,
        Y,
        U,
        I,
        O,
        P,
        LBracket,
        RBracket,
        Enter,

        CapsLock,
        A,
        S,
        D,
        F,
        G,
        H,
        J,
        K,
        L,
        Semicolon,
        Colon,
        Apostrophe,

        LowerThan,
        BiggerThan,

        ExclamationPoint,

        LShift,
        RShift,
        OEM102, // <<=== This key does not exist on a US keyboard, but on the german one. It contains the characters `|`, `<` and `>`
        OEM5, // This one is registered as \ and | on a British keyboard. however US use the one registered as # and ~ to us.
        Z,
        X,
        C,
        V,
        B,
        N,
        M,
        Comma,
        Period,
        Slash,

        LCtrl,
        RCtrl,
        LWin,
        LAlt,
        RAlt,
        Spacebar,
        AltGr,
        RWin,
        Menu,

        Insert,
        Home,
        PageUp,
        Delete,
        End,
        PageDown,

        UpArrow,
        DownArrow,
        LeftArrow,
        RightArrow,

        NumLock,
        NumDivide,
        NumMultiply,
        NumMinus,
        Num7,
        Num8,
        Num9,
        NumPlus,
        Num4,
        Num5,
        Num6,
        Num1,
        Num2,
        Num3,
        Num0,
        NumPeriod,
        NumEnter,

        Power,
        Sleep,
        Wake
    }
}
