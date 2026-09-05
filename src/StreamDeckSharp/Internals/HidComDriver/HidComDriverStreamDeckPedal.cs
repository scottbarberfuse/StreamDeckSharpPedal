using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;

namespace StreamDeckSharp.Internals.HidComDriver;

/// <summary>
/// HID Stream Deck communication driver for the Stream Deck Pedal (input only, no display).
/// </summary>
public sealed class HidComDriverStreamDeckPedal
    : IStreamDeckHidComDriver
{
    /// <inheritdoc/>
    public int HeaderSize => 8;

    /// <inheritdoc/>
    public int ReportSize => 1024;

    /// <inheritdoc/>
    public int ExpectedFeatureReportLength => 32;

    /// <inheritdoc/>
    public int ExpectedOutputReportLength => 1024;

    /// <inheritdoc/>
    public int ExpectedInputReportLength => 512;

    /// <inheritdoc/>
    public int KeyReportOffset => 4;

    /// <inheritdoc/>
    public byte FirmwareVersionFeatureId => 5;

    /// <inheritdoc/>
    public byte SerialNumberFeatureId => 6;

    /// <inheritdoc/>
    public int FirmwareVersionReportSkip => 6;

    /// <inheritdoc/>
    public int SerialNumberReportSkip => 2;

    /// <inheritdoc/>
    public double BytesPerSecondLimit => double.PositiveInfinity;

    /// <inheritdoc/>
    public int KeyImageSize => 0;

    /// <inheritdoc/>
    public IKeyIdMapper KeyIdMapper => CommonKeyMappers.Identity;

    /// <inheritdoc/>
    public byte[] GeneratePayload(Image<Bgr24> image)
    {
        return [];
    }

    /// <inheritdoc/>
    public void PrepareDataForTransmission(
        byte[] data,
        int pageNumber,
        int payloadLength,
        int keyId,
        bool isLast
    )
    {
        throw new NotSupportedException();
    }

    /// <inheritdoc/>
    public byte[] GetBrightnessMessage(byte percent)
    {
        if (percent > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(percent));
        }

        return [];
    }

    /// <inheritdoc/>
    public byte[] GetLogoMessage()
    {
        return [];
    }
}
