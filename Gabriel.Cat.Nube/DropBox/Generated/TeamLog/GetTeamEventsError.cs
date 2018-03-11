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
    /// <para>Errors that can be raised when calling <see
    /// cref="Dropbox.Api.TeamLog.Routes.TeamLogTeamRoutes.GetEventsAsync" />.</para>
    /// </summary>
    public class GetTeamEventsError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetTeamEventsError> Encoder = new GetTeamEventsErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetTeamEventsError> Decoder = new GetTeamEventsErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetTeamEventsError" />
        /// class.</para>
        /// </summary>
        public GetTeamEventsError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccountIdNotFound</para>
        /// </summary>
        public bool IsAccountIdNotFound
        {
            get
            {
                return this is AccountIdNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccountIdNotFound, or <c>null</c>.</para>
        /// </summary>
        public AccountIdNotFound AsAccountIdNotFound
        {
            get
            {
                return this as AccountIdNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidTimeRange</para>
        /// </summary>
        public bool IsInvalidTimeRange
        {
            get
            {
                return this is InvalidTimeRange;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidTimeRange, or <c>null</c>.</para>
        /// </summary>
        public InvalidTimeRange AsInvalidTimeRange
        {
            get
            {
                return this as InvalidTimeRange;
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
        /// <para>Encoder for  <see cref="GetTeamEventsError" />.</para>
        /// </summary>
        private class GetTeamEventsErrorEncoder : enc.StructEncoder<GetTeamEventsError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetTeamEventsError value, enc.IJsonWriter writer)
            {
                if (value is AccountIdNotFound)
                {
                    WriteProperty(".tag", "account_id_not_found", writer, enc.StringEncoder.Instance);
                    AccountIdNotFound.Encoder.EncodeFields((AccountIdNotFound)value, writer);
                    return;
                }
                if (value is InvalidTimeRange)
                {
                    WriteProperty(".tag", "invalid_time_range", writer, enc.StringEncoder.Instance);
                    InvalidTimeRange.Encoder.EncodeFields((InvalidTimeRange)value, writer);
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
        /// <para>Decoder for  <see cref="GetTeamEventsError" />.</para>
        /// </summary>
        private class GetTeamEventsErrorDecoder : enc.UnionDecoder<GetTeamEventsError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetTeamEventsError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetTeamEventsError Create()
            {
                return new GetTeamEventsError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GetTeamEventsError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "account_id_not_found":
                        return AccountIdNotFound.Decoder.DecodeFields(reader);
                    case "invalid_time_range":
                        return InvalidTimeRange.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>No user found matching the provided account_id.</para>
        /// </summary>
        public sealed class AccountIdNotFound : GetTeamEventsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccountIdNotFound> Encoder = new AccountIdNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccountIdNotFound> Decoder = new AccountIdNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccountIdNotFound" />
            /// class.</para>
            /// </summary>
            private AccountIdNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AccountIdNotFound</para>
            /// </summary>
            public static readonly AccountIdNotFound Instance = new AccountIdNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccountIdNotFound" />.</para>
            /// </summary>
            private class AccountIdNotFoundEncoder : enc.StructEncoder<AccountIdNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccountIdNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccountIdNotFound" />.</para>
            /// </summary>
            private class AccountIdNotFoundDecoder : enc.StructDecoder<AccountIdNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccountIdNotFound"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccountIdNotFound Create()
                {
                    return AccountIdNotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Invalid time range.</para>
        /// </summary>
        public sealed class InvalidTimeRange : GetTeamEventsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidTimeRange> Encoder = new InvalidTimeRangeEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidTimeRange> Decoder = new InvalidTimeRangeDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidTimeRange" />
            /// class.</para>
            /// </summary>
            private InvalidTimeRange()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidTimeRange</para>
            /// </summary>
            public static readonly InvalidTimeRange Instance = new InvalidTimeRange();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidTimeRange" />.</para>
            /// </summary>
            private class InvalidTimeRangeEncoder : enc.StructEncoder<InvalidTimeRange>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidTimeRange value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidTimeRange" />.</para>
            /// </summary>
            private class InvalidTimeRangeDecoder : enc.StructDecoder<InvalidTimeRange>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidTimeRange" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidTimeRange Create()
                {
                    return InvalidTimeRange.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GetTeamEventsError
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
