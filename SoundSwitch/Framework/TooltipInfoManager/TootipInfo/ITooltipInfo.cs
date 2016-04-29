namespace SoundSwitch.Framework.TooltipInfoManager.TootipInfo
{
    public interface ITooltipInfo
    {
        /// <summary>
        ///     Type of the Tooltip Info
        /// </summary>
        TooltipInfoTypeEnum TypeEnum { get; }

        /// <summary>
        ///     Displaying label
        /// </summary>
        string Label { get; }

        /// <summary>
        ///     The text to display for this tooltip
        /// </summary>
        /// <returns></returns>
        string TextToDisplay();
    }
}