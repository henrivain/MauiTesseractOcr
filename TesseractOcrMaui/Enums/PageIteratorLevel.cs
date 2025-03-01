﻿namespace TesseractOcrMaui.Enums;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Text block size that is processed at once.
/// </summary>
public enum PageIteratorLevel
{
    Block = 0,
    Paragraph = 1,
    TextLine = 2,
    Word = 3,
    Symbol = 4
}
