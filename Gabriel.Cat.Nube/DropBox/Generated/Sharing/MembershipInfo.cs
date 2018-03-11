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
    /// <para>The information about a member of the shared content.</para>
    /// </summary>
    /// <seealso cref="GroupMembershipInfo" />
    /// <seealso cref="InviteeMembershipInfo" />
    /// <seealso cref="UserMembershipInfo" />
    public class MembershipInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembershipInfo> Encoder = new MembershipInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembershipInfo> Decoder = new MembershipInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembershipInfo" /> class.</para>
        /// </summary>
        /// <param name="accessType">The access type for this member.</param>
        /// <param name="permissions">The permissions that requesting user has on this member.
        /// The set of permissions corresponds to the MemberActions in the request.</param>
        /// <param name="initials">Suggested name initials for a member.</param>
        /// <param name="isInherited">True if the member has access from a parent
        /// folder.</param>
        public MembershipInfo(AccessLevel accessType,
                              col.IEnumerable<MemberPermission> permissions = null,
                              string initials = null,
                              bool isInherited = false)
        {
            if (accessType == null)
            {
                throw new sys.ArgumentNullException("accessType");
            }

            var permissionsList = enc.Util.ToList(permissions);

            this.AccessType = accessType;
            this.Permissions = permissionsList;
            this.Initials = initials;
            this.IsInherited = isInherited;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembershipInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MembershipInfo()
        {
            this.IsInherited = false;
        }

        /// <summary>
        /// <para>The access type for this member.</para>
        /// </summary>
        public AccessLevel AccessType { get; protected set; }

        /// <summary>
        /// <para>The permissions that requesting user has on this member. The set of
        /// permissions corresponds to the MemberActions in the request.</para>
        /// </summary>
        public col.IList<MemberPermission> Permissions { get; protected set; }

        /// <summary>
        /// <para>Suggested name initials for a member.</para>
        /// </summary>
        public string Initials { get; protected set; }

        /// <summary>
        /// <para>True if the member has access from a parent folder.</para>
        /// </summary>
        public bool IsInherited { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembershipInfo" />.</para>
        /// </summary>
        private class MembershipInfoEncoder : enc.StructEncoder<MembershipInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembershipInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
                if (value.Permissions.Count > 0)
                {
                    WriteListProperty("permissions", value.Permissions, writer, global::Dropbox.Api.Sharing.MemberPermission.Encoder);
                }
                if (value.Initials != null)
                {
                    WriteProperty("initials", value.Initials, writer, enc.StringEncoder.Instance);
                }
                WriteProperty("is_inherited", value.IsInherited, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembershipInfo" />.</para>
        /// </summary>
        private class MembershipInfoDecoder : enc.StructDecoder<MembershipInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembershipInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembershipInfo Create()
            {
                return new MembershipInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MembershipInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "permissions":
                        value.Permissions = ReadList<MemberPermission>(reader, global::Dropbox.Api.Sharing.MemberPermission.Decoder);
                        break;
                    case "initials":
                        value.Initials = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_inherited":
                        value.IsInherited = enc.BooleanDecoder.Instance.Decode(reader);
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
