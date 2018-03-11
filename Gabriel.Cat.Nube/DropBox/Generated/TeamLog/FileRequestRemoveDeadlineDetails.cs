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
    /// <para>Removed the file request deadline.</para>
    /// </summary>
    public class FileRequestRemoveDeadlineDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestRemoveDeadlineDetails> Encoder = new FileRequestRemoveDeadlineDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestRemoveDeadlineDetails> Decoder = new FileRequestRemoveDeadlineDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="FileRequestRemoveDeadlineDetails" /> class.</para>
        /// </summary>
        /// <param name="fileRequestId">File request id. Might be missing due to historical
        /// data gap.</param>
        /// <param name="requestTitle">File request title.</param>
        public FileRequestRemoveDeadlineDetails(string fileRequestId = null,
                                                string requestTitle = null)
        {
            if (fileRequestId != null)
            {
                if (fileRequestId.Length < 1)
                {
                    throw new sys.ArgumentOutOfRangeException("fileRequestId", "Length should be at least 1");
                }
                if (!re.Regex.IsMatch(fileRequestId, @"\A(?:[-_0-9a-zA-Z]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("fileRequestId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z]+)\z'");
                }
            }

            this.FileRequestId = fileRequestId;
            this.RequestTitle = requestTitle;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="FileRequestRemoveDeadlineDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRequestRemoveDeadlineDetails()
        {
        }

        /// <summary>
        /// <para>File request id. Might be missing due to historical data gap.</para>
        /// </summary>
        public string FileRequestId { get; protected set; }

        /// <summary>
        /// <para>File request title.</para>
        /// </summary>
        public string RequestTitle { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestRemoveDeadlineDetails" />.</para>
        /// </summary>
        private class FileRequestRemoveDeadlineDetailsEncoder : enc.StructEncoder<FileRequestRemoveDeadlineDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestRemoveDeadlineDetails value, enc.IJsonWriter writer)
            {
                if (value.FileRequestId != null)
                {
                    WriteProperty("file_request_id", value.FileRequestId, writer, enc.StringEncoder.Instance);
                }
                if (value.RequestTitle != null)
                {
                    WriteProperty("request_title", value.RequestTitle, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestRemoveDeadlineDetails" />.</para>
        /// </summary>
        private class FileRequestRemoveDeadlineDetailsDecoder : enc.StructDecoder<FileRequestRemoveDeadlineDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="FileRequestRemoveDeadlineDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestRemoveDeadlineDetails Create()
            {
                return new FileRequestRemoveDeadlineDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestRemoveDeadlineDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file_request_id":
                        value.FileRequestId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "request_title":
                        value.RequestTitle = enc.StringDecoder.Instance.Decode(reader);
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
