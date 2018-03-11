// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The revoke device session batch arg object</para>
    /// </summary>
    public class RevokeDeviceSessionBatchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeDeviceSessionBatchArg> Encoder = new RevokeDeviceSessionBatchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeDeviceSessionBatchArg> Decoder = new RevokeDeviceSessionBatchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionBatchArg" />
        /// class.</para>
        /// </summary>
        /// <param name="revokeDevices">The revoke devices</param>
        public RevokeDeviceSessionBatchArg(col.IEnumerable<RevokeDeviceSessionArg> revokeDevices)
        {
            var revokeDevicesList = enc.Util.ToList(revokeDevices);

            if (revokeDevices == null)
            {
                throw new sys.ArgumentNullException("revokeDevices");
            }

            this.RevokeDevices = revokeDevicesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionBatchArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RevokeDeviceSessionBatchArg()
        {
        }

        /// <summary>
        /// <para>Gets the revoke devices of the revoke device session batch arg</para>
        /// </summary>
        public col.IList<RevokeDeviceSessionArg> RevokeDevices { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RevokeDeviceSessionBatchArg" />.</para>
        /// </summary>
        private class RevokeDeviceSessionBatchArgEncoder : enc.StructEncoder<RevokeDeviceSessionBatchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeDeviceSessionBatchArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("revoke_devices", value.RevokeDevices, writer, global::Dropbox.Api.Team.RevokeDeviceSessionArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RevokeDeviceSessionBatchArg" />.</para>
        /// </summary>
        private class RevokeDeviceSessionBatchArgDecoder : enc.StructDecoder<RevokeDeviceSessionBatchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeDeviceSessionBatchArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeDeviceSessionBatchArg Create()
            {
                return new RevokeDeviceSessionBatchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RevokeDeviceSessionBatchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "revoke_devices":
                        value.RevokeDevices = ReadList<RevokeDeviceSessionArg>(reader, global::Dropbox.Api.Team.RevokeDeviceSessionArg.Decoder);
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
