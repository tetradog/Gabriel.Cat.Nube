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
    /// <para>The emm refresh auth token type object</para>
    /// </summary>
    public class EmmRefreshAuthTokenType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EmmRefreshAuthTokenType> Encoder = new EmmRefreshAuthTokenTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EmmRefreshAuthTokenType> Decoder = new EmmRefreshAuthTokenTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmmRefreshAuthTokenType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public EmmRefreshAuthTokenType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmmRefreshAuthTokenType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public EmmRefreshAuthTokenType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the emm refresh auth token type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EmmRefreshAuthTokenType" />.</para>
        /// </summary>
        private class EmmRefreshAuthTokenTypeEncoder : enc.StructEncoder<EmmRefreshAuthTokenType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EmmRefreshAuthTokenType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EmmRefreshAuthTokenType" />.</para>
        /// </summary>
        private class EmmRefreshAuthTokenTypeDecoder : enc.StructDecoder<EmmRefreshAuthTokenType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="EmmRefreshAuthTokenType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EmmRefreshAuthTokenType Create()
            {
                return new EmmRefreshAuthTokenType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EmmRefreshAuthTokenType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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
