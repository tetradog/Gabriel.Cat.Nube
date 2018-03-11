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
    /// <para>The list team devices error object</para>
    /// </summary>
    public class ListTeamDevicesError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListTeamDevicesError> Encoder = new ListTeamDevicesErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListTeamDevicesError> Decoder = new ListTeamDevicesErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListTeamDevicesError" />
        /// class.</para>
        /// </summary>
        public ListTeamDevicesError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Reset</para>
        /// </summary>
        public bool IsReset
        {
            get
            {
                return this is Reset;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Reset, or <c>null</c>.</para>
        /// </summary>
        public Reset AsReset
        {
            get
            {
                return this as Reset;
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
        /// <para>Encoder for  <see cref="ListTeamDevicesError" />.</para>
        /// </summary>
        private class ListTeamDevicesErrorEncoder : enc.StructEncoder<ListTeamDevicesError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListTeamDevicesError value, enc.IJsonWriter writer)
            {
                if (value is Reset)
                {
                    WriteProperty(".tag", "reset", writer, enc.StringEncoder.Instance);
                    Reset.Encoder.EncodeFields((Reset)value, writer);
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
        /// <para>Decoder for  <see cref="ListTeamDevicesError" />.</para>
        /// </summary>
        private class ListTeamDevicesErrorDecoder : enc.UnionDecoder<ListTeamDevicesError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListTeamDevicesError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListTeamDevicesError Create()
            {
                return new ListTeamDevicesError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ListTeamDevicesError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "reset":
                        return Reset.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Indicates that the cursor has been invalidated. Call <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.DevicesListTeamDevicesAsync" /> again
        /// with an empty cursor to obtain a new cursor.</para>
        /// </summary>
        public sealed class Reset : ListTeamDevicesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Reset> Encoder = new ResetEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Reset> Decoder = new ResetDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Reset" /> class.</para>
            /// </summary>
            private Reset()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Reset</para>
            /// </summary>
            public static readonly Reset Instance = new Reset();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Reset" />.</para>
            /// </summary>
            private class ResetEncoder : enc.StructEncoder<Reset>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Reset value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Reset" />.</para>
            /// </summary>
            private class ResetDecoder : enc.StructDecoder<Reset>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Reset" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Reset Create()
                {
                    return Reset.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ListTeamDevicesError
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
