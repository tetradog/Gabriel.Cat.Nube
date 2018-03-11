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
    /// <para>The members list continue arg object</para>
    /// </summary>
    public class MembersListContinueArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersListContinueArg> Encoder = new MembersListContinueArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersListContinueArg> Decoder = new MembersListContinueArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersListContinueArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">Indicates from what point to get the next set of
        /// members.</param>
        public MembersListContinueArg(string cursor)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersListContinueArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MembersListContinueArg()
        {
        }

        /// <summary>
        /// <para>Indicates from what point to get the next set of members.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembersListContinueArg" />.</para>
        /// </summary>
        private class MembersListContinueArgEncoder : enc.StructEncoder<MembersListContinueArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersListContinueArg value, enc.IJsonWriter writer)
            {
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembersListContinueArg" />.</para>
        /// </summary>
        private class MembersListContinueArgDecoder : enc.StructDecoder<MembersListContinueArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersListContinueArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersListContinueArg Create()
            {
                return new MembersListContinueArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MembersListContinueArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
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
