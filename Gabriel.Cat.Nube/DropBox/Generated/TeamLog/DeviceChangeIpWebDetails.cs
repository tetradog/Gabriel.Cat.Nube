// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>IP address associated with active Web session changed.</para>
    /// </summary>
    public class DeviceChangeIpWebDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceChangeIpWebDetails> Encoder = new DeviceChangeIpWebDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceChangeIpWebDetails> Decoder = new DeviceChangeIpWebDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceChangeIpWebDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="userAgent">Web browser name.</param>
        /// <param name="deviceInfo">Device information. Might be missing due to historical
        /// data gap.</param>
        public DeviceChangeIpWebDetails(string userAgent,
                                        DeviceLogInfo deviceInfo = null)
        {
            if (userAgent == null)
            {
                throw new sys.ArgumentNullException("userAgent");
            }

            this.UserAgent = userAgent;
            this.DeviceInfo = deviceInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceChangeIpWebDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceChangeIpWebDetails()
        {
        }

        /// <summary>
        /// <para>Web browser name.</para>
        /// </summary>
        public string UserAgent { get; protected set; }

        /// <summary>
        /// <para>Device information. Might be missing due to historical data gap.</para>
        /// </summary>
        public DeviceLogInfo DeviceInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceChangeIpWebDetails" />.</para>
        /// </summary>
        private class DeviceChangeIpWebDetailsEncoder : enc.StructEncoder<DeviceChangeIpWebDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceChangeIpWebDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("user_agent", value.UserAgent, writer, enc.StringEncoder.Instance);
                if (value.DeviceInfo != null)
                {
                    WriteProperty("device_info", value.DeviceInfo, writer, global::Dropbox.Api.TeamLog.DeviceLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceChangeIpWebDetails" />.</para>
        /// </summary>
        private class DeviceChangeIpWebDetailsDecoder : enc.StructDecoder<DeviceChangeIpWebDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceChangeIpWebDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceChangeIpWebDetails Create()
            {
                return new DeviceChangeIpWebDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceChangeIpWebDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "user_agent":
                        value.UserAgent = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "device_info":
                        value.DeviceInfo = global::Dropbox.Api.TeamLog.DeviceLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
