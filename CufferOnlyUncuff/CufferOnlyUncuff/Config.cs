namespace CufferOnlyUncuff
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug messages should be shown in the console.
        /// </summary>
        [Description("Whether debug logs should be shown in the console.")]
        public bool Debug { get; set; }

        /// <summary>
        /// Gets or sets the message shown to the player on a failed uncuff.
        /// </summary>
        [Description("The message shown to the player on a failed uncuff.")]
        public string FailHint { get; set; } = "Only the person who cuffed this person can uncuff them.";

        /// <summary>
        /// Gets or sets the team to uncuff
        /// </summary>
        [Description("Same team uncuffing.(Guards, MTF, Scientist")]
        public bool Foundation { get; set; } = true;

        /// <summary>
        /// Gets or sets the team to uncuff
        /// </summary>
        [Description("Same team uncuffing.(Chaos, ClassD)")]
        public bool Insurgency { get; set; } = true;
    }
}