// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list users on folder args object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Paper.RefPaperDoc" />
    public class ListUsersOnFolderArgs : RefPaperDoc
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListUsersOnFolderArgs> Encoder = new ListUsersOnFolderArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListUsersOnFolderArgs> Decoder = new ListUsersOnFolderArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListUsersOnFolderArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="docId">The Paper doc ID.</param>
        /// <param name="limit">Size limit per batch. The maximum number of users that can be
        /// retrieved per batch is 1000. Higher value results in invalid arguments
        /// error.</param>
        public ListUsersOnFolderArgs(string docId,
                                     int limit = 1000)
            : base(docId)
        {
            if (limit < 1)
            {
                throw new sys.ArgumentOutOfRangeException("limit", "Value should be greater or equal than 1");
            }
            if (limit > 1000)
            {
                throw new sys.ArgumentOutOfRangeException("limit", "Value should be less of equal than 1000");
            }

            this.Limit = limit;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListUsersOnFolderArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListUsersOnFolderArgs()
        {
            this.Limit = 1000;
        }

        /// <summary>
        /// <para>Size limit per batch. The maximum number of users that can be retrieved per
        /// batch is 1000. Higher value results in invalid arguments error.</para>
        /// </summary>
        public int Limit { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListUsersOnFolderArgs" />.</para>
        /// </summary>
        private class ListUsersOnFolderArgsEncoder : enc.StructEncoder<ListUsersOnFolderArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListUsersOnFolderArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("doc_id", value.DocId, writer, enc.StringEncoder.Instance);
                WriteProperty("limit", value.Limit, writer, enc.Int32Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListUsersOnFolderArgs" />.</para>
        /// </summary>
        private class ListUsersOnFolderArgsDecoder : enc.StructDecoder<ListUsersOnFolderArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListUsersOnFolderArgs"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListUsersOnFolderArgs Create()
            {
                return new ListUsersOnFolderArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListUsersOnFolderArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "doc_id":
                        value.DocId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "limit":
                        value.Limit = enc.Int32Decoder.Instance.Decode(reader);
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
