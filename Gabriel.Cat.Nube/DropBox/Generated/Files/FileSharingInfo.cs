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
    /// <para>Sharing info for a file which is contained by a shared folder.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Files.SharingInfo" />
    public class FileSharingInfo : SharingInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileSharingInfo> Encoder = new FileSharingInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileSharingInfo> Decoder = new FileSharingInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileSharingInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="readOnly">True if the file or folder is inside a read-only shared
        /// folder.</param>
        /// <param name="parentSharedFolderId">ID of shared folder that holds this
        /// file.</param>
        /// <param name="modifiedBy">The last user who modified the file. This field will be
        /// null if the user's account has been deleted.</param>
        public FileSharingInfo(bool readOnly,
                               string parentSharedFolderId,
                               string modifiedBy = null)
            : base(readOnly)
        {
            if (parentSharedFolderId == null)
            {
                throw new sys.ArgumentNullException("parentSharedFolderId");
            }
            if (!re.Regex.IsMatch(parentSharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("parentSharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
            }

            if (modifiedBy != null)
            {
                if (modifiedBy.Length < 40)
                {
                    throw new sys.ArgumentOutOfRangeException("modifiedBy", "Length should be at least 40");
                }
                if (modifiedBy.Length > 40)
                {
                    throw new sys.ArgumentOutOfRangeException("modifiedBy", "Length should be at most 40");
                }
            }

            this.ParentSharedFolderId = parentSharedFolderId;
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileSharingInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileSharingInfo()
        {
        }

        /// <summary>
        /// <para>ID of shared folder that holds this file.</para>
        /// </summary>
        public string ParentSharedFolderId { get; protected set; }

        /// <summary>
        /// <para>The last user who modified the file. This field will be null if the user's
        /// account has been deleted.</para>
        /// </summary>
        public string ModifiedBy { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileSharingInfo" />.</para>
        /// </summary>
        private class FileSharingInfoEncoder : enc.StructEncoder<FileSharingInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileSharingInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("read_only", value.ReadOnly, writer, enc.BooleanEncoder.Instance);
                WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                if (value.ModifiedBy != null)
                {
                    WriteProperty("modified_by", value.ModifiedBy, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileSharingInfo" />.</para>
        /// </summary>
        private class FileSharingInfoDecoder : enc.StructDecoder<FileSharingInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileSharingInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileSharingInfo Create()
            {
                return new FileSharingInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileSharingInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "read_only":
                        value.ReadOnly = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "modified_by":
                        value.ModifiedBy = enc.StringDecoder.Instance.Decode(reader);
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
