// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The remove folder member arg object</para>
    /// </summary>
    public class RemoveFolderMemberArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemoveFolderMemberArg> Encoder = new RemoveFolderMemberArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemoveFolderMemberArg> Decoder = new RemoveFolderMemberArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemoveFolderMemberArg" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedFolderId">The ID for the shared folder.</param>
        /// <param name="member">The member to remove from the folder.</param>
        /// <param name="leaveACopy">If true, the removed user will keep their copy of the
        /// folder after it's unshared, assuming it was mounted. Otherwise, it will be removed
        /// from their Dropbox. Also, this must be set to false when kicking a group.</param>
        public RemoveFolderMemberArg(string sharedFolderId,
                                     MemberSelector member,
                                     bool leaveACopy)
        {
            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
            }

            if (member == null)
            {
                throw new sys.ArgumentNullException("member");
            }

            this.SharedFolderId = sharedFolderId;
            this.Member = member;
            this.LeaveACopy = leaveACopy;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemoveFolderMemberArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RemoveFolderMemberArg()
        {
        }

        /// <summary>
        /// <para>The ID for the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>The member to remove from the folder.</para>
        /// </summary>
        public MemberSelector Member { get; protected set; }

        /// <summary>
        /// <para>If true, the removed user will keep their copy of the folder after it's
        /// unshared, assuming it was mounted. Otherwise, it will be removed from their
        /// Dropbox. Also, this must be set to false when kicking a group.</para>
        /// </summary>
        public bool LeaveACopy { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RemoveFolderMemberArg" />.</para>
        /// </summary>
        private class RemoveFolderMemberArgEncoder : enc.StructEncoder<RemoveFolderMemberArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemoveFolderMemberArg value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("member", value.Member, writer, global::Dropbox.Api.Sharing.MemberSelector.Encoder);
                WriteProperty("leave_a_copy", value.LeaveACopy, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RemoveFolderMemberArg" />.</para>
        /// </summary>
        private class RemoveFolderMemberArgDecoder : enc.StructDecoder<RemoveFolderMemberArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemoveFolderMemberArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemoveFolderMemberArg Create()
            {
                return new RemoveFolderMemberArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RemoveFolderMemberArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member":
                        value.Member = global::Dropbox.Api.Sharing.MemberSelector.Decoder.Decode(reader);
                        break;
                    case "leave_a_copy":
                        value.LeaveACopy = enc.BooleanDecoder.Instance.Decode(reader);
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
