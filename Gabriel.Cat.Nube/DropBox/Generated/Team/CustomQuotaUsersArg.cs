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
    /// <para>The custom quota users arg object</para>
    /// </summary>
    public class CustomQuotaUsersArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CustomQuotaUsersArg> Encoder = new CustomQuotaUsersArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CustomQuotaUsersArg> Decoder = new CustomQuotaUsersArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CustomQuotaUsersArg" />
        /// class.</para>
        /// </summary>
        /// <param name="users">List of users.</param>
        public CustomQuotaUsersArg(col.IEnumerable<UserSelectorArg> users)
        {
            var usersList = enc.Util.ToList(users);

            if (users == null)
            {
                throw new sys.ArgumentNullException("users");
            }

            this.Users = usersList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CustomQuotaUsersArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CustomQuotaUsersArg()
        {
        }

        /// <summary>
        /// <para>List of users.</para>
        /// </summary>
        public col.IList<UserSelectorArg> Users { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CustomQuotaUsersArg" />.</para>
        /// </summary>
        private class CustomQuotaUsersArgEncoder : enc.StructEncoder<CustomQuotaUsersArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CustomQuotaUsersArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("users", value.Users, writer, global::Dropbox.Api.Team.UserSelectorArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CustomQuotaUsersArg" />.</para>
        /// </summary>
        private class CustomQuotaUsersArgDecoder : enc.StructDecoder<CustomQuotaUsersArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CustomQuotaUsersArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CustomQuotaUsersArg Create()
            {
                return new CustomQuotaUsersArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CustomQuotaUsersArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "users":
                        value.Users = ReadList<UserSelectorArg>(reader, global::Dropbox.Api.Team.UserSelectorArg.Decoder);
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