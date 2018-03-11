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
    /// <para>The external sharing policy object</para>
    /// </summary>
    public class ExternalSharingPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ExternalSharingPolicy> Encoder = new ExternalSharingPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ExternalSharingPolicy> Decoder = new ExternalSharingPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ExternalSharingPolicy" />
        /// class.</para>
        /// </summary>
        public ExternalSharingPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamOnly</para>
        /// </summary>
        public bool IsTeamOnly
        {
            get
            {
                return this is TeamOnly;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamOnly, or <c>null</c>.</para>
        /// </summary>
        public TeamOnly AsTeamOnly
        {
            get
            {
                return this as TeamOnly;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Anyone</para>
        /// </summary>
        public bool IsAnyone
        {
            get
            {
                return this is Anyone;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Anyone, or <c>null</c>.</para>
        /// </summary>
        public Anyone AsAnyone
        {
            get
            {
                return this as Anyone;
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
        /// <para>Encoder for  <see cref="ExternalSharingPolicy" />.</para>
        /// </summary>
        private class ExternalSharingPolicyEncoder : enc.StructEncoder<ExternalSharingPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ExternalSharingPolicy value, enc.IJsonWriter writer)
            {
                if (value is TeamOnly)
                {
                    WriteProperty(".tag", "team_only", writer, enc.StringEncoder.Instance);
                    TeamOnly.Encoder.EncodeFields((TeamOnly)value, writer);
                    return;
                }
                if (value is Anyone)
                {
                    WriteProperty(".tag", "anyone", writer, enc.StringEncoder.Instance);
                    Anyone.Encoder.EncodeFields((Anyone)value, writer);
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
        /// <para>Decoder for  <see cref="ExternalSharingPolicy" />.</para>
        /// </summary>
        private class ExternalSharingPolicyDecoder : enc.UnionDecoder<ExternalSharingPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ExternalSharingPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ExternalSharingPolicy Create()
            {
                return new ExternalSharingPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ExternalSharingPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "team_only":
                        return TeamOnly.Decoder.DecodeFields(reader);
                    case "anyone":
                        return Anyone.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The team only object</para>
        /// </summary>
        public sealed class TeamOnly : ExternalSharingPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamOnly> Encoder = new TeamOnlyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamOnly> Decoder = new TeamOnlyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamOnly" /> class.</para>
            /// </summary>
            private TeamOnly()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamOnly</para>
            /// </summary>
            public static readonly TeamOnly Instance = new TeamOnly();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamOnly" />.</para>
            /// </summary>
            private class TeamOnlyEncoder : enc.StructEncoder<TeamOnly>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamOnly value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamOnly" />.</para>
            /// </summary>
            private class TeamOnlyDecoder : enc.StructDecoder<TeamOnly>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamOnly" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamOnly Create()
                {
                    return TeamOnly.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The anyone object</para>
        /// </summary>
        public sealed class Anyone : ExternalSharingPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Anyone> Encoder = new AnyoneEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Anyone> Decoder = new AnyoneDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Anyone" /> class.</para>
            /// </summary>
            private Anyone()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Anyone</para>
            /// </summary>
            public static readonly Anyone Instance = new Anyone();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Anyone" />.</para>
            /// </summary>
            private class AnyoneEncoder : enc.StructEncoder<Anyone>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Anyone value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Anyone" />.</para>
            /// </summary>
            private class AnyoneDecoder : enc.StructDecoder<Anyone>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Anyone" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Anyone Create()
                {
                    return Anyone.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ExternalSharingPolicy
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
