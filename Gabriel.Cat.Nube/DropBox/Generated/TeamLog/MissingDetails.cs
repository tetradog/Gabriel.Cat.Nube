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
    /// <para>An indication that an event was returned with missing details</para>
    /// </summary>
    public class MissingDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MissingDetails> Encoder = new MissingDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MissingDetails> Decoder = new MissingDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MissingDetails" /> class.</para>
        /// </summary>
        public MissingDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MissingDetails" />.</para>
        /// </summary>
        private class MissingDetailsEncoder : enc.StructEncoder<MissingDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MissingDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MissingDetails" />.</para>
        /// </summary>
        private class MissingDetailsDecoder : enc.StructDecoder<MissingDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MissingDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MissingDetails Create()
            {
                return new MissingDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MissingDetails value, string fieldName, enc.IJsonReader reader)
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
