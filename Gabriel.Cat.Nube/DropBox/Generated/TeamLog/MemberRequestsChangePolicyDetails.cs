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
    /// <para>Changed whether users can find the team when not invited.</para>
    /// </summary>
    public class MemberRequestsChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberRequestsChangePolicyDetails> Encoder = new MemberRequestsChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberRequestsChangePolicyDetails> Decoder = new MemberRequestsChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberRequestsChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New member change requests policy.</param>
        /// <param name="previousValue">Previous member change requests policy. Might be
        /// missing due to historical data gap.</param>
        public MemberRequestsChangePolicyDetails(MemberRequestsPolicy newValue,
                                                 MemberRequestsPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberRequestsChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberRequestsChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New member change requests policy.</para>
        /// </summary>
        public MemberRequestsPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous member change requests policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public MemberRequestsPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberRequestsChangePolicyDetails" />.</para>
        /// </summary>
        private class MemberRequestsChangePolicyDetailsEncoder : enc.StructEncoder<MemberRequestsChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberRequestsChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.MemberRequestsPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.MemberRequestsPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberRequestsChangePolicyDetails" />.</para>
        /// </summary>
        private class MemberRequestsChangePolicyDetailsDecoder : enc.StructDecoder<MemberRequestsChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberRequestsChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberRequestsChangePolicyDetails Create()
            {
                return new MemberRequestsChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberRequestsChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.MemberRequestsPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.MemberRequestsPolicy.Decoder.Decode(reader);
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
