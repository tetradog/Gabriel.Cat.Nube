// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The upload session start result object</para>
    /// </summary>
    public class UploadSessionStartResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionStartResult> Encoder = new UploadSessionStartResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionStartResult> Decoder = new UploadSessionStartResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionStartResult" />
        /// class.</para>
        /// </summary>
        /// <param name="sessionId">A unique identifier for the upload session. Pass this to
        /// <see cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionAppendV2Async" />
        /// and <see cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionFinishAsync"
        /// />.</param>
        public UploadSessionStartResult(string sessionId)
        {
            if (sessionId == null)
            {
                throw new sys.ArgumentNullException("sessionId");
            }

            this.SessionId = sessionId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionStartResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UploadSessionStartResult()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the upload session. Pass this to <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionAppendV2Async" /> and
        /// <see cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionFinishAsync"
        /// />.</para>
        /// </summary>
        public string SessionId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionStartResult" />.</para>
        /// </summary>
        private class UploadSessionStartResultEncoder : enc.StructEncoder<UploadSessionStartResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionStartResult value, enc.IJsonWriter writer)
            {
                WriteProperty("session_id", value.SessionId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionStartResult" />.</para>
        /// </summary>
        private class UploadSessionStartResultDecoder : enc.StructDecoder<UploadSessionStartResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionStartResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionStartResult Create()
            {
                return new UploadSessionStartResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionStartResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "session_id":
                        value.SessionId = enc.StringDecoder.Instance.Decode(reader);
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
