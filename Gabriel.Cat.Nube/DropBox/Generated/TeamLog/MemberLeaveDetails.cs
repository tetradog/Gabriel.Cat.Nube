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
    /// <para>Removed a team member.</para>
    /// </summary>
    public class MemberLeaveDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberLeaveDetails> Encoder = new MemberLeaveDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberLeaveDetails> Decoder = new MemberLeaveDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberLeaveDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="memberWasOnTeam">True if the member had joined the team before
        /// leaving, False otherwise.</param>
        public MemberLeaveDetails(bool memberWasOnTeam)
        {
            this.MemberWasOnTeam = memberWasOnTeam;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberLeaveDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberLeaveDetails()
        {
        }

        /// <summary>
        /// <para>True if the member had joined the team before leaving, False
        /// otherwise.</para>
        /// </summary>
        public bool MemberWasOnTeam { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberLeaveDetails" />.</para>
        /// </summary>
        private class MemberLeaveDetailsEncoder : enc.StructEncoder<MemberLeaveDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberLeaveDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("member_was_on_team", value.MemberWasOnTeam, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberLeaveDetails" />.</para>
        /// </summary>
        private class MemberLeaveDetailsDecoder : enc.StructDecoder<MemberLeaveDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberLeaveDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberLeaveDetails Create()
            {
                return new MemberLeaveDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberLeaveDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "member_was_on_team":
                        value.MemberWasOnTeam = enc.BooleanDecoder.Instance.Decode(reader);
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
