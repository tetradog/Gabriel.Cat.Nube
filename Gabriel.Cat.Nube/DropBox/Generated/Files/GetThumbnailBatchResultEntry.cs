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
    /// <para>The get thumbnail batch result entry object</para>
    /// </summary>
    public class GetThumbnailBatchResultEntry
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetThumbnailBatchResultEntry> Encoder = new GetThumbnailBatchResultEntryEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetThumbnailBatchResultEntry> Decoder = new GetThumbnailBatchResultEntryDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetThumbnailBatchResultEntry" />
        /// class.</para>
        /// </summary>
        public GetThumbnailBatchResultEntry()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Success</para>
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return this is Success;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Success, or <c>null</c>.</para>
        /// </summary>
        public Success AsSuccess
        {
            get
            {
                return this as Success;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Failure</para>
        /// </summary>
        public bool IsFailure
        {
            get
            {
                return this is Failure;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Failure, or <c>null</c>.</para>
        /// </summary>
        public Failure AsFailure
        {
            get
            {
                return this as Failure;
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
        /// <para>Encoder for  <see cref="GetThumbnailBatchResultEntry" />.</para>
        /// </summary>
        private class GetThumbnailBatchResultEntryEncoder : enc.StructEncoder<GetThumbnailBatchResultEntry>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetThumbnailBatchResultEntry value, enc.IJsonWriter writer)
            {
                if (value is Success)
                {
                    WriteProperty(".tag", "success", writer, enc.StringEncoder.Instance);
                    Success.Encoder.EncodeFields((Success)value, writer);
                    return;
                }
                if (value is Failure)
                {
                    WriteProperty(".tag", "failure", writer, enc.StringEncoder.Instance);
                    Failure.Encoder.EncodeFields((Failure)value, writer);
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
        /// <para>Decoder for  <see cref="GetThumbnailBatchResultEntry" />.</para>
        /// </summary>
        private class GetThumbnailBatchResultEntryDecoder : enc.UnionDecoder<GetThumbnailBatchResultEntry>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetThumbnailBatchResultEntry"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetThumbnailBatchResultEntry Create()
            {
                return new GetThumbnailBatchResultEntry();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GetThumbnailBatchResultEntry Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "success":
                        return Success.Decoder.DecodeFields(reader);
                    case "failure":
                        return Failure.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The success object</para>
        /// </summary>
        public sealed class Success : GetThumbnailBatchResultEntry
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Success> Encoder = new SuccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Success> Decoder = new SuccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Success" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Success(GetThumbnailBatchResultData value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Success" /> class.</para>
            /// </summary>
            private Success()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public GetThumbnailBatchResultData Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Success" />.</para>
            /// </summary>
            private class SuccessEncoder : enc.StructEncoder<Success>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Success value, enc.IJsonWriter writer)
                {
                    WriteProperty("success", value.Value, writer, global::Dropbox.Api.Files.GetThumbnailBatchResultData.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Success" />.</para>
            /// </summary>
            private class SuccessDecoder : enc.StructDecoder<Success>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Success" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Success Create()
                {
                    return new Success();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Success DecodeFields(enc.IJsonReader reader)
                {
                    return new Success(global::Dropbox.Api.Files.GetThumbnailBatchResultData.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The result for this file if it was an error.</para>
        /// </summary>
        public sealed class Failure : GetThumbnailBatchResultEntry
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Failure> Encoder = new FailureEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Failure> Decoder = new FailureDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failure" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Failure(ThumbnailError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failure" /> class.</para>
            /// </summary>
            private Failure()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public ThumbnailError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Failure" />.</para>
            /// </summary>
            private class FailureEncoder : enc.StructEncoder<Failure>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Failure value, enc.IJsonWriter writer)
                {
                    WriteProperty("failure", value.Value, writer, global::Dropbox.Api.Files.ThumbnailError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Failure" />.</para>
            /// </summary>
            private class FailureDecoder : enc.StructDecoder<Failure>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Failure" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Failure Create()
                {
                    return new Failure();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Failure value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "failure":
                            value.Value = global::Dropbox.Api.Files.ThumbnailError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GetThumbnailBatchResultEntry
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
