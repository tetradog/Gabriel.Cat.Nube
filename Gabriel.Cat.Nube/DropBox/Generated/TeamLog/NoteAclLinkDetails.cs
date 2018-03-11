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
    /// <para>Changed a Paper document to be link accessible.</para>
    /// </summary>
    public class NoteAclLinkDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<NoteAclLinkDetails> Encoder = new NoteAclLinkDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<NoteAclLinkDetails> Decoder = new NoteAclLinkDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NoteAclLinkDetails" />
        /// class.</para>
        /// </summary>
        public NoteAclLinkDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="NoteAclLinkDetails" />.</para>
        /// </summary>
        private class NoteAclLinkDetailsEncoder : enc.StructEncoder<NoteAclLinkDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(NoteAclLinkDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="NoteAclLinkDetails" />.</para>
        /// </summary>
        private class NoteAclLinkDetailsDecoder : enc.StructDecoder<NoteAclLinkDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="NoteAclLinkDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override NoteAclLinkDetails Create()
            {
                return new NoteAclLinkDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(NoteAclLinkDetails value, string fieldName, enc.IJsonReader reader)
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
