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
    /// <para>The file request receive file type object</para>
    /// </summary>
    public class FileRequestReceiveFileType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestReceiveFileType> Encoder = new FileRequestReceiveFileTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestReceiveFileType> Decoder = new FileRequestReceiveFileTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestReceiveFileType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public FileRequestReceiveFileType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestReceiveFileType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRequestReceiveFileType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the file request receive file type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestReceiveFileType" />.</para>
        /// </summary>
        private class FileRequestReceiveFileTypeEncoder : enc.StructEncoder<FileRequestReceiveFileType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestReceiveFileType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestReceiveFileType" />.</para>
        /// </summary>
        private class FileRequestReceiveFileTypeDecoder : enc.StructDecoder<FileRequestReceiveFileType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileRequestReceiveFileType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestReceiveFileType Create()
            {
                return new FileRequestReceiveFileType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestReceiveFileType value, string fieldName, enc.IJsonReader reader)
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
