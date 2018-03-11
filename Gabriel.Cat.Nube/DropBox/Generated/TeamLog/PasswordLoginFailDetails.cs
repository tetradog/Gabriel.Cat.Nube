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
    /// <para>Failed to sign in using a password.</para>
    /// </summary>
    public class PasswordLoginFailDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PasswordLoginFailDetails> Encoder = new PasswordLoginFailDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PasswordLoginFailDetails> Decoder = new PasswordLoginFailDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PasswordLoginFailDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="errorDetails">Login failure details.</param>
        public PasswordLoginFailDetails(FailureDetailsLogInfo errorDetails)
        {
            if (errorDetails == null)
            {
                throw new sys.ArgumentNullException("errorDetails");
            }

            this.ErrorDetails = errorDetails;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PasswordLoginFailDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PasswordLoginFailDetails()
        {
        }

        /// <summary>
        /// <para>Login failure details.</para>
        /// </summary>
        public FailureDetailsLogInfo ErrorDetails { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PasswordLoginFailDetails" />.</para>
        /// </summary>
        private class PasswordLoginFailDetailsEncoder : enc.StructEncoder<PasswordLoginFailDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PasswordLoginFailDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("error_details", value.ErrorDetails, writer, global::Dropbox.Api.TeamLog.FailureDetailsLogInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PasswordLoginFailDetails" />.</para>
        /// </summary>
        private class PasswordLoginFailDetailsDecoder : enc.StructDecoder<PasswordLoginFailDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PasswordLoginFailDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PasswordLoginFailDetails Create()
            {
                return new PasswordLoginFailDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PasswordLoginFailDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "error_details":
                        value.ErrorDetails = global::Dropbox.Api.TeamLog.FailureDetailsLogInfo.Decoder.Decode(reader);
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
