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
    /// <para>Removed the expiration date from a link.</para>
    /// </summary>
    public class ShmodelRemoveExpirationDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShmodelRemoveExpirationDetails> Encoder = new ShmodelRemoveExpirationDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShmodelRemoveExpirationDetails> Decoder = new ShmodelRemoveExpirationDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShmodelRemoveExpirationDetails"
        /// /> class.</para>
        /// </summary>
        public ShmodelRemoveExpirationDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShmodelRemoveExpirationDetails" />.</para>
        /// </summary>
        private class ShmodelRemoveExpirationDetailsEncoder : enc.StructEncoder<ShmodelRemoveExpirationDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShmodelRemoveExpirationDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShmodelRemoveExpirationDetails" />.</para>
        /// </summary>
        private class ShmodelRemoveExpirationDetailsDecoder : enc.StructDecoder<ShmodelRemoveExpirationDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShmodelRemoveExpirationDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShmodelRemoveExpirationDetails Create()
            {
                return new ShmodelRemoveExpirationDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShmodelRemoveExpirationDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
