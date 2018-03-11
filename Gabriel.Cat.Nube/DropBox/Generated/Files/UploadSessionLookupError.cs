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
    /// <para>The upload session lookup error object</para>
    /// </summary>
    public class UploadSessionLookupError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionLookupError> Encoder = new UploadSessionLookupErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionLookupError> Decoder = new UploadSessionLookupErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionLookupError" />
        /// class.</para>
        /// </summary>
        public UploadSessionLookupError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IncorrectOffset</para>
        /// </summary>
        public bool IsIncorrectOffset
        {
            get
            {
                return this is IncorrectOffset;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IncorrectOffset, or <c>null</c>.</para>
        /// </summary>
        public IncorrectOffset AsIncorrectOffset
        {
            get
            {
                return this as IncorrectOffset;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Closed</para>
        /// </summary>
        public bool IsClosed
        {
            get
            {
                return this is Closed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Closed, or <c>null</c>.</para>
        /// </summary>
        public Closed AsClosed
        {
            get
            {
                return this as Closed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotClosed</para>
        /// </summary>
        public bool IsNotClosed
        {
            get
            {
                return this is NotClosed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotClosed, or <c>null</c>.</para>
        /// </summary>
        public NotClosed AsNotClosed
        {
            get
            {
                return this as NotClosed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionLookupError" />.</para>
        /// </summary>
        private class UploadSessionLookupErrorEncoder : enc.StructEncoder<UploadSessionLookupError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionLookupError value, enc.IJsonWriter writer)
            {
                if (value is NotFound)
                {
                    WriteProperty(".tag", "not_found", writer, enc.StringEncoder.Instance);
                    NotFound.Encoder.EncodeFields((NotFound)value, writer);
                    return;
                }
                if (value is IncorrectOffset)
                {
                    WriteProperty(".tag", "incorrect_offset", writer, enc.StringEncoder.Instance);
                    IncorrectOffset.Encoder.EncodeFields((IncorrectOffset)value, writer);
                    return;
                }
                if (value is Closed)
                {
                    WriteProperty(".tag", "closed", writer, enc.StringEncoder.Instance);
                    Closed.Encoder.EncodeFields((Closed)value, writer);
                    return;
                }
                if (value is NotClosed)
                {
                    WriteProperty(".tag", "not_closed", writer, enc.StringEncoder.Instance);
                    NotClosed.Encoder.EncodeFields((NotClosed)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionLookupError" />.</para>
        /// </summary>
        private class UploadSessionLookupErrorDecoder : enc.UnionDecoder<UploadSessionLookupError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionLookupError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionLookupError Create()
            {
                return new UploadSessionLookupError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UploadSessionLookupError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "not_found":
                        return NotFound.Decoder.DecodeFields(reader);
                    case "incorrect_offset":
                        return IncorrectOffset.Decoder.DecodeFields(reader);
                    case "closed":
                        return Closed.Decoder.DecodeFields(reader);
                    case "not_closed":
                        return NotClosed.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The upload session ID was not found or has expired. Upload sessions are valid
        /// for 48 hours.</para>
        /// </summary>
        public sealed class NotFound : UploadSessionLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFound> Encoder = new NotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFound> Decoder = new NotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundEncoder : enc.StructEncoder<NotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundDecoder : enc.StructDecoder<NotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFound Create()
                {
                    return NotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The specified offset was incorrect. See the value for the correct offset.
        /// This error may occur when a previous request was received and processed
        /// successfully but the client did not receive the response, e.g. due to a network
        /// error.</para>
        /// </summary>
        public sealed class IncorrectOffset : UploadSessionLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<IncorrectOffset> Encoder = new IncorrectOffsetEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<IncorrectOffset> Decoder = new IncorrectOffsetDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IncorrectOffset" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public IncorrectOffset(UploadSessionOffsetError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IncorrectOffset" />
            /// class.</para>
            /// </summary>
            private IncorrectOffset()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public UploadSessionOffsetError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="IncorrectOffset" />.</para>
            /// </summary>
            private class IncorrectOffsetEncoder : enc.StructEncoder<IncorrectOffset>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(IncorrectOffset value, enc.IJsonWriter writer)
                {
                    WriteProperty("incorrect_offset", value.Value, writer, global::Dropbox.Api.Files.UploadSessionOffsetError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="IncorrectOffset" />.</para>
            /// </summary>
            private class IncorrectOffsetDecoder : enc.StructDecoder<IncorrectOffset>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="IncorrectOffset" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override IncorrectOffset Create()
                {
                    return new IncorrectOffset();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override IncorrectOffset DecodeFields(enc.IJsonReader reader)
                {
                    return new IncorrectOffset(global::Dropbox.Api.Files.UploadSessionOffsetError.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>You are attempting to append data to an upload session that has alread been
        /// closed (i.e. committed).</para>
        /// </summary>
        public sealed class Closed : UploadSessionLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Closed> Encoder = new ClosedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Closed> Decoder = new ClosedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Closed" /> class.</para>
            /// </summary>
            private Closed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Closed</para>
            /// </summary>
            public static readonly Closed Instance = new Closed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Closed" />.</para>
            /// </summary>
            private class ClosedEncoder : enc.StructEncoder<Closed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Closed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Closed" />.</para>
            /// </summary>
            private class ClosedDecoder : enc.StructDecoder<Closed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Closed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Closed Create()
                {
                    return Closed.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The session must be closed before calling upload_session/finish_batch.</para>
        /// </summary>
        public sealed class NotClosed : UploadSessionLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotClosed> Encoder = new NotClosedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotClosed> Decoder = new NotClosedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotClosed" /> class.</para>
            /// </summary>
            private NotClosed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotClosed</para>
            /// </summary>
            public static readonly NotClosed Instance = new NotClosed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotClosed" />.</para>
            /// </summary>
            private class NotClosedEncoder : enc.StructEncoder<NotClosed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotClosed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotClosed" />.</para>
            /// </summary>
            private class NotClosedDecoder : enc.StructDecoder<NotClosed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotClosed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotClosed Create()
                {
                    return NotClosed.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UploadSessionLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
