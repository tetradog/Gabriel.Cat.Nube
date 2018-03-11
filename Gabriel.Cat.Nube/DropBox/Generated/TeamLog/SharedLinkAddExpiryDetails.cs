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
    /// <para>Added a shared link expiration date.</para>
    /// </summary>
    public class SharedLinkAddExpiryDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedLinkAddExpiryDetails> Encoder = new SharedLinkAddExpiryDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedLinkAddExpiryDetails> Decoder = new SharedLinkAddExpiryDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkAddExpiryDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New shared link expiration date.</param>
        public SharedLinkAddExpiryDetails(sys.DateTime newValue)
        {
            this.NewValue = newValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkAddExpiryDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedLinkAddExpiryDetails()
        {
        }

        /// <summary>
        /// <para>New shared link expiration date.</para>
        /// </summary>
        public sys.DateTime NewValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedLinkAddExpiryDetails" />.</para>
        /// </summary>
        private class SharedLinkAddExpiryDetailsEncoder : enc.StructEncoder<SharedLinkAddExpiryDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedLinkAddExpiryDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, enc.DateTimeEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedLinkAddExpiryDetails" />.</para>
        /// </summary>
        private class SharedLinkAddExpiryDetailsDecoder : enc.StructDecoder<SharedLinkAddExpiryDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedLinkAddExpiryDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedLinkAddExpiryDetails Create()
            {
                return new SharedLinkAddExpiryDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedLinkAddExpiryDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = enc.DateTimeDecoder.Instance.Decode(reader);
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
