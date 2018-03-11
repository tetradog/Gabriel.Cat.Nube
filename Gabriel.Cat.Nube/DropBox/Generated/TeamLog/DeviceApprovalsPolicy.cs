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
    /// <para>The device approvals policy object</para>
    /// </summary>
    public class DeviceApprovalsPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceApprovalsPolicy> Encoder = new DeviceApprovalsPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceApprovalsPolicy> Decoder = new DeviceApprovalsPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceApprovalsPolicy" />
        /// class.</para>
        /// </summary>
        public DeviceApprovalsPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unlimited</para>
        /// </summary>
        public bool IsUnlimited
        {
            get
            {
                return this is Unlimited;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unlimited, or <c>null</c>.</para>
        /// </summary>
        public Unlimited AsUnlimited
        {
            get
            {
                return this as Unlimited;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Limited</para>
        /// </summary>
        public bool IsLimited
        {
            get
            {
                return this is Limited;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Limited, or <c>null</c>.</para>
        /// </summary>
        public Limited AsLimited
        {
            get
            {
                return this as Limited;
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
        /// <para>Encoder for  <see cref="DeviceApprovalsPolicy" />.</para>
        /// </summary>
        private class DeviceApprovalsPolicyEncoder : enc.StructEncoder<DeviceApprovalsPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceApprovalsPolicy value, enc.IJsonWriter writer)
            {
                if (value is Unlimited)
                {
                    WriteProperty(".tag", "unlimited", writer, enc.StringEncoder.Instance);
                    Unlimited.Encoder.EncodeFields((Unlimited)value, writer);
                    return;
                }
                if (value is Limited)
                {
                    WriteProperty(".tag", "limited", writer, enc.StringEncoder.Instance);
                    Limited.Encoder.EncodeFields((Limited)value, writer);
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
        /// <para>Decoder for  <see cref="DeviceApprovalsPolicy" />.</para>
        /// </summary>
        private class DeviceApprovalsPolicyDecoder : enc.UnionDecoder<DeviceApprovalsPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceApprovalsPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceApprovalsPolicy Create()
            {
                return new DeviceApprovalsPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeviceApprovalsPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "unlimited":
                        return Unlimited.Decoder.DecodeFields(reader);
                    case "limited":
                        return Limited.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The unlimited object</para>
        /// </summary>
        public sealed class Unlimited : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unlimited> Encoder = new UnlimitedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unlimited> Decoder = new UnlimitedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unlimited" /> class.</para>
            /// </summary>
            private Unlimited()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unlimited</para>
            /// </summary>
            public static readonly Unlimited Instance = new Unlimited();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unlimited" />.</para>
            /// </summary>
            private class UnlimitedEncoder : enc.StructEncoder<Unlimited>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unlimited value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unlimited" />.</para>
            /// </summary>
            private class UnlimitedDecoder : enc.StructDecoder<Unlimited>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unlimited" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unlimited Create()
                {
                    return Unlimited.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The limited object</para>
        /// </summary>
        public sealed class Limited : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Limited> Encoder = new LimitedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Limited> Decoder = new LimitedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Limited" /> class.</para>
            /// </summary>
            private Limited()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Limited</para>
            /// </summary>
            public static readonly Limited Instance = new Limited();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Limited" />.</para>
            /// </summary>
            private class LimitedEncoder : enc.StructEncoder<Limited>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Limited value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Limited" />.</para>
            /// </summary>
            private class LimitedDecoder : enc.StructDecoder<Limited>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Limited" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Limited Create()
                {
                    return Limited.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DeviceApprovalsPolicy
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
